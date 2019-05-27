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
        public dog[] dlist = { new dog { name = "moe", age = 9 }, new dog { name = "dvash", age = 15 }, new dog { name = "mick", age = 4 }, new dog { name = "killer", age = 6 } };
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult seedog(int id)
        {
            dog d = new dog();
            return View(d);
        }
    }
}