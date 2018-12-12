using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace work
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                new FullName("guy 12345678900");
            }
            catch(stringexception e)
            {
                Console.WriteLine(e);
            }
        }
    }
}
