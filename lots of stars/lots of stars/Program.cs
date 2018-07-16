using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lots_of_stars
{
    class Program
    {
        static void Q3(int mid)
        {
            for (int i = 1; i <= mid; i++)
            {
                for (int line = 0; line < i; line++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            for (int i = 1; i <= mid; i++)
            {
                for (int line = mid; line > i; line--)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            Console.ReadLine();
        }
        static void Q1(int reg)
        {
            for (int i = 1; i <= reg; i++)
            {
                for (int line = 0; line < i; line++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            //or
            Console.WriteLine();

            string a = "*";
            for (int i = 1; i <= reg; i++)
            {
                Console.WriteLine(a);
                a += "*";
            }
            Console.ReadLine();
        }
        static void Q15(int rev)
        {
            for (int a = 0; a < rev; a++)
            {
                for (int i = rev - a; i > 0; i--)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
        static void Q2(int mirror)
        {
            for (int i = 1; i <= mirror; i++)
            {
                for (int line = mirror; line > i; line--)
                {
                    Console.Write(" ");
                }
                for (int line = 0; line < i; line++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
        static void Q4()
        {
            Console.WriteLine("input number");
            int num = int.Parse(Console.ReadLine());
            for (int i = num - 1; i >= 0; i--)
            {
                Console.Write(num - i);
            }

            //or
            Console.WriteLine();

            for (int i = 1; i <= num; i++)
            {
                Console.Write(i);
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("input hight");
            int hight = Int32.Parse(Console.ReadLine());
            //Q1(hight);
            //Q15(hight);
            //Q2(hight);
            Q3(hight); 
            //Q4();


            Console.ReadLine();
        }
    }
}
