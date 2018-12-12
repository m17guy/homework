using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_2_9._8._18
{
    class cow:animal
    {
        public cow()
        {
            noise = "moo";
        }
        public string givemilk()
        {
            return isAlive ? "Milk" : "dead cow";
        }
    }
}
