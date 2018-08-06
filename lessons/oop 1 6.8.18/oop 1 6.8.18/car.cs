using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_1_6._8._18
{
    class car
    {
        public int year=2000;
        public string color;
        public string model;
        public bool hasSafe;

        //constractor
        public car()
        {
            color = "white";
            Console.WriteLine("bip");

        }
        public void drive()
        {
            Console.WriteLine($"{color} {model} drives..");
        }
    }
}
