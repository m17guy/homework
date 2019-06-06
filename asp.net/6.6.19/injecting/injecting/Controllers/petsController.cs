using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using injecting.Models;

namespace injecting.Controllers
{
    public class petsController : Controller
    {
        Idog alldogs;
        public petsController(Idog theDB)
        {
            this.alldogs = theDB;
        }
        public IActionResult Index()
        {
            return View(alldogs);
        }
        public IActionResult showscores()
        {
            return View();
        }
        public IActionResult add(dog d)
        {
            TryValidateModel(d);
            if (ModelState.IsValid)
            {
                alldogs.adddog(d);
                return Json(d);
            }
            else
                return Content("Illegal!!!");
        }
    }
}