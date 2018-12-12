using System;

namespace work
{
    class Program
    {
        static void Main(string[] args)
        {
            Ifliable theD = wingFactory.factory("the BIG one");
            Console.WriteLine(theD is plane);
            Console.ReadKey();
        }
    }
}
