# B站直播陪伴记录查询工具

## 介绍
该工具既能够查询自己在直播间所获得的粉丝勋章的相关信息，包括勋章名、勋章等级、对应的主播、当日亲密度、总亲密度、勋章获取时间、勋章处于点亮还是熄灭的状态，还能够查询自己在获取了某个勋章的直播间累计消费的电池、累计发送的弹幕以及累计的观看时间。

## 使用方法
1. 在UID输入框中输入想要查询信息的UID号，然后在Cookie输入框中输入访问时的Cookie。最后点击“点击查询”按钮，稍等片刻，列表中就会出现相关的信息（勋章的数量越多，整个获取的过程就会越耗时）。
2. 除此之外，当数据全部获取完毕之后，还能将DataGridView中的数据导出为Excel表格，其字体、边框、列宽及其单元格颜色都尽可能做到了与DataGridView中的一致。先点击“导出数据”按钮，选择想要导出的路径，然后自己设置文件名（也可以选择默认的名字），最后点击“确定”即可。

## 使用说明
1. 该工具能查询的所有信息，都只有在登录B站之后才能获取到，所以需要输入相关的Cookie信息；
2. 对于获取完毕后的总计消费电池、总计发送弹幕以及总计观看时间，只统计了获取了粉丝勋章的直播间的数据，并不能代表准确的数据。
3. 如果输入的uid是本人，则工具中所列出的信息都能查询到。如果是其它用户的uid，在该用户公开了粉丝勋章墙的情况下，则最多只能获取到前6列（不包含序号）的信息，且如果该用户的勋章超过了200个，则只能查询到前200个等级最高的勋章的信息（一个账号最多能有一千个粉丝勋章）。

## 技术细节
**此程序主要用到了如下的API：**
1. 获取粉丝勋章墙
    - 调用地址：https://api.live.bilibili.com/xlive/web-ucenter/user/MedalWall
    - | 字段  | 必选  | 类型  |    说明    |
      |:---:|:---:|:--------:|:----:|
      | target_id |  是  | int | 需要查询的uid |

   <details>
      <summary style="font-weight: bold">访问之后会返回如下结果</summary>
   
   ```json
   {
    "code": 0,
    "message": "0",
    "ttl": 1,
    "data": {
      "list": [
        {
          "medal_info": {
            "target_id": ???,
            "level": 24,
            "medal_name": "???",
            "medal_color_start": 1725515,
            "medal_color_end": 5414290,
            "medal_color_border": 6809855,
            "guard_level": 3,
            "wearing_status": 1,
            "medal_id": ???,
            "intimacy": 3060,
            "next_intimacy": 7500,
            "today_feed": 0,
            "day_limit": 250000,
            "guard_icon": "???",
            "honor_icon": ""
         },
          "target_name": "???",
          "target_icon": "???",
          "link": "???",
          "live_status": 0,
          "official": 0
        }
      ],
      "count": 147,
      "close_space_medal": 0,
      "only_show_wearing": 0,
      "name": "???",
      "icon": "???",
      "uid": ???,
      "level": 6
      }
    }
   ```
   </details>
   <details>
      <summary style="font-weight: bold">部分Json对象说明</summary>
   对象名根据上述Json信息从上到下说明：

   |         对象        |   类型   |           说明           |
   |:------:|:----------------------:|:------:|
   | target_id          |  int   |         主播的uid         |
   | medal_name         | string |          勋章名字          |
   | medal_color_start  |  int   |   勋章渐变起始部分颜色（十进制RGB）   |
   | medal_color_end    |  int   |   勋章渐变末尾部分颜色（十进制RGB）   |
   | medal_color_border |  int   |     勋章边框颜色（十进制RGB）     |
   | guard_level        |  int   | 大航海等级（3：舰长，2：提督，1：总督）  |
   | wearing_status     |  int   |   勋章佩戴状态（1：佩戴，0：摘下）    |
   | medal_id           |  int   |          勋章id          |
   | intimacy           |  int   |         该等级亲密度         |
   | next_intimacy      |  int   |        该等级总亲密度         |
   | today_feed         |  int   |         今日亲密度          |
   | day_limit          |  int   |        今日最大亲密度         |
   | guard_icon         | string |        大航海图标链接         |
   | honor_icon         | string |                        |
   | target_name          | string |          主播昵称          |
   | target_icon          | string |        主播头像图片链接        |
   | link          | string |         主播个人空间         |
   | live_status          |  int   |   主播开播状态（1：开播，0：未开播）   |
   | official          |  int   |   是否有官方的小闪电（1：有，0：无）   |
   | count          |  int   |         用户勋章总数         |
   | close_space_medal          |  int   |   是否关闭粉丝勋章墙（1：是，0：否）   |
   | only_show_wearing          |  int   | 是否只显示当前所佩戴的勋章（1：是，0：否） |
   | name          | string |          用户昵称          |
   | icon          | string |        用户头像图片链接        |
   | uid          |  int   |         用户uid          |
   | level          |  int   |          用户等级          |

   </details>

2. 获取主站个人中心勋章列表信息
   - 调用地址：https://api.live.bilibili.com/fans_medal/v1/fans_medal/get_home_medals
   - | 字段  | 必选  |   类型    |             说明              |
     |:---:|:-------:|:---------------------------:|:----:|
     | uid |  否  |   int   | 用户的uid，可有可无，填写别的uid显示的也是自己的 |
     | source |  否  |   int   |             未知              |
     | need_rank |  否  | boolean |        是否需要排序，具体作用未知        |
     | master_status |  否  |   int   | 佩戴状态（1：佩戴，0：不佩戴，没有参数则默认全选）  |
     | page |  否  |   int   |      勋章的页数，无此参数则默认为第一页      |

   <details>
   <summary style="font-weight: bold">访问之后会返回如下结果</summary>

   ```json
   {
      "code": 0,
      "msg": "主站个人中心勋章列表",
      "message": "主站个人中心勋章列表",
      "data": {
         "max": 1000,
         "cnt": 147,
         "curr_page": 1,
         "total_page": 6,
         "list": [
            {
               "uid": ???,
               "target_id": ???,
               "medal_id": ???,
               "score": 50010560,
               "level": 24,
               "intimacy": 3060,
               "status": 1,
               "source": 1,
               "receive_channel": ???,
               "is_receive": 1,
               "master_status": 1,
               "receive_time": "???",
               "today_intimacy": 0,
               "last_wear_time": 1695743999,
               "is_lighted": 1,
               "medal_level": 24,
               "next_intimacy": 7500,
               "day_limit": 250000,
               "today_feed": 0,
               "medal_name": "???",
               "master_available": 1,
               "guard_type": 3,
               "lpl_status": 0,
               "can_delete": false,
               "target_name": "???",
               "target_face": "???",
               "live_stream_status": 0,
               "icon_code": 0,
               "icon_text": "",
               "rank": "-",
               "medal_color": 1725515,
               "medal_color_start": 1725515,
               "medal_color_end": 5414290,
               "guard_level": 3,
               "medal_color_border": 6809855,
               "honor_icon": "",
               "guard_icon": "???"
            }
         ]
      }
   }
   ```
   </details>

   由于大部分的Json对象在1中有介绍，故此处仅介绍一些重要的：

   | 对象           |   类型   |               说明               |
   |:------:|:------------------------------:|:------:|
   | score            |  int   | 积分，若未上舰，则为亲密度的总和，否则为5千万+消费电池总数 |
   | receive_time | string |       勋章的获取时间，包含年月日和时分秒        |
   | is_lighted   | string |        勋章状态（1：点亮，0：熄灭）         |

3. 获取自己在某个主播直播间的大航海信息
   - 调用地址：https://api.live.bilibili.com/xlive/general-interface/v1/guard/GuardActive
   - | 字段  | 必选  |   类型    |     说明     |
     |:---:|:-------:|:----------:|:-----:|
     | ruid |  是  |   string   |   主播的uid   |
     | platform |  是  |   string   | 平台，这里直接填pc |

   <details>
   <summary style="font-weight: bold">访问之后会返回如下结果</summary>

   ```json
   {
       "code": 0,
       "message": "0",
       "ttl": 1,
       "data": {
           "ruid": ???,
           "rusername": "???",
           "rface": "???",
           "uface": "???",
           "username": "???",
           "accomany_day": 89,
           "guards_info": [
               {
                   "guard_type": 3,
                   "expired_time": 1695139199,
                   "guard_status": 1,
                   "renew_info": [
                       {
                           "guard_type": 3,
                           "next_execute_time": 1695139199,
                           "next_spend": 138000,
                           "origin_price": 198000
                       }
                   ]
               }
           ],
           "latest_guard": 3,
           "watch_time": 1027241,
           "send_bar": 3378,
           "up_medal": {
               "target_id": ???,
               "medal_name": "???",
               "level": 24,
               "medal_color_start": 1725515,
               "medal_color_end": 5414290,
               "medal_color_border": 6809855,
               "is_lighted": 1,
               "need_exp": 4440,
               "all_exp": 7500,
               "origin_level": 24,
               "guard_level_1": {
                   "level": 28,
                   "medal_color_start": 398668,
                   "medal_color_end": 6850801,
                   "medal_color_border": 16771156,
                   "exp": 199980,
                   "exp_battery": 19998000,
                   "guard_icon": "https://i0.hdslb.com/bfs/live/1d16bf0fcc3b1b768d1179d60f1fdbabe6ab4489.png",
                   "honor_icon": ""
               },
               "guard_level_2": {
                   "level": 26,
                   "medal_color_start": 398668,
                   "medal_color_end": 6850801,
                   "medal_color_border": 16771156,
                   "exp": 19980,
                   "exp_battery": 1998000,
                   "guard_icon": "https://i0.hdslb.com/bfs/live/98a201c14a64e860a758f089144dcf3f42e7038c.png",
                   "honor_icon": ""
               },
               "guard_level_3": {
                   "level": 24,
                   "medal_color_start": 1725515,
                   "medal_color_end": 5414290,
                   "medal_color_border": 6809855,
                   "exp": 1380,
                   "exp_battery": 138000,
                   "guard_icon": "https://i0.hdslb.com/bfs/live/143f5ec3003b4080d1b5f817a9efdca46d631945.png",
                   "honor_icon": ""
               },
               "guard_extra_gold": 0,
               "exp_limit": 250000,
               "exp_today": 0,
               "guard_icon": "https://i0.hdslb.com/bfs/live/143f5ec3003b4080d1b5f817a9efdca46d631945.png",
               "honor_icon": ""
           },
           "privileges": {
               "has_person": 0,
               "out_pic": "",
               "in_pic": "",
               "test_id": 1,
               "single_pic": ""
           },
           "is_live": 0,
           "room_url": "???",
           "is_ios_black": 0,
           "is_active": 1,
           "price_info": [
               {
                   "guard_level": 1,
                   "price": 19998000,
                   "discount_price": 15998000,
                   "auto_renew_price": 0,
                   "num": 1,
                   "discount_type": 0,
                   "expired_timestamp": 1694951153,
                   "next_auto_renew_time": "",
                   "goods_id": 5,
                   "gift_id": 10001,
                   "gift_name": "总督",
                   "buy_back_remain": 0,
                   "expired_timestamp_origin": 1694951153,
                   "guard_expired": 0
               },
               {
                   "guard_level": 2,
                   "price": 1998000,
                   "discount_price": 1598000,
                   "auto_renew_price": 0,
                   "num": 1,
                   "discount_type": 0,
                   "expired_timestamp": 1694951153,
                   "next_auto_renew_time": "",
                   "goods_id": 6,
                   "gift_id": 10002,
                   "gift_name": "提督",
                   "buy_back_remain": 0,
                   "expired_timestamp_origin": 1694951153,
                   "guard_expired": 0
               },
               {
                   "guard_level": 3,
                   "price": 198000,
                   "discount_price": 158000,
                   "auto_renew_price": 138000,
                   "num": 1,
                   "discount_type": 2,
                   "expired_timestamp": 1695139199,
                   "next_auto_renew_time": "2023-09-19",
                   "goods_id": 7,
                   "gift_id": 10003,
                   "gift_name": "舰长",
                   "buy_back_remain": 0,
                   "expired_timestamp_origin": 1695139199,
                   "guard_expired": 1695139199
               }
           ],
           "guard_num_3": 13,
           "guard_num_2": 2,
           "guard_num_1": 1,
           "room_id": ???,
           "effect_id": {
               "1": 399,
               "2": 398,
               "3": 397
           },
           "pop_msg": "",
           "room_info": {
               "area_id": 744,
               "parent_area_id": 9
           },
           "show_num": 10,
           "entry_effect_tab": 3,
           "benefits": [],
           "now": 1694951153,
           "first_guard_rate": null,
           "first_guard_open": false,
           "achieve_remind": {
               "20": "",
               "50": "",
               "100": "",
               "1000": "",
               "10000": ""
           },
           "guard_total": 16,
           "benefitv2": [],
           "ab": {
               "guard_price_multi": 1
           },
           "play_together": []
       }
   }
   ```
   </details>

由于大部分的Json对象在1中有介绍，故此处仅介绍一些重要的：

   |         对象        |   类型   |          说明          |
   |:------:|:--------------------:|:------:|
   | watch_time         |  int   | 在该直播间累计观看时间的时间戳，单位为秒 |
   | send_bar          |  int   |    在该直播间累计发送的弹幕数量    |
   | guard_extra_gold         |  int   | 开通大航海之前在该直播间所消费的电池总数 |
