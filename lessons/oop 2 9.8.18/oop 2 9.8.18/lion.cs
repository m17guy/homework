using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_2_9._8._18
{
    class lion:animal
    {
        public lion()
        {
            noise = "rawr";
        }
        public void eat(cow a)
        {
            if (isAlive)
            {
                Console.WriteLine(name + " the lion is eating " + a.name + " the cow");
                a.die();
            }
            else
            {
                Console.WriteLine(name+" the lion is not alive");
            }
        }
    }
}
