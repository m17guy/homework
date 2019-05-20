using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class booksController : Controller
    {
        // GET: books
        public ActionResult Index(string id)
        {

            return Content("id = "+id);
        }
        public ActionResult findbook(int? id)
        {
            var nobook = new book() { name = "" };
            var book1 = new book() { name = "fire", auther = "crischin cashor", type="factasy" };
            var librery = new book[] { book1, new book { name = "graceling", auther = "crischin cashor", type = "factasy" }, new book { name = "old mans war", auther = "john scolzy", type = "sci-fi" } };
            for(int i=0;i<librery.Length;i++)
            {
                librery[i].id = i+1;
            }
            foreach(book b in librery)
            {
                if (id == b.id)
                {
                    return View(b);
                }
            }
            return View(nobook);
            //return Content("book not found");
        }
    }
}