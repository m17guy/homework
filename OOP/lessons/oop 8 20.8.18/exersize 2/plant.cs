using System;
using System.Collections.Generic;
using System.Text;

namespace exersize_2
{
    abstract class plant:creature
    {
        private int size=0;
        public int Size
        {
            //get { return size; }
            // protected set { size = value; }
            get => size;  //syntactic shuger
            protected set => size = value; 
        }
        public abstract void grow();
    }
}
