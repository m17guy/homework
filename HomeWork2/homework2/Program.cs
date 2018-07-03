using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework2
{
    class Program
    {
        static void Main(string[] args)
        {
            Fingjoke(3, 5);
            hw2(1);
            Console.WriteLine(hw3(10));
            Console.WriteLine(hw4(-3));
            hwS(1);
            hw6(5);
            Console.ReadLine();
        }
        static void Fingjoke(int a,int b)
        {
            if(a>b)
                Console.WriteLine(a);
            else
                Console.WriteLine(b);
        }

        static void hw2(int fibopl)
        {
            int small = 0, big = 1;
            for (int i = 1; i < fibopl; i++)
            {
                big += small;
                small = big - small;
            }
                Console.WriteLine(small);
        }

        static int hw3(int Tpoint)
        {
            return (Tpoint * (Tpoint + 1) / 2);
        }

        static int hw4(int neg)
        {
            if (neg < 0)
                neg *= -1;
            return neg;
        }

        static void hwS(int side)
        {
            bool inside = true;
            for (int i = 1; i < 3; i++)
            {
                for (int a = 1; a <= side; a++)
                {
                    if (i <= 1 || side > 1)
                        Console.Write("*");
                }
                Console.WriteLine();
                if (inside == true)
                {
                    for (int c = 1; c <= side - 2; c++)
                    {
                        Console.Write("*");
                        for (int b = 1; b <= side - 2; b++)
                        {
                            Console.Write(" ");
                        }
                        Console.WriteLine("*");
                    }
                }
                inside = false;
            }
        }

        static void hw6(int hight)
        {
            for (int i = 0; i <= hight; i++)
            {
                for (int line = 0; line < i; line++)
                {
                    Console.Write(" ");
                }
                for (int line = hight; line > i; line--)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
