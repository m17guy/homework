using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace storeinventory
{
    public class DB
    {
        public static List<product> inventory;
        public DB()
        {
            inventory = new List<product>();
            inventory.Add(new product { id = 1, name = "socks", amount = 5, price = 20 });
        }

    }
}
