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
        private BookKeepModels models;

        public BookKeepController()
        {
            models = new BookKeepModels();
        }
        // GET: BookKeep
        public ActionResult Index()
        {
            return View(models);
        }
    }
}