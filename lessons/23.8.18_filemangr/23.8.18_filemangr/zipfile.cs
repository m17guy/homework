using System;
using System.Collections.Generic;
using System.Text;

namespace _23._8._18_filemangr
{
    class zipfile : file, Iopenable
    {
        public zipfile(string name, long size) : base(name, size)
        {
        }

        public void open(string a)
        {
            Console.WriteLine(a + "intesting info here");
        }

        public override void delete()
        {
            Console.WriteLine(Name + " is being deleted");
        }
    }
}
