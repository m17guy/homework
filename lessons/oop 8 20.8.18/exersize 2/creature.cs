using System;
using System.Collections.Generic;
using System.Text;

namespace exersize_2
{
    class creature
    {
        protected string name;
        protected bool isalive;
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
        public void die()
        {
            isalive = false;
        }
    }
}
