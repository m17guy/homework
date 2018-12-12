using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_6
{
    class Person
    {
        public string name = "tod";
        public int age;
        public bool isadult;
        public Person()
        {
            void bday()
            {
                age++;
                isadult = (age >= 18);
            }
        }
        public void newname(string setname)
        {
            name = setname;
        }
    }
}
