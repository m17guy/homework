using System;
using System.Collections.Generic;
using System.Text;

namespace exersize
{
    abstract class character
    {
        private string name;
        public character(string name)
        {
            this.name = name;
        }
        public string Name
        {
            get
            {
                return name;
            }
        }
        public abstract bool isgood();
        public abstract void dostuff();
    }
}
