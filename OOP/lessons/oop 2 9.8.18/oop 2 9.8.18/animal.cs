using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_2_9._8._18
{
    class animal
    {
        public bool isAlive = true;
        public string name="its a' me";
        public string noise;
        public void die()
        {
            isAlive = false;
        }
        public void makenoise()
        {
            Console.WriteLine(noise);
        }
    }
}
