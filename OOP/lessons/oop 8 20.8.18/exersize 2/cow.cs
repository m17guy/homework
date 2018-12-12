using System;
using System.Collections.Generic;
using System.Text;

namespace exersize_2
{
    class cow : animal, Ivegen
    {
        public void eat(plant p)
        {
            Console.WriteLine(Name+" is eating " +p.Name);
            p.die();
        }

        public override void makenoise()
        {
            Console.WriteLine("moooouuuuu");
        }
        public string givemilk()
        {
           return isalive ?  "milk" : null;
        }
    }
}
