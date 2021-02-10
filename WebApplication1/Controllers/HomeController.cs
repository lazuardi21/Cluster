using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";

            return View();
        }

        public ActionResult DataVis()
        {
            ViewBag.Title = "DataVis";

            return View();
        }

        public ActionResult DataTable()
        {
            ViewBag.Title = "DataTable";

            return View();
        }

        public ActionResult Population()
        {
            ViewBag.Title = "Population";

            return View();
        }

        public ActionResult VisPop()
        {
            ViewBag.Title = "VisPop";

            return View();
        }
    }
}
