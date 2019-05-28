using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ex2.Models;

namespace ex2.Controllers
{
    public class dogController : Controller
    {
        public dog[] dlist = { new dog { name = "moe", age = 9, id=1 }, new dog { name = "dvash", age = 15, id = 2 }, new dog { name = "mick", age = 4, id = 3 }, new dog { name = "killer", age = 6, id = 4 } };
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult seedog(int id)
        {
            dog d;
            foreach(dog mydog in dlist)
            {
                if (id == mydog.id)
                {
                    d = mydog;
                    return View(d);
                }
            }
            return View(null);
        }
        public IActionResult ran()
        {
            Random r = new Random();
            return View("seedog",dlist[r.Next(dlist.Length)]);
        }
    }
}