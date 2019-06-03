using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace storeinventory.Controllers
{
    public class storeController : Controller
    {

        public DB kenyonit = new DB();
        public IActionResult Index()
        {
            return View("show");
        }
        public IActionResult show()
        {
            return View(kenyonit);
        }
        public IActionResult add(int id, string name, int amount, double price)
        {
            return addtoDB(new product { id = id, name = name, amount = amount, price = price });
            //return Content(amount + " " + name + " were added");
        }
        public IActionResult addtoDB(product p)
        {
            //for(int i = 0; i < DB.inventory.Capacity; i++)
            {
                //if (DB.inventory[i].id == p.id)
                {
                    //DB.inventory[i].amount += p.amount;
                    //break;
                }
                //else
                {
                    DB.inventory.Add(p);
                }
            }
            return Content(p.amount + " " + p.name + " were added");
        }
    }
}