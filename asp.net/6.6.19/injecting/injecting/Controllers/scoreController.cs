using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using injecting.Models;

namespace injecting.Controllers
{
    public class scoreController : Controller
    {
        Idb thescores;
        public scoreController(Idb theDB)
        {
            this.thescores = theDB;/*
            thescores.addscore("123");
            thescores.getscore().Add("995");
            */
        }
        public IActionResult Index()
        {
            return View(thescores);
        }
        public IActionResult showscores()
        {
            return View();
        }
        public IActionResult add(string id)
        {
            thescores.addscore(id);
            return Content(id + " was added");
        }
    }
}