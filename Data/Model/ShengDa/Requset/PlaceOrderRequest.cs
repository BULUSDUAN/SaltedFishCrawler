﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Model.ShengDa.Requset
{
    /// <summary>
    /// 投注请求
    /// </summary>
    public class PlaceOrderRequest
    {
        public Datas BettingData { get; set; }

        public string session_id { get; set; }
    }

    public class Datas
    {
        public List<BettingDataInfo> BettingData { get; set; }
    }


    public class BettingDataInfo
    {
        /// <summary>
        /// 彩种编号
        /// </summary>
        public string lottery_code { get; set; }

        /// <summary>
        /// 10A0第一球，10B0第二球
        /// </summary>
        public string play_detail_code { get; set; }
        /// <summary>
        /// 期数
        /// </summary>
        public string issuseNo { get; set; }
        /// <summary>
        /// 投注数字
        /// </summary>
        public string betting_number { get; set; }

        /// <summary>
        /// 投注金额
        /// </summary>
        public int betting_money { get; set; }

        /// <summary>
        /// 投注注数
        /// </summary>
        public int betting_count { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int client_type { get; set; }

    }
}
