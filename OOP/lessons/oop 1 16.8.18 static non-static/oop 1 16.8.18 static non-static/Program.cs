using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_1_16._8._18_static_non_static
{
    class Program
    {
        static void Main(string[] args)
        {
            PhoneX ph = new PhoneX();
            ph._Color = "green";
            ph.ring();
            Console.WriteLine(PhoneX._ScreenSize);
            PhoneX._ScreenSize = 4;
            Console.WriteLine(PhoneX._ScreenSize);
        }
    }
}
