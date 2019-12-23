using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MVC_HomeWork.Models;

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
            ///亂數物件宣告
            Random rnd = new Random();
            
            //紀錄列表產生
            List<ViewModels.BookKeepViewModel.Record> records = new List<ViewModels.BookKeepViewModel.Record>();
            for(int RR =0;RR < 100;RR++)
            {                
                records.Add(new ViewModels.BookKeepViewModel.Record()
                {CountID = RR+1,CountCS=(ViewModels.BookKeepViewModel.CountCS)(int)(rnd.Next(0,100)%2),CreateTime = DateTime.Now,Money = rnd.Next(0,10000) });
            }
            return records;
        }

        
    }
}