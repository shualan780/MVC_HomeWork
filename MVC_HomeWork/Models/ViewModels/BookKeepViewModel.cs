using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC_HomeWork.Models.ViewModels
{
    public class BookKeepViewModel
    {
        /// <summary>
        /// 紀錄類別
        /// </summary>
        public class Record
        {
            /// <summary>
            /// 記帳編號
            /// </summary>
            public int countID { get; set; }
            /// <summary>
            /// 記帳類別
            /// </summary>
            public string countCS { get; set; }
            /// <summary>
            /// 紀錄建立時間
            /// </summary>
            public DateTime CreateTime { get; set; }
            /// <summary>
            /// 金額
            /// </summary>
            public decimal Money { get; set; }
        }

    }
}