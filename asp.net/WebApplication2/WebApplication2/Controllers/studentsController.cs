using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication2.Models;
namespace WebApplication2.Controllers
{
    public class studentsController : Controller
    {
        List<student> allkids = new List<student>
            {
                new student {name="guy", age=22, resedence="ma'ale hahamisha"},
                new student {name="ruven", age=21, resedence="ma'ale hahamisha"},
                new student {name="noy", age=21, resedence="gadera"},
                new student {name="giora", age=28, resedence="california"},
                new student {name="cait", age=26, resedence="denver"},
                new student {name="pnina", age=31, resedence="sderot"},
                new student {name="bebe", age=3, resedence="ma'ale hahamisha"}
            };
        // GET: students
        public ActionResult Index()
        {
            return View(allkids);
        }
        public ActionResult list(int id)
        {
            return View();
        }
    }
}