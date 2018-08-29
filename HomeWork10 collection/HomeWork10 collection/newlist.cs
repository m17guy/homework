using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork10_collection
{
    class newlist
    {
        public List<string> names = new List<string>();
        public bool lastname = false;
        public void add(string a)
        {
            if(a=="")
            {
                lastname = true;
                names.Add(a);
            }
            if (!lastname)
            {
                names.Add(a);
            }
            else
            {
                Console.WriteLine("list is closed");
            }
        }
        public void printall()
        {
            foreach(string s in names)
            {
                Console.WriteLine(s);
            }
        }
    }
}
