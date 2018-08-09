using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace opp_1_9._8._18
{
    class cat
    {
        public string name = "mitins";
        public bool isAlive = true;
        public void eat(mouse jery)
        {
            Console.WriteLine(name + " is eating " + jery.name);
            jery.die();
        }
        public void drink(string bevrage)
        {
            if(bevrage.ToLower() == "milk")
            {
                Console.WriteLine("cat " + name + " gladly drinks milk");
            }
            else
            {
                Console.WriteLine("cat " + name + " refuses to drink " + bevrage);
            }
        }
    }
}
