using System;

namespace oop_8_20._8._18
{
    class Program
    {
        static void Main(string[] args)
        {
            IFliable[] aircrafts = { new Helicopter(), new plane()};
            foreach(IFliable f in aircrafts)
            {
                //polymorphic
                f.takeoff();
                f.land();
            }
        }
    }
}
