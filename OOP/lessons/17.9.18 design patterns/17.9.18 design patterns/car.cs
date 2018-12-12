using System;
using System.Collections.Generic;
using System.Text;

namespace _17._9._18_design_patterns
{
    class car : Idrivable
    {
        public string colore;
        public string year;
        public int maxspeed;
        public void drive()
        {
            Console.WriteLine("car drives");
        }
    }
}
