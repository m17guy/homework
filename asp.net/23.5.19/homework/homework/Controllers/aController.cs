using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace homework.Controllers
{
    public class aController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult power(double p, double b)
        {
            double resolt = Math.Pow(b, p);
            ViewBag.r = resolt;
            return View();
        }
        public IActionResult bet(int min, int max)
        {
            int[] all = new int[max - min - 1];
            for(int i = 0; i < all.Length; i++)
            {
                all[i] = ++min;
            }
            ViewBag.a = all;
            return View();
        }
    }
}