using System;
using System.Collections.Generic;
using System.Text;

namespace _12._11._18
{
    class animal
    {
        string name;
        string noise;
        string eating;

        public animal(string Mname,string Mnoise, string Meating)
        {
            name = Mname;
            noise = Mnoise;
            eating = Meating;
        }
        public void makenois()
        {
            Console.WriteLine(noise);
        }
        public virtual void iseating()
        {
            Console.WriteLine(name + " is eating " + eating);
        }
        public override string ToString()
        {
            return "is alive";
        }
    }
}
