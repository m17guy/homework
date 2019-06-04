using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace storeinventory
{
    public static class DB
    {
        static DB()
        {
            inventory = new List<product>();
            inventory.Add(new product { id = "1", name = "socks", amount = 5, price = 20 });
        }
        public static List<product> inventory;

    }
}
