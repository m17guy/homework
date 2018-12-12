using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_2_9._8._18
{
    class cat:animal
    {
        public cat()
        {
            noise = "ryyyyy";
        }
        public void drinkmilk(string drink)
        {
            if(isAlive)
            {
                if(drink.ToLower()=="milk")
                {
                    Console.WriteLine(name + " the cat is drinking the " + drink);
                }
                else
                {
                    Console.WriteLine(name + " the cat will not drink " + drink);
                }
            }
            else
            {
                Console.WriteLine(name+" the cat is not alive");
            }
        }
    }
}
