using System;

namespace oop_7_20._8._18
{
    class Program
    {
        static void Main(string[] args)
        {
            //Shape s = new Shape; cant have abstract class
            Shape[] shape = { new circle(9), new triangle(4, 6), new square(7) };
            foreach(Shape s in shape)
            {
                s.calcarea(); // polymorphism
                Console.WriteLine(s.Area);
            }
        }
    }
}
