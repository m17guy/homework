using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class booksController : Controller
    {
        // GET: books
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult bestseller()
        {
            book testbook = new book { author = "john scolzi", name = "old mans war", pagecount = 365 };
            return View(testbook);
        }
    }
}