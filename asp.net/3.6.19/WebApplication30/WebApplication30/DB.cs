using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication30
{
	public static class DB
	{
		static DB()
		{
			items = new List<Item>();
		}
		public static List<Item> items;
	}
}
