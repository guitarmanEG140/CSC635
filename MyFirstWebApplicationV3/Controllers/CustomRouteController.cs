using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyFirstWebApplicationV3.Controllers
{
    public class CustomRouteController : Controller
    {
        public ActionResult IndexHome()
        {
            return View();
        }

        public ActionResult AboutThisPage()
        {
            ViewBag.Message = "This is my custom route controller";

            return View();
        }

        public ActionResult ContactMe()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}