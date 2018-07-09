using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9._7._18
{
    class Program
    {
        static void Main(string[] args)
        {
            //kefelrib();
            Console.WriteLine("hight?");
            int hight = int.Parse(Console.ReadLine());
            v2(hight);
            v1(hight);
            x4(hight);
            x1(hight);
            Console.ReadLine();
        }
         static void kefelrib()
        {
            for (int colom = 1; colom <= 10; colom++)
            {
                Console.Write(colom + " ");
                if (colom != 10)
                    Console.Write(" ");
                for (int line = 2; line <= 10; line++)
                {
                    int tipe = line * colom;
                    Console.Write(tipe);
                    if (tipe < 10)
                        Console.Write(" ");
                    if (tipe < 100)
                        Console.Write(" ");
                }
                Console.WriteLine();
            }
        }
        static void v2(int hight)
        {
            string ab = "";
            for (int a = 0; a < hight; a++)
            {
                Console.Write(ab);
                Console.Write('*');
                for (int i = (hight - a)*2-1; i > 1; i--)
                {
                    Console.Write(' ');
                }
                Console.Write('*');
                Console.WriteLine();
                ab += " ";
            }
        }
        static void v1(int hight)
        {
            string ab = "";
            for (int a = 0; a < hight; a++)
            {
                Console.Write(ab);
                Console.Write('*');
                if (a < hight-1)
                {
                    for (int i = (hight - a) * 2 - 2; i > 1; i--)
                    {
                        Console.Write(' ');
                    }
                    Console.Write('*');
                }
                Console.WriteLine();
                ab += " ";
            }
        }
        static void x4(int mid)
        {
            string ab = "";
            for (int a = 0; a < mid; a++)
            {
                Console.Write(ab);
                Console.Write('*');
                for (int i = (mid - a) * 2 - 1; i > 1; i--)
                {
                    Console.Write(' ');
                }
                Console.Write('*');
                Console.WriteLine();
                ab += " ";
            }
            for (int a = mid-1; a > 0; a--)
            {
                ab = ab.Remove(a);
                Console.Write(ab);
                Console.Write('*');
                for (int i = 1; i < (mid - a) * 2-1; i++)
                {
                    Console.Write(' ');
                }
                Console.Write('*');
                Console.WriteLine();
            }
        }
        static void x1(int hight)
        {
            string ab = "";
            for (int a = 0; a < hight; a++)
            {
                Console.Write(ab);
                Console.Write('*');
                if (a < hight - 1)
                {
                    for (int i = (hight - a) * 2 - 2; i > 1; i--)
                    {
                        Console.Write(' ');
                    }
                    Console.Write('*');
                }
                Console.WriteLine();
                ab += " ";
            }
            for (int a =hight - 1; a > 0; a--)
            {
                ab = ab.Remove(a-1);
                Console.Write(ab);
                Console.Write('*');
                for (int i = 0; i < (hight - a) * 2 - 1; i++)
                {
                    Console.Write(' ');
                }
                Console.Write('*');
                Console.WriteLine();
            }
        }
        static void mid(int a, int b, int c)
        {
            
        }
    }
}
