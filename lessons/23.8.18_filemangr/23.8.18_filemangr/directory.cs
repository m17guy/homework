using System;
using System.Collections.Generic;
using System.Text;

namespace _23._8._18_filemangr
{
    class Directory : file, Iopenable
    {
        public file[] files;

        public Directory(string name, long size) : base(name, size)
        {
            files = new file[10];
        }

        public void open(string spaces = "")
        {
            Console.WriteLine(spaces + Name);
            foreach (file x in files)
            {
                spaces += " ";
                Console.WriteLine(x != null ? spaces + x.Name : null);
                if (x is Iopenable o)
                {
                    spaces += " ";
                    o.open(spaces);
                    spaces = spaces.Substring(1);
                }
                spaces = spaces.Substring(1);
            }
        }

        public override void delete()
        {
            Console.WriteLine(Name+" is being deleted");
            foreach (file f in files) f.delete();
        }
    }
}
