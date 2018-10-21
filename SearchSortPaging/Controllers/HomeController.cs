using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SearchSortPaging.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Virksomhed()
        {
            ViewBag.Message = "Virksomheder";

            return View();
        }
        public ActionResult System()
        {
            ViewBag.Message = "System";

            return View();
        }
    }
}