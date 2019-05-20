using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication2home.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return Redirect("/students");
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return Redirect("/students");
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return Redirect("/students");
        }
    }
}