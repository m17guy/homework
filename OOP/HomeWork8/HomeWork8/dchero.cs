using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork8
{
    class dchero:Hero
    {
        private bool isalive=true;
        public void die()
        {
            isalive = false;
        }
        public override void fight()
        {
            Console.WriteLine("DC");
            base.fight();
        }
    }
}
