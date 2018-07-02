using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework1
{
    class Program
    {
        static void Main(string[] args)
        {
            //hwS();
            LU();
            //RU();
            //egapt();
            Console.ReadLine();
        }

        static void LU()
        {
            Console.WriteLine("hight?");
            int hight = int.Parse(Console.ReadLine());
            
            string a = " ";
            for (int b = 1; b <= hight; b++)
            {
                Console.WriteLine("*");
                Console.Write(a);
                a += " ";

            }
            
            //or
            //tride it in the lesson when cheking the HW
            
            char[] side = new char[hight];
            side[0] = ' ';
            for(int i=1;i<hight;i++)
            {
                side[i] = ' ';
            }
            for (int b = 1; b <= hight; b++)
            {
                Console.WriteLine('*');
                for (int c = 0; c < b; c++)
                    Console.Write(side[c]);
            }
            
        }

        static void RU()
        {
            Console.WriteLine("hight?");
            int hight = int.Parse(Console.ReadLine());
            for (int a = 0; a < hight; a++)
            {
                for (int i = hight - a; i > 1; i--)
                {
                    Console.Write(" ");
                }
                Console.Write("*");
                Console.WriteLine();
            }
        }

        static void egapt()
        {
            Console.WriteLine("hight?");
            int hight = int.Parse(Console.ReadLine());
            for (int i = 1; i <= hight; i++)
            {
                for (int line = hight; line > i; line--)
                {
                    Console.Write(" ");
                }
                for (int line = 0; line < i; line++)
                {
                    Console.Write("*");
                    if (line>=1)
                        Console.Write("*");
                }
                Console.WriteLine();
            }
        }

        static void hwS()
        {
            Console.WriteLine("[] size?");
            int side = int.Parse(Console.ReadLine());
            bool inside = true;
            for (int i = 1; i < 3; i++)
            {
                for (int a = 1; a <= side; a++)
                {
                    if (i<=1||side>1)
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
    }
}
