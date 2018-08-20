using System;
using System.Collections.Generic;
using System.Text;

namespace exersize
{
    class villan : character
    {
        public villan(string name) : base(name)
        {
        }
        public override void dostuff()
        {
            Console.WriteLine("bad stuff");
        }

        public override bool isgood()
        {
            return false;
        }
    }
}
