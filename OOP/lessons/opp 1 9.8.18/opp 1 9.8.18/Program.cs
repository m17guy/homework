using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace opp_1_9._8._18
{
    class Program
    {
        static void Main(string[] args)
        {
            mouse mouse = new mouse();
            cat cat = new cat();
            cow cow = new cow();
            cat.drink("beer");
            cat.drink(cow.getmilk());
            cat.eat(mouse);
            Console.ReadKey();
        }
    }
}
