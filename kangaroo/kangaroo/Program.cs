using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kangaroo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(kangaroo(0,4,3,2));
            Console.ReadKey();
        }
        static bool kangaroo(int startone, int starttwo, int moveone, int movetwo)
        {
            if(startone > starttwo && moveone > movetwo || startone < starttwo && moveone < movetwo)
            {
                return false;
            }
            double jumpnum = (starttwo - startone);
            jumpnum = jumpnum / (moveone - movetwo);
            if (jumpnum % 1 == 0)
            {
                Console.WriteLine("they will get to the same point after " + jumpnum + " jumps. at point " + (moveone * jumpnum + startone));
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
