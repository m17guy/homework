using System;
using System.Collections.Generic;
using System.Text;

namespace flyweight
{
    class image
    {
        string path;
        byte[] data;
        public image(string p)
        {
            path = p;
            data = new byte[1024];//for example
        }
        public void show()
        {
            Console.WriteLine("path => "+path+"\n data=> "+data.Length);
        }
    }
}
