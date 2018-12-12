using System;
using System.Collections.Generic;
using System.Text;

namespace hazara
{
    class trip<t>
    {
        private t one, two, three;
        public t One
        {
            set { this.one = value; }
            get { return this.one; }
        }
        public t Two
        {
            set { this.two = value; }
            get { return this.two; }
        }
        //syntactic sugar
        public t Three
        {
            set => this.three = value; 
            get => this.three; 
        }
    }
}
