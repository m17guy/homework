using System;
using System.Collections.Generic;
using System.Text;

namespace oop_8_20._8._18
{
    class plane : IDrivable, IFliable
    {
        public void Drive()
        {
            Console.WriteLine("plane drives");
        }

        public void land()
        {
            Console.WriteLine("plane lands");
        }

        public void takeoff()
        {
            Console.WriteLine("plane takes off");
        }
    }
}
