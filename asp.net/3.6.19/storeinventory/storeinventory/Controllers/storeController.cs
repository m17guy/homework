using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using storeinventory.Models;

namespace storeinventory.Controllers
{
    public class storeController : Controller
    {
        public int counter = 1;
        public IActionResult Index()
        {
            return View("show");
        }
        public IActionResult show()
        {
            return View();
        }
        public IActionResult add(string id, string name, int amount, double price)
        {
            //DB.inventory.Add(new product { id = id, name = name, amount = amount, price = price });
            //return Content(amount + " " + name + " were added");
            addtoDB(new product { id = id, name = name, amount = amount, price = price });
            return Content(amount + " " + name + " were added");
        }
        public void addtoDB(product p)
        {
            for(int i = 0; i < DB.inventory.Count; i++)
            {
                if (DB.inventory[i].id == p.id)
                {
                    if (DB.inventory[i].name == p.name)
                    {
                        DB.inventory[i].amount += p.amount;
                        return;
                    }
                    else
                    {
                        if (!p.id.Contains('.'))
                        {
                            p.id += "." + counter;
                        }
                        else
                        {
                            p.id=p.id.Replace("." + counter++, "." + counter);
                        }
                        addtoDB(p);
                        return;
                    }
                }
            }
            DB.inventory.Add(p);
        }
    }
}