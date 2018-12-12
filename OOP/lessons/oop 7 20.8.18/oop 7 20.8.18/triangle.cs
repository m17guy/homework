using System;
using System.Collections.Generic;
using System.Text;

namespace oop_7_20._8._18
{
    class triangle : Shape
    {
        private double width, hight;
        public triangle(double width, double hight)
        {
            this.width = width;
            this.hight = hight;
        }
        public override void calcarea()
        {
            area = width * hight / 2;
        }
    }
}
