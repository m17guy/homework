using System;
using System.Collections.Generic;
using System.Text;

namespace _23._8._18_filemangr
{
    class image : file, Iexecute
    {
        public image(string name, long size) : base(name, size)
        {
        }

        public void execute()
        {
            
        }

        public override void delete()
        {
            Console.WriteLine(Name + " is being deleted");
        }
    
    
    }
}
