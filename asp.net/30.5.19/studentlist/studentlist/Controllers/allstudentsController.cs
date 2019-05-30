using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace studentlist.Controllers
{
    public class allstudentsController : Controller
    {
        public student[] theclass = { new student { name = "guy", id = 123, age = 22 }, new student { name = "noy", id = 222, age = 21 }, new student { name = "ruven", id = 999, age = 20 } };
        public IActionResult showstudent(int id)
        {
            foreach(student s in theclass)
            {
                if (s.id == id)
                {
                    return View(s);
                }
            }
            return View(null);
        }
    }
}