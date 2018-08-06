using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_1_6._8._18
{
    class Lion
    {
        public bool isalive = true;
        public string name = "alex";
        public string noise = "rowr";
        public void makenoise()
        {
            if (isalive)
                Console.WriteLine(noise);
        }
        public void die()
        {
            isalive = false;
        }
        public void eat (Cow a)
        {
            if(isalive)
            {
                a.die();
                Console.WriteLine($"{name} is eating {a.name}");
            }
        }
    }
}
