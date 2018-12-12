using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_1_16._8._18_static_non_static
{
    class PhoneX
    {
        public string _Color; // non-static
        public static double _ScreenSize=1; // static
        public void ring()
        {
            Console.WriteLine("ring ring");
        }
    }
}
