﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;
using System.Windows.Forms.Layout;
using Newtonsoft.Json.Linq;
using OfficeOpenXml;
using OfficeOpenXml.Style;

namespace BilibiliLiveAccompanyRecord {
    
    public partial class Form1 : Form {

        public Form1() {
            InitializeComponent();
            dataGridView1.Columns[2].DefaultCellStyle.ForeColor = Color.White;
        }

        private void QueryButton_Click(object sender, EventArgs e) {
            Regex reg = new Regex("^[0-9]+$");
            int lightedCount = 0, fullIntimacy = 0, totalExpense = 0, totalSendBar = 0, totalWatchTime = 0;
            if (reg.Match(UidInputBox.Text).Success && CookieInputBox.Text.Length > 0) {
                dataGridView1.Rows.Clear();
                QueryButton.Enabled = false;
                GetMedalWall();
                QueryButton.Enabled = true;
                ExportButton.Enabled = true;
                if (CookieInputBox.Text.Contains("DedeUserID=" + UidInputBox.Text) && !checkBox2.Checked) {
                    for (int i = 0; i < dataGridView1.RowCount; i++) {
                        List<string> intimacyList = new List<string>(
                            dataGridView1[6, i].Value.ToString().Split('/'));
                        lightedCount += dataGridView1[9, i].Value.ToString().Equals("点亮") ? 1 : 0;
                        fullIntimacy += intimacyList[0].Equals(intimacyList[1]) ? 1 : 0;
                        totalExpense += int.Parse(dataGridView1[10, i].Value.ToString());
                        totalSendBar += int.Parse(dataGridView1[11, i].Value.ToString());
                        totalWatchTime += FormatTimeToTimeStamp(dataGridView1[12, i].Value.ToString());
                    }

                    int medalCount = dataGridView1.RowCount;
                    MedalCountLabel.Text = medalCount.ToString();
                    LightedCountLabel.Text = lightedCount.ToString();
                    FullIntimacyLabel.Text = fullIntimacy.ToString();
                    TotalExpenseLabel.Text = totalExpense.ToString();
                    TotalSendBarLabel.Text = totalSendBar.ToString();
                    BlackoutCountLabel.Text = (medalCount - lightedCount).ToString();
                    TotalWatchTimeLabel.Text = TimeStampToFormatTime(totalWatchTime);
                    TotalWatchDayTimeLabel.Text = (int)Math.Ceiling((float)totalWatchTime / 3600 / 24) + @"天";
                } else {
                    foreach (Control control in (ArrangedElementCollection)Controls) {
                        if (control.GetType() == typeof(Label) && control.BackColor == SystemColors.HighlightText) {
                            control.Text = "";
                        } 
                    }
                }
            }
        }
        
        //将DataGridView中的数据导出为Excel表格
        private void ExportButton_Click(object sender, EventArgs e) {
            FileDialog dialog = new SaveFileDialog();
            string nameAndUid = UsernameLabel.Text + "（" + UidInputBox.Text + "）";
            dialog.Filter = @"XLSX 工作表(*.xlsx)|*.xlsx";
            dialog.Title = @"选择保存文件";
            dialog.DefaultExt = "xlsx";
            dialog.AddExtension = true;
            dialog.RestoreDirectory = true;
            dialog.FileName = DateTime.Now.ToString(
                "陪伴记录数据_" + nameAndUid + "_yyyy-MM-dd_HH.mm.ss");
            if (dialog.ShowDialog() == DialogResult.OK) {
                int offset = checkBox1.Checked ? 0 : 1;
                FileInfo newFile = new FileInfo(dialog.FileName);
                using (ExcelPackage package = new ExcelPackage(newFile)) {
                    ExcelWorksheet worksheet = package.Workbook.Worksheets.Add("数据");
                    worksheet.Column(3 - offset).Style.Fill.PatternType = ExcelFillStyle.Solid;
                    worksheet.Column(3 - offset).Style.Font.Color.SetColor(Color.White);
                    //列标题，将Excel表格中的列宽、对齐方式和字体设置成与DataGridView中的一致
                    for (int i = 0; i < dataGridView1.ColumnCount - offset; i++) {
                        worksheet.Cells[1, i + 1].Value = dataGridView1.Columns[i + offset].HeaderText;
                        worksheet.Cells[1, i + 1].Style.Border.BorderAround(ExcelBorderStyle.Thin, Color.Black);
                        worksheet.Column(i + 1).Width = dataGridView1.Columns[i + offset].Width / 8.0F;
                        worksheet.Column(i + 1).Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                        worksheet.Column(i + 1).Style.Font.SetFromFont(dataGridView1.DefaultCellStyle.Font);
                    }

                    //将DataGridView中的数据写入到Excel表格中（行列下标的初始值是1而不是0）
                    for (int i = 0; i < dataGridView1.RowCount; i++) {
                        for (int j = 0; j < dataGridView1.ColumnCount - offset; j++) {
                            worksheet.Cells[i + 2, j + 1].Value = dataGridView1[j + offset, i].Value;
                            worksheet.Cells[i + 2, 3 - offset].Style.Fill.PatternType = ExcelFillStyle.Solid;
                            worksheet.Cells[i + 2, 3 - offset].Style.Fill.BackgroundColor
                                .SetColor(dataGridView1[2, i].Style.BackColor);
                            worksheet.Cells[i + 2, j + 1].Style.Border.BorderAround(ExcelBorderStyle.Thin, Color.Black);
                        }
                    }

                    //由于首行为各列标题，故将首行字体设置为黑色加粗
                    worksheet.Row(1).Style.Font.Bold = true;
                    worksheet.Row(1).Style.Font.Color.SetColor(Color.Black);
                    worksheet.View.FreezePanes(2, 1); //冻结首行
                    package.Save();
                }

                //导出成功之后会出现提示
                DialogResult dialogResult = MessageBox.Show(@"导出成功！是否打开文件？",
                    @"提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (dialogResult == DialogResult.Yes) {
                    Process.Start(dialog.FileName);
                }
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
            if (e.Column.Index != 12) return;
            int second1 = FormatTimeToTimeStamp(e.CellValue1);
            int second2 = FormatTimeToTimeStamp(e.CellValue2);
            e.SortResult = second1 > second2 ? 1 : second1 == second2 ? 0 : -1;
            e.Handled = true;
        }

        private void GetMedalWall() {
            string biliUrl = "https://api.live.bilibili.com/xlive/web-ucenter/user/MedalWall?target_id=" + UidInputBox.Text;
            JObject jObject = GetJsonFromUrl(biliUrl, CookieInputBox.Text);
            if (jObject["code"] != null && int.Parse(jObject["code"].ToString()) == 0) {
                UsernameLabel.Text = jObject["data"]?["name"]?.ToString();
                if (CookieInputBox.Text.Contains("DedeUserID=" + UidInputBox.Text) && !checkBox2.Checked) {
                    //由于B站提供的API最多只能查询前200个勋章，所以这里通过主站个人空间勋章列表；
                    //只有查询的uid是当前登录用户的uid，才会执行此处的代码；
                    //由于获取过程相对耗时，当输入的UID与Cookie中的UID不匹配时，则会停止获取，以节省时间。
                    if (GetHomeMedalTotalPage() <= 0) return;
                    JArray jArray = new JArray();
                    //遍历每一页的信息，并将它们合并成一个整体。
                    for (int i = 1; i <= GetHomeMedalTotalPage(); i++) {
                        jArray.Merge(GetHomeMedalArrayByPage(i));
                    }
                    
                    dataGridView1.Rows.Add(jArray.Count);
                    for (var i = 0; i < jArray.Count; i++) {
                        JObject tempObject = JObject.Parse(jArray[i].ToString());
                        JToken isLightedToken = tempObject["is_lighted"];
                        var targetId = tempObject["target_id"]?.ToString();
                        var currentIntimacy = tempObject["intimacy"]?.ToString();
                        var nextIntimacy = tempObject["next_intimacy"]?.ToString();
                        bool isLighted = isLightedToken != null && isLightedToken.ToString().Equals("1");
                        int medalColor = int.Parse(tempObject["medal_color_start"]?.ToString() ?? "0");
                        dataGridView1[1, i].Value = tempObject["target_name"]?.ToString();
                        dataGridView1[2, i].Value = tempObject["medal_name"]?.ToString();
                        dataGridView1[2, i].Style.BackColor = DecimalToColor(medalColor);
                        dataGridView1[3, i].Value = int.Parse(tempObject["medal_level"]?.ToString() ?? "0");
                        dataGridView1[4, i].Value = int.Parse(tempObject["medal_id"]?.ToString() ?? "0");
                        dataGridView1[5, i].Value = currentIntimacy + "/" + nextIntimacy;
                        var todayFeed = tempObject["today_feed"]?.ToString();
                        var dayLimit = tempObject["day_limit"]?.ToString();
                        dataGridView1[6, i].Value = todayFeed + "/" + dayLimit;
                        dataGridView1[7, i].Value = tempObject["receive_time"]?.ToString();
                        dataGridView1[8, i].Value = int.Parse(tempObject["score"]?.ToString() ?? "0");
                        dataGridView1[9, i].Value = isLighted ? "点亮" : "熄灭";
                        dataGridView1[0, i].Value = i + 1;
                        if (currentIntimacy != null) GetGuardActive(targetId, i, int.Parse(currentIntimacy));
                        Thread.Sleep(i % 100 == 0 ? 1000 : 100);
                    }
                } else {
                    //如果查询的不是当前用户，或者勾选了“只查询粉丝勋章墙”，则执行此处代码；
                    //由于API的限制，只能获取到前200个勋章，以及这些勋章的亲密度；
                    //根据所输入的UID来获取对应用户粉丝勋章墙的相关信息；
                    //如果该用户并未公开其粉丝勋章墙，则会获取失败。
                    var closeSpaceMedal = jObject["data"]?["close_space_medal"]?.ToString();
                    var onlyShowWearing = jObject["data"]?["only_show_wearing"]?.ToString();
                    if (onlyShowWearing != null && closeSpaceMedal != null && (closeSpaceMedal.Equals("1") || onlyShowWearing.Equals("1"))) {
                        MessageBox.Show(@"该用户并未公开粉丝勋章墙，获取失败！", @"错误", MessageBoxButtons.OK, MessageBoxIcon.Error); return;
                    }
                    
                    JArray medalList = JArray.Parse(jObject["data"]["list"].ToString());
                    dataGridView1.Rows.Add(medalList.Count);
                    for (int i = 0; i < medalList.Count; i++) {
                        JObject tempObject = JObject.Parse(medalList[i].ToString());
                        JToken medalInfoToken = tempObject["medal_info"];
                        dataGridView1[1, i].Value = tempObject["target_name"]?.ToString();
                        dataGridView1[2, i].Value = medalInfoToken?["medal_name"]?.ToString();
                        dataGridView1[3, i].Value = int.Parse(medalInfoToken?["level"]?.ToString() ?? "0");
                        dataGridView1[4, i].Value = int.Parse(medalInfoToken?["medal_id"]?.ToString() ?? "0");
                        var currentIntimacy = medalInfoToken?["intimacy"]?.ToString();
                        var nextIntimacy = medalInfoToken?["next_intimacy"]?.ToString();
                        dataGridView1[5, i].Value = currentIntimacy + "/" + nextIntimacy;
                        var todayFeed = medalInfoToken?["today_feed"]?.ToString();
                        var dayLimit = medalInfoToken?["day_limit"]?.ToString();
                        dataGridView1[6, i].Value = todayFeed + "/" + dayLimit;
                        dataGridView1[0, i].Value = i + 1;
                        if (!CookieInputBox.Text.Contains("DedeUserID=" + UidInputBox.Text) || checkBox2.Checked) {
                            int medalColor = int.Parse(medalInfoToken?["medal_color_start"]?.ToString() ?? "0");
                            dataGridView1[2, i].Style.BackColor = DecimalToColor(medalColor);
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
                if (username != null && username.Equals(UsernameLabel.Text) && jObject["data"] != null) {
                    int medalLevel = int.Parse(jObject["data"]["up_medal"]?["level"]?.ToString() ?? "0");
                    int guardExtraGold = int.Parse(jObject["data"]["up_medal"]?["guard_extra_gold"]?.ToString() ?? "0");
                    dataGridView1[10, row].Value = medalLevel > 20 ? GetTotalGuardIntimacy(medalLevel, currentIntimacy) : guardExtraGold / 100;
                    dataGridView1[11, row].Value = int.Parse(jObject["data"]["send_bar"]?.ToString() ?? "0");
                    dataGridView1[12, row].Value = TimeStampToFormatTime(int.Parse(jObject["data"]["watch_time"]?.ToString() ?? "0"));
                }
            }
        }

        //获取个人中心的粉丝勋章中所领取的勋章的页数
        private int GetHomeMedalTotalPage() {
            const string biliUrl = "https://api.live.bilibili.com/fans_medal/v1/fans_medal/get_home_medals";
            JObject jObject = GetJsonFromUrl(biliUrl, CookieInputBox.Text);
            if (jObject["code"] == null || int.Parse(jObject["code"].ToString()) != 0) return 0;
            var totalPage = jObject["data"]?["total_page"]?.ToString();
            return totalPage != null ? int.Parse(totalPage) : 0;
        }

        //获取某页个人中心的粉丝勋章信息；
        //此API主要用于获取某个勋章的首次获取时间、亲密度的总和以及勋章是否处于点亮或熄灭的状态；
        //此API只能查询自己账号的上述信息，虽然该API提供了uid相关的参数，但无法查询其它用户的信息。
        private JArray GetHomeMedalArrayByPage(int page) {
            string biliUrl = "https://api.live.bilibili.com/fans_medal/v1/fans_medal/get_home_medals?page=" + page;
            JObject jObject = GetJsonFromUrl(biliUrl, CookieInputBox.Text);
            if (jObject["code"] == null || !jObject["code"].ToString().Equals("0")) return null;
            string list = jObject["data"]?["list"]?.ToString();
            return list != null ? JArray.Parse(list) : null;
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

        //获取链接中的Json文本内容
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
        
        private static Color DecimalToColor(int color) {
            return Color.FromArgb((color >> 16) & 255, (color >> 8) & 255, color & 255);
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