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
            countID++;
            records.Add(new Models.ViewModels.BookKeepViewModel.Record()
            { countID = countID, countCS = "支出", CreateTime = DateTime.Now, Money = 6000 });
            countID++;
            records.Add(new Models.ViewModels.BookKeepViewModel.Record()
            { countID = countID, countCS = "收入", CreateTime = DateTime.Now, Money = 7000 });
            countID++;
            records.Add(new Models.ViewModels.BookKeepViewModel.Record()
            { countID = countID, countCS = "支出", CreateTime = DateTime.Now, Money = 8000 });
            countID++;
            records.Add(new Models.ViewModels.BookKeepViewModel.Record()
            { countID = countID, countCS = "支出", CreateTime = DateTime.Now, Money = 9000 });
            return records;
        }

        public string test
        {
            get
            {
                return "test";
            }
        }
    }
}