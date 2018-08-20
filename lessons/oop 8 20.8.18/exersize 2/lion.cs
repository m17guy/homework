using System;
using System.Collections.Generic;
using System.Text;

namespace exersize_2
{
    class lion : animal, Ihunter
    {
        public void eat(animal a)
        {
            Console.WriteLine(Name+" is eating "+a.Name);
            a.die();
        }

        public override void makenoise()
        {
            Console.WriteLine("rowr");
        }
    }
}
