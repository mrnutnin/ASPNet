using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Checkin_ManagerWithASPDotNet.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page."; //message is sent

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page."; //container

            return View();
        }

        public ActionResult Test()
        {
            ViewBag.Message = "Your Test page.";

            return View();
        }

        public ActionResult Test2()
        {
            ViewBag.Message = "Your Test page.";

            return View("Test2");
        }




    }
}