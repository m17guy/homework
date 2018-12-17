using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace short_lesson
{
    class Program
    {
        delegate double func(double num);
        delegate bool secondfunc();
        static void Main(string[] args)
        {
            Console.WriteLine(addfuncs(delegate (double x) { return x * x; }, delegate (double x) { return x * x * x; }, 5));
            Console.WriteLine(not(delegate() { return true; }));
        }
        static double addfuncs(func a, func b, double c)
        {
            return a(c) + b(c);
        }
        static bool not(secondfunc x)
        {
            return !x();
        }
    }
}
