using System;

namespace _20._9._18_design_patterns
{
    class Program
    {
        static void Main(string[] args)
        {
            warrior ninja = new warrior();

            ninja.attack();
            ninja.setability("kIck");
            ninja.attack();
            ninja.setability("GUN");
            ninja.attack();
            ninja.setability("ion-cannon");
            ninja.attack();
            Console.ReadKey();
        }
    }
}
