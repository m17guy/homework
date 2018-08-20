using System;
using System.Collections.Generic;
using System.Text;

namespace oop_7_20._8._18
{
    class square:Shape
    {
        private double size;
        public square(double size)
        {
            this.size = size;
        }
        public override void calcarea()
        {
            area = size * size;
        }
    }
}
