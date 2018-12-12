using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_1_6._8._18
{
    class Program
    {
        static void Main(string[] args)
        {
            car c = new car();
            c.year = 2018;
            c.model = "shevy";
            c.color = "green";
            c.hasSafe = true;
            Console.WriteLine($"i just got a {c.color} {c.model}");
            c.drive();

            Cow a1337 = new Cow();
            //count test
            Cow a1338 = new Cow();
            Cow a1339 = new Cow();
            Cow a133 = new Cow();
            Console.WriteLine(a1337.makemilk());
            Lion a42 = new Lion();
            a42.eat(a133);
            Console.WriteLine(a1337.makemilk());
            Console.ReadKey();
        }
    }
}
