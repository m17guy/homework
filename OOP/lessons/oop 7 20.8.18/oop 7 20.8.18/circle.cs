using System;
using System.Collections.Generic;
using System.Text;

namespace oop_7_20._8._18
{
    class circle : Shape
    {
        private double radius;
        public circle(double radius)
        {
            this.radius = radius;
        }
        public override void calcarea()
        {
            area = radius * radius * Math.PI;
        }
    }
}
