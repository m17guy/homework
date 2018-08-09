using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_2_9._8._18
{
    class Program
    {
        static void Main(string[] args)
        {
            mouse a = new mouse();
            cat mit = new cat();
            cow acow = new cow();
            lion alion = new lion();
            mit.name="mitzy";
            //Console.WriteLine(a.name);
            mit.drinkmilk("Piss");
            mit.drinkmilk(acow.givemilk());
            alion.eat(acow);
            alion.makenoise();
            mit.drinkmilk(acow.givemilk());
            Console.ReadKey();
        }
    }
}
