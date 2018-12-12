using System;
using System.Collections.Generic;
using System.Text;

namespace work
{
    class plane : Ifliable
    {
        public void land()
        {
            Console.WriteLine("plane lands safely");
        }

        public void takeoff()
        {
            Console.WriteLine("plane takes off");
        }
    }
}
