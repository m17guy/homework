using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_1_13._8._18
{
    class Triangle:Shape
    {
        private double width, height;
        public Triangle(double width, double height)
        {
            this.width = width;
            this.height = height;
        }
        public override void calcarea()
        {
            base.calcarea();
            //area is field from base class
            area = this.width * this.height / 2;
        }
    }
}
