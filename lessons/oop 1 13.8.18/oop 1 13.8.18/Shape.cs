using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_1_13._8._18
{
    class Shape
    {
        protected double area;
        protected double perimeter;
        public double getarea()
        {
            return area;
        }
        public double Area
        {
            get
            {
                return area;
            }
        }
        public double getperimeter()
        {
            return perimeter;
        }
        public double Perimeter
        {
            get
            {
                return perimeter;
            }
        }
        public virtual void calcarea()
        {
            area = 0;
        }
        public virtual void calcperimeter()
        {
            perimeter = 0;
        }
        protected string sillyname;
        public string Sillyname
        {
            get
            {
                return sillyname;
            }
            set
            {
                if (value != "")
                    sillyname = value;
                else Console.WriteLine("unexeptuble");
            }
        }
    }
}
