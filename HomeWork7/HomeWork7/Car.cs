using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork7
{
    class Car:Vehicle
    {
        public Car()
        {
            seats = 5;
        }
        public void drift()
        {
            Console.WriteLine(name+" is drifting");
        }
    }
}
