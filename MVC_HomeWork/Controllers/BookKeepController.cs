using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC_HomeWork.Models;
namespace MVC_HomeWork.Controllers
{
    public class BookKeepController : Controller
    {
        // GET: BookKeep
        public ActionResult Index()
        {
            BookKeepModels models = new BookKeepModels();
            
            return View(models);
        }
    }
}