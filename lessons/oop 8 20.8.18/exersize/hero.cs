using System;
using System.Collections.Generic;
using System.Text;

namespace exersize
{
    class hero : character
    {
        public hero(string name) : base(name)
        {
        }
        public override void dostuff()
        {
            Console.WriteLine("saves the day");
        }

        public override bool isgood()
        {
            return true;
        }
    }
}
