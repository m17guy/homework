using System;
using System.Collections.Generic;
using System.Text;

namespace oop_7_20._8._18
{
    abstract class Shape
    {
        protected double area;
        public double Area
        {
            get
            {
                return area;
            }
        }
        public abstract void calcarea();
    }
}
