using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication3.Controllers
{
    public class userinfoController : Controller
    {
        // GET: userinfo
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult data()
        {
            return View();
        }
    }
}