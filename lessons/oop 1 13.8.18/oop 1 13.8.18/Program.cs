using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_1_13._8._18
{
    class Program
    {
        static void Main(string[] args)
        {
            Circle c = new Circle(10);
            c.calcarea();
            Triangle t = new Triangle(2, 4);
            t.calcarea();
            Console.WriteLine(t.getarea());
            Shape[] shape = 
            {// you can creat new instinses of the arrey in it
                new Circle(3),
                new Triangle(2.5, 5),
                c
            };
            for (int i = 0;i<shape.Length;i++)
            {
                shape[i].calcarea(); //could NOT work if base (Shape) didnt have calcarea()
                //old school:
                Console.WriteLine(shape[i].getarea());
                Console.WriteLine(shape[i].getperimeter());
                //the new and improved way:
                //(it really just looks like a var. witch in my opinion is great
                Console.WriteLine(shape[i].Area);
                Console.WriteLine(shape[i].Perimeter);

                //is
                if(shape[i] is Circle) // saved word "is"
                {
                    Console.WriteLine(i+ " is a circle");
                }
            }
        }
    }
}
