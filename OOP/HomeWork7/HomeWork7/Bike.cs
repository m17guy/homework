using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork7
{
    class Bike: Vehicle
    {
        public Bike()
        {
            seats = 2;
        }
        public void wheeling()
        {
            Console.WriteLine(name+" is weeling");
        }
    }
}
