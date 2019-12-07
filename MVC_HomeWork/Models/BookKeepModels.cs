using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC_HomeWork.Models
{
    public class BookKeepModels
    {
        /// <summary>
        /// 取得紀錄列表
        /// </summary>
        /// <returns></returns>
        public List<Models.ViewModels.BookKeepViewModel.Record> GetRecords()
        {
            //紀錄編號
            int countID = 0;
            //紀錄列表產生
            List<Models.ViewModels.BookKeepViewModel.Record> records = new List<ViewModels.BookKeepViewModel.Record>();
            for(int RR =0;RR < 100;RR++)
            {                
                records.Add(new Models.ViewModels.BookKeepViewModel.Record()
                { countID = RR+1, countCS = "支出", CreateTime = DateTime.Now, Money = 6000 });
            }
            return records;
        }


    }
}