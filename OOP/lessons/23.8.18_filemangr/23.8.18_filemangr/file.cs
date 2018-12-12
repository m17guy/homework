using System;
using System.Collections.Generic;
using System.Text;

namespace _23._8._18_filemangr
{
    abstract class file
    {
        private string name;
        protected long size;
        abstract public void delete();
        public file(string name, long size)
        {
            this.name = name;
            this.size = size;
        }
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
    }
}
