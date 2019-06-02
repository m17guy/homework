using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace studentlist.Controllers
{
    public class allstudentsController : Controller
    {
        public List<student> theclass = new List<student>();
        public IActionResult showstudent(int id)
        {
            if (theclass.Capacity == 0)
            {
                theclass.Add(new student { name = "guy", id = 123, age = 22 });
                theclass.Add(new student { name = "noy", id = 222, age = 21 });
                theclass.Add(new student { name = "ruven", id = 999, age = 20 });
            }
            foreach (student s in theclass)
            {
                if (s.id == id)
                {
                    return View(s);
                }
            }
            return View(null);
        }
        public IActionResult addstudent(string nam, int i, int ag)
        {
            theclass.Add(new student { name = nam, id = i, age = ag });
            return View();
        }
    }
}