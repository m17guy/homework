using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_1_13._8._18
{
    class Circle:Shape
    {
        private double radius;
        public Circle(double radius)
        {
            this.radius = radius;
        }
        public override void calcperimeter()
        {
            perimeter = 2 * Math.PI * radius;
        }
        public override void calcarea()
        {
            area = radius * radius * Math.PI; //3.1415
        }
    }
}
