using System;
using System.Collections.Generic;
using System.Text;

namespace work
{
    class helicopter : Ifliable
    {
        public void land()
        {
            Console.WriteLine("helicopter lands");
        }

        public void takeoff()
        {
            Console.WriteLine("helicopter takes off");
        }
    }
}
