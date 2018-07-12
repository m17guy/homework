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
            KR20();

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

        static void KR20()
        {
            for (int colom = 1; colom <= 20; colom++)
            {
                Console.Write(colom + " ");
                if (colom < 10)
                    Console.Write(" ");
                for (int line = 2; line <= 20; line++)
                {
                    int tipe = line * colom;
                    Console.Write(tipe);
                    if (tipe < 10)
                        Console.Write(" ");
                    if (tipe < 100)
                        Console.Write(" ");
                    if (tipe < 400)
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

        static int BigesNum(int a, int b, int c)
        {
            string aas, bs, cs;
            aas = Convert.ToString(a);
            bs = Convert.ToString(b);
            cs = Convert.ToString(c);
            int longest = aas.Length;
            int win = a;
            if (longest < bs.Length)
            {
                longest = bs.Length;
                win = b;
            }
            if (longest < cs.Length)
            {
                win = c;
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
    }
}
