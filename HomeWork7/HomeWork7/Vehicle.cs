using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork7
{
    class Vehicle
    {
        protected string name;
        protected int seats;
        public Vehicle()
        {
            name = "salsgurd";
        }
        public void drive()
        {
            Console.WriteLine(name+ " is driving");
        }
        public int seatnum()
        {
            return seats;
        }
    }
}
