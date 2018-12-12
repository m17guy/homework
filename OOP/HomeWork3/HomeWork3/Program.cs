using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork3
{
    class Program
    {
        static void Main(string[] args)
        {
            KRmod(30);

            int[] testarr = { 3, 5, 9, -2 };
            testarr = BigAndSmall(testarr);
            for (int i = 0; i < testarr.Length; i++)
            {
                Console.Write(testarr[i]+",");
            }
            Console.WriteLine();

            int[] testarr2 = { 3, 5, 9, -2 };
            testarr2 = JustPlus(testarr2);
            for (int i = 0; i < testarr2.Length; i++)
            {
                Console.Write(testarr2[i] + ",");
            }
            Console.WriteLine();

            int[] testarr3 = { 3, 2965, 93, -700 };
            Console.WriteLine(BigesNum(testarr3));

            justwo(232524262);

            Console.WriteLine(mid(1,-7,-3));

            Console.WriteLine("hight?");
            int hight = int.Parse(Console.ReadLine());
            notW(hight);
            Console.ReadKey();
        }

        static void notW(int hight)
        {
            string ab = "";
            for (int a = 0; a < hight; a++)
            {
                for (int i = hight - a; i > 1; i--)
                {
                    Console.Write(" ");
                }
                Console.Write("*");
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
                ab += "  ";
            }
        }

        static void KRmod(int size)
        {
            for (int colom = 1; colom <= size; colom++)
            {
                Console.Write(colom + " ");
                if (colom < 10)
                    Console.Write(" ");
                for (int line = 2; line <= size; line++)
                {
                    int tipe = line * colom;
                    Console.Write(tipe);
                    if (tipe < 10)
                        Console.Write(" ");
                    if (tipe < 100)
                        Console.Write(" ");
                    if (tipe < 1000)
                        Console.Write(" ");
                }
                Console.WriteLine();
            }
        }

        static int[] BigAndSmall(int[] bad)
        {
            int max = int.MinValue, min = int.MaxValue;
            foreach (int i in bad)
            {
                if (i < min)
                    min = i;
                if (i > max)
                    max = i;
            }
            int[] twoends = { min, max };
            return twoends;

            //or
            //**********************************************
            int[] othere = { bad.Min(), bad.Max() };
            return othere;
        }

        static int BigesNum(int[] q)
        {
            string qs;
            int longest = 0;
            int win=0;
            foreach (int i in q)
            {
                qs= Convert.ToString(i);
                if (longest<qs.Length)
                {
                    longest = qs.Length;
                    win = i;
                }
            }
            return win;
        }

        static int[] JustPlus(int[] both)
        {
            int notneg = 0;
            for(int i=0;i<both.Length;i++)
            {
                if (both[i] > 0)
                    notneg++;
            }
            int[] plus = new int[notneg];
            int a = 0;
            for (int i = 0; i < both.Length; i++)
            {
                if (both[i] > 0)
                {
                    plus[a] = both[i];
                    a++;
                }
            }
            return plus;
        }

        static void justwo(int q)
        {
            string qs = Convert.ToString(q);
            int count = 0;
            foreach(char i in qs)
            {
                if (i == '2')
                    count++;
            }
            Console.WriteLine(count);
        }

        static int mid(int a, int b,int c)
        {
            if ((a < b && b < c) || (b < a && b > c))
                return b;
            if ((a < c && c < b) || (a > c && c >b))
                return c;
            return a;
        }
    }
}
