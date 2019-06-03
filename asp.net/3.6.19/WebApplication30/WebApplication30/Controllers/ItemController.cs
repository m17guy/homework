using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication30.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApplication30.Controllers
{
	public class ItemController : Controller
	{
		// GET: /<controller>/
		[Route("Item/Add/{Id}/{Name}/{Cost}/{Amount}")]
		public IActionResult Add(int Id, string Name, int Cost, int Amount) //ט (מספר סידורי, שם, עלות, כמות).
		{
			DB.items.Add(new Item { Id = Id, Name = Name, Cost = Cost, Amount = Amount });
			return Redirect("/Item.html");
			
			//return Content(Name + " added to inventory");
		}
		public IActionResult Get(int Id)
		{
			return Content("Get id");
			// return View();
		}
		public IActionResult GetAll()
		{
			ItemsViewModel model = new ItemsViewModel();
			model.Items = DB.items;
			
			return View("Items", model);
		}
	}
}
