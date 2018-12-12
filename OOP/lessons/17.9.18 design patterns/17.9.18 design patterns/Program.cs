using System;

namespace _17._9._18_design_patterns
{
    class Program
    {
        static void Main(string[] args)
        {
            vehiclefactory fac = new vehiclefactory();
            Idrivable d1 = fac.createvehicle("Car");
            Idrivable d2 = fac.createvehicle("moTOr");


            
            Console.WriteLine(d2 is bike);
            Console.ReadKey();
        }
    }
}
