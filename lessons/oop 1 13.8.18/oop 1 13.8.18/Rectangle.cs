using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_1_13._8._18
{
    class Rectangle:Shape
    {
        private double width;
        public double hight;
        public Rectangle(double width, double hight)
        {
            this.width = width;
            this.hight = hight;
        }
        public override void calcperimeter()
        {
            perimeter = 2*width+(2*hight);
        }
        public override void calcarea()
        {
            area = width * hight;
        }
    }
}
