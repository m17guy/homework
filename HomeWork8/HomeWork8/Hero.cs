using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork8
{
    class Hero
    {
        private string name;
        private string heroPhrase;
        private string[] powers;
        public string Name
        {
            get
            {
                return name;
            }
        }
        public virtual void fight()
        {
            foreach (string i in powers)
            {
                Console.WriteLine(i);
            }
        }
        public void saycatchphrase()
        {
            Console.WriteLine(heroPhrase);
        }
    }
}
