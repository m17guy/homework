using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_2_16._8._18
{
    class Cat
    {

        public string name;
        public Cat(string name)
        {
            this.name = name;
        }
        public Cat() : this("mitins")//doing the other one first then this one
        {
            //name = "mitins";
        }
        public Cat(int a, int b) : this()//the name will = "mitins"
        {

        }
        public void eat(Mouse m) { /*eating mouse*/}
        public void eat(Fish f) { /*eating fish*/}
    }
}
