using System;
using System.Collections.Generic;
using System.ComponentModel;
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
            public int CountID { get; set; }
            /// <summary>
            /// 紀錄帳目類別
            /// </summary>
            public CountCS CountCS { get; set; }         
            /// <summary>
            /// 紀錄建立時間
            /// </summary>
            public DateTime CreateTime { get; set; }
            /// <summary>
            /// 金額
            /// </summary>
            public decimal Money { get; set; }
        }

        /// <summary>
        /// 帳目類別選項
        /// </summary>
        public enum CountCS
        {
            支出,
            收入
        }
    }
   
}