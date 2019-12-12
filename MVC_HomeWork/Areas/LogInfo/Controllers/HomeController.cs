using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_HomeWork.Areas.LogInfo.Controllers
{
    public class HomeController : Controller
    {
        // GET: LogInfo/Home
        public ActionResult Index()
        {
            return View();
        }
    }
}