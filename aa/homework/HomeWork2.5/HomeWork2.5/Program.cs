using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork2._5
{
    class Program
    {
        static void Main(string[] args)
        {/*
            plus();
            int forcom = 10;
            int[] aar = { 4, 10, 25, 3, 15 };
            Console.WriteLine(Comper7Add(forcom, aar));
            Console.WriteLine( istri(21));
            Console.WriteLine(istri(1));
            Console.WriteLine(istri(7));
            avr(aar);
            */
            string a = "GuYg", b = "The guyogin";
            ComperNams(a, b);
            Console.ReadLine();
        }

        static void plus()
        {
            Console.WriteLine("hight?");
            int hight = int.Parse(Console.ReadLine());
            string mid = "";
            bool even = false;
            if (hight % 2 == 0)
            {
               // hight++;
                even = true;
            }
            for (int line=0;line<hight/2;line++)
            {
                for (int prog = 0; prog < hight/2; prog++)
                {
                    Console.Write(" ");
                }
                Console.WriteLine("*");
            }
            for (int prog = 1; prog <= hight; prog++)
            {
                mid += "*";
                if (even && hight / prog == 2)
                    mid += " ";
            }
            Console.Write(mid);
            Console.WriteLine();
            for (int line = 0; line < hight / 2; line++)
            {
                for (int prog = 0; prog < hight/2; prog++)
                {
                    Console.Write(" ");
                }
                Console.WriteLine("*");
            }
        }

        static int Comper7Add(int com,int[] list)
        {
            //int forcom = 10;
            //int[] aar = { 4, 10, 25, 3, 15 };
            int bigcom=0;
            foreach(int x in list)
            {
                if (x>com)
                {
                    Console.Write(x+",");
                    bigcom++;
                }
            }
            Console.WriteLine();
            return bigcom;
        }

        static bool istri(int tested)
        {
            //istri(21);
            //istri(1);
            //istri(7);
            for (int i=1; i * (i + 1) / 2<=tested; i++)
            {
                if (i * (i + 1) / 2 == tested)
                    return true;
            }
            return false;
        }

        static void avr(int[] nums)
        {
            double sum = 0;
            foreach(int i in nums)
            {
                sum += i;
            }
            Console.WriteLine(sum/nums.Length);
        }
        
        static void ComperNams(string na,string nb)
        {
            //string a = "GuYg", b = "The guyogin";
            int ta1=0, ta2=0, tb1=0, tb2=0,win = 0;
            for(int i= 0;i < na.Length;i++)
            {
                if (na[i] == 'g')
                    ta1++;
                if (na[i] > 64 && na[i] < 91)
                    ta2++;
 }
            for (int i = 0; i < nb.Length; i++)
            {
                if (nb[i] == 'g')
                    tb1++;
                if (nb[i] > 64 && nb[i] < 91)
                    tb2++;
            }
            if (na.Length > nb.Length)
                win++;
            else
            {
                if (na.Length < nb.Length)
                    win--;
            }
            if (ta1 > tb1)
                win++;
            else
            {
                if (ta1 < tb1)
                    win--;
            }
            if (ta2 > tb2)
                win++;
            else
            {
                if (ta2 < tb2)
                    win--;
            }
            if (win > 0)
                Console.WriteLine(na);
            else
            {
                if (win < 0)
                    Console.WriteLine(nb);
                else
                    Console.WriteLine("==");
            }
        }
    }
}
