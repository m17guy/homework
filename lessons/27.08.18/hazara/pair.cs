using System;
using System.Collections.Generic;
using System.Text;

namespace hazara
{
    class pair<t1,t2>
    {
        private t1 one;
        private t2 two;
        public t1 One
        {
            set { this.one = value; }
            get { return this.one; }
        }
        public t2 Two
        {
            set { this.two = value; }
            get { return this.two; }
        }
    }
}
