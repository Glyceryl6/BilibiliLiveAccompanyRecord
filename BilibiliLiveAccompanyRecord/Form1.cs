using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Net;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;

namespace BilibiliLiveAccompanyRecord {
    
    public partial class Form1 : Form {

        public Form1() {
            InitializeComponent();
            dataGridView1.Columns[2].DefaultCellStyle.ForeColor = Color.White;
        }

        private void QueryButton_Click(object sender, EventArgs e) {
            Regex reg = new Regex("^[0-9]+$");
            int lightedCount = 0, totalExpense = 0, totalSendBar = 0, totalWatchTime = 0;
            if (reg.Match(UidInputBox.Text).Success && CookieInputBox.Text.Length > 0) {
                dataGridView1.Rows.Clear();
                QueryButton.Enabled = false;
                GetMedalWall();
                QueryButton.Enabled = true;
                for (int i = 0; i < dataGridView1.RowCount; i++) {
                    lightedCount += dataGridView1[9, i].Value.ToString().Equals("点亮") ? 1 : 0;
                    totalExpense += int.Parse(dataGridView1[10, i].Value.ToString());
                    totalSendBar += int.Parse(dataGridView1[11, i].Value.ToString());
                    totalWatchTime += FormatTimeToTimeStamp(dataGridView1[12, i].Value.ToString());
                }

                int medalCount = dataGridView1.RowCount;
                int totalWatchDayTime = (int)Math.Ceiling((float)totalWatchTime / 3600 / 24);
                StatisticsLabel.Text = @"总勋章数：" + medalCount +  @"（" + @"点亮：" + lightedCount + @"，熄灭：" + (medalCount - lightedCount) + @"）" +
                                       @"，总计消费电池：" + totalExpense + @"，总计发送弹幕：" + totalSendBar + 
                                       @"，总计观看时间：" + TimeStampToFormatTime(totalWatchTime) + @"（" + @"大约折合" + totalWatchDayTime + @"天" + @"）";
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e) {
            if (e.ColumnIndex == 2) {
                Color backColor = dataGridView1[2, e.RowIndex].Style.BackColor;
                Color foreColor = dataGridView1[2, e.RowIndex].Style.ForeColor;
                dataGridView1[2, e.RowIndex].Style.SelectionBackColor = backColor;
                dataGridView1[2, e.RowIndex].Style.SelectionForeColor = foreColor;
            }
        }

        //使“序号”这一列始终保持不变，以便于查看排名。
        private void dataGridView1_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e) {
            if (dataGridView1.RowCount > 0) {
                for (int i = 0; i < dataGridView1.RowCount; i++) {
                    dataGridView1[0, i].Value = i + 1;
                }
            }
        }

        //将标准的时分秒格式转换成对应的时间戳，以便于进行排序
        private void dataGridView1_SortCompare(object sender, DataGridViewSortCompareEventArgs e) {
            if (e.Column.Index == 12) {
                int second1 = FormatTimeToTimeStamp(e.CellValue1);
                int second2 = FormatTimeToTimeStamp(e.CellValue2);
                e.SortResult = second1 > second2 ? 1 : second1 == second2 ? 0 : -1;
                e.Handled = true;
            }
        }

        private void GetMedalWall() {
            string biliUrl = "https://api.live.bilibili.com/xlive/web-ucenter/user/MedalWall?target_id=" + UidInputBox.Text;
            JObject jObject = GetJsonFromUrl(biliUrl, CookieInputBox.Text);
            if (jObject["code"] != null && int.Parse(jObject["code"].ToString()) == 0) {
                JArray medalList = JArray.Parse(jObject["data"]["list"].ToString());
                UsernameLabel.Text = jObject["data"]["name"]?.ToString();
                dataGridView1.Rows.Add(medalList.Count);
                //根据所输入的UID来获取对应用户粉丝勋章墙的相关信息；
                //如果该用户并未公开其粉丝勋章墙，则会获取失败；
                //非本浏览器所登录的账号最多只能获取到前200个粉丝勋章的信息。
                for (int i = 0; i < medalList.Count; i++) {
                    JObject tempObject = JObject.Parse(medalList[i].ToString());
                    int medalColor = int.Parse(tempObject["medal_info"]["medal_color_start"].ToString());
                    dataGridView1[1, i].Value = tempObject["target_name"]?.ToString();
                    dataGridView1[2, i].Value = tempObject["medal_info"]?["medal_name"]?.ToString();
                    dataGridView1[3, i].Value = int.Parse(tempObject["medal_info"]["level"].ToString());
                    dataGridView1[4, i].Value = int.Parse(tempObject["medal_info"]["medal_id"].ToString());
                    dataGridView1[2, i].Style.BackColor = Color.FromArgb((medalColor >> 16) & 255, 
                        (medalColor >> 8) & 255, medalColor & 255);
                    string currentIntimacy = tempObject["medal_info"]?["intimacy"]?.ToString();
                    string nextIntimacy = tempObject["medal_info"]?["next_intimacy"]?.ToString();
                    dataGridView1[5, i].Value = currentIntimacy + "/" + nextIntimacy;
                    string todayFeed = tempObject["medal_info"]?["today_feed"]?.ToString();
                    string dayLimit = tempObject["medal_info"]?["day_limit"]?.ToString();
                    dataGridView1[6, i].Value = todayFeed + "/" + dayLimit;
                    dataGridView1[0, i].Value = i + 1;
                }

                //只有当前所登录账号才能获取到大航海信息以及个人中心中的粉丝勋章的相关信息；
                //由于获取过程相对耗时，当输入的UID与Cookie中的UID不匹配时，则会停止获取，以节省时间。
                //而且后面的信息也只有登录与UID相符的账号才能查询（也就是本人才能查询）。
                if (CookieInputBox.Text.Contains("DedeUserID=" + UidInputBox.Text)) {
                    for (int i = 0; i < medalList.Count; i++) {
                        JObject tempObject = JObject.Parse(medalList[i].ToString());
                        int currentIntimacy = int.Parse(tempObject["medal_info"]["intimacy"].ToString());
                        string uid = tempObject["medal_info"]?["target_id"]?.ToString();
                        GetGuardActive(uid, i, currentIntimacy);
                    }

                    if (GetHomeMedalTotalPage() > 0) {
                        JArray jArray = new JArray();
                        //遍历每一页的信息，并将它们合并成一个整体。
                        for (int i = 1; i <= GetHomeMedalTotalPage(); i++) {
                            jArray.Merge(GetHomeMedalArrayByPage(i));
                        }
                        
                        foreach (JToken token in jArray) {
                            JObject tempObject = JObject.Parse(token.ToString());
                            int medalId = int.Parse(tempObject["medal_id"].ToString());
                            string receiveTime = tempObject["receive_time"]?.ToString();
                            int totalScore = int.Parse(tempObject["score"].ToString());
                            bool isLighted = tempObject["is_lighted"].ToString().Equals("1");
                            for (int j = 0; j < medalList.Count; j++) {
                                if (int.Parse(dataGridView1[4, j].Value.ToString()) == medalId) {
                                    dataGridView1[7, j].Value = receiveTime;
                                    dataGridView1[8, j].Value = totalScore;
                                    dataGridView1[9, j].Value = isLighted ? "点亮" : "熄灭";
                                }
                            }
                        }
                    }
                }
            }
        }

        //获取大航海的相关信息，在这里只获取在开通大航海之前所消费的电池数、累计观看时间，以及在该直播间累计发送的弹幕；
        //对于后两个数据，在正常情况下，只有在开通大航海之后才能看到，普通的用户无法看到；
        //对于普通用户，只能选择通过访问相关的API链接，才能获取到这些数据。
        private void GetGuardActive(string uid, int row, int currentIntimacy) {
            string biliUrl = "https://api.live.bilibili.com/xlive/general-interface/v1/guard/GuardActive?ruid=" + uid + "&platform=pc";
            JObject jObject = GetJsonFromUrl(biliUrl, CookieInputBox.Text);
            if (jObject["code"] != null && int.Parse(jObject["code"].ToString()) == 0) {
                string username = jObject["data"]?["username"]?.ToString();
                if (username != null && username.Equals(UsernameLabel.Text)) {
                    int medalLevel = int.Parse(jObject["data"]["up_medal"]["level"].ToString());
                    int guardExtraGold = int.Parse(jObject["data"]["up_medal"]["guard_extra_gold"].ToString());
                    dataGridView1[10, row].Value = medalLevel > 20 ? GetTotalGuardIntimacy(medalLevel, currentIntimacy) : guardExtraGold / 100;
                    dataGridView1[11, row].Value = int.Parse(jObject["data"]["send_bar"].ToString());
                    dataGridView1[12, row].Value = TimeStampToFormatTime(int.Parse(jObject["data"]["watch_time"].ToString()));
                }
            }
        }

        //获取个人中心的粉丝勋章中所领取的勋章的页数
        private int GetHomeMedalTotalPage() {
            string biliUrl = "https://api.live.bilibili.com/fans_medal/v1/fans_medal/get_home_medals";
            JObject jObject = GetJsonFromUrl(biliUrl, CookieInputBox.Text);
            if (jObject["code"] != null && int.Parse(jObject["code"].ToString()) == 0) {
                string totalPage = jObject["data"]?["total_page"]?.ToString();
                return totalPage != null ? int.Parse(totalPage) : 0;
            }
            return 0;
        }

        //获取某页个人中心的粉丝勋章信息；
        //此API主要用于获取某个勋章的首次获取时间、亲密度的总和以及勋章是否处于点亮或熄灭的状态；
        //此API只能查询自己账号的上述信息，虽然该API提供了uid相关的参数，但无法查询其它用户的信息。
        private JArray GetHomeMedalArrayByPage(int page) {
            string biliUrl = "https://api.live.bilibili.com/fans_medal/v1/fans_medal/get_home_medals?page=" + page;
            JObject jObject = GetJsonFromUrl(biliUrl, CookieInputBox.Text);
            if (jObject["code"] != null && int.Parse(jObject["code"].ToString()) == 0) {
                string list = jObject["data"]?["list"]?.ToString();
                return list != null ? JArray.Parse(list) : null;
            }
            return null;
        }

        //计算在大航海中消费的电池
        private static int GetTotalGuardIntimacy(int medalLevel, int currentIntimacy) {
            int totalGuardIntimacy = 0;
            int[] guardIntimacy = {4, 5, 6, 15, 30, 80, 180, 320, 560, 1400, 
                2400, 4000, 5000, 6000, 7000, 8000, 15000, 20000, 30000};
            for (int i = 0; i < medalLevel - 21; i++) {
                totalGuardIntimacy += guardIntimacy[i] * 500;
            }
            return totalGuardIntimacy + currentIntimacy;
        }

        //从获取链接中的Json文本内容，并对其进行序列化处理
        private static JObject GetJsonFromUrl(string url, string cookie) {
            HttpWebRequest req = (HttpWebRequest) WebRequest.Create(url);
            req.Method = "GET";
            req.ContentType = "application/json, charset=utf-8";
            req.UserAgent = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/112.0.0.0 Safari/537.36 Edg/112.0.1722.48";
            req.Headers.Add("Cookie", cookie); //由于需要登录之后才能查看，所以需要获取相关的Cookie
            HttpWebResponse resp = (HttpWebResponse) req.GetResponse();
            Stream stream = resp.GetResponseStream();
            StreamReader reader = new StreamReader(stream, false);
            return JObject.Parse(reader.ReadToEnd());
        }

        //将时间戳转换成标准的时分秒的形式
        private static string TimeStampToFormatTime(int sec) {
            int hour = sec / 3600;
            int minute = sec % 3600 / 60;
            int second = sec % 60;
            return hour + "小时" + minute + "分钟" + second + "秒";
        }

        private static int FormatTimeToTimeStamp(object value) {
            string cellValue = value.ToString().Replace("小时", ":")
                .Replace("分钟", ":").Replace("秒", "");
            List<string> list = new List<string>(cellValue.Split(':'));
            return int.Parse(list[0]) * 3600 + int.Parse(list[1]) * 60 + int.Parse(list[2]);
        }

    }

}