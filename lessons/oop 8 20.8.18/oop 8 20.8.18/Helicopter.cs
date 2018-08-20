using System;
using System.Collections.Generic;
using System.Text;

namespace oop_8_20._8._18
{
    class Helicopter : IFliable
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
