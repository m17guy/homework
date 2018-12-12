using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16._7._18
{
    class Program
    {
        static void Main(string[] args)
        {/*
            noin(10);
            sum(123);
            anoddeven(1234);
            Console.WriteLine(NoOnes(231456));
            Console.WriteLine(firsts(19));
            */
            int[] tosort = { 9, -4, 3, 2, 10 };
            tosort = sort1(tosort);
            foreach(int i in tosort)
                Console.Write(i+",");
            Console.ReadKey();
        }

        static void noin(int hight)
        {
            for (int line = 0; line < hight; line++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
            for (int line = 1; line < hight; line++)
            {
                string inside = "";
                Console.Write("*");
                for (int i = hight - line; i > 2; i--)
                {
                    inside += " ";
                }
                if (line != hight - 1)
                {
                    Console.Write(inside + "*");
                }
                Console.WriteLine();
            }
        }
        static void sum(int big)
        {
            if (big < 0)
                big *= -1;
            string num = Convert.ToString(big);
            int summ=0;
            foreach(int i in num)
            {
                summ += i-48;
                //-48 becouse ints giving me its ascii
            }
            Console.WriteLine(summ);

            //or ********************************************************************
            //better wey->

            if (big < 0)
                big *= -1;
            int Sum = 0;
            while(0<big)
            {
                int win = big;
                big /= 10;
                Sum += win - (big*10);
            }
            Console.WriteLine(Sum);
            //**************************************************************************
        }
        static void anoddeven(int num)
        {
            if (num < 0)
                num *= -1;
            int count = 0;
            while(num>0)
            {
                if (num % 2 == 0)
                    count++;
                else
                    count--;
                num /= 10;
            }
            if(count>0)
                Console.WriteLine("even");
            if(count<0)
                Console.WriteLine("odd");
            if(count==0)
                Console.WriteLine("none");
        }
        static bool NoOnes(int num)
        {
            if (num < 0)
                num *= -1;
            while (num > 0)
            {
                int test = num;
                num /= 10;
                if (test - num * 10 == 1)
                    return false;
            }
            return true;
        }
        static bool firsts(int num)
        {
            for(int i=2;i<num;i++)
            {
                if(num%i==0)
                {
                    return false;
                }
                return true;
            }
            return true;
        }
        static int[] sort1(int[] tofix)
        {
            bool wrong = true;
            while (wrong)
            {
                wrong = false;
                for (int spot = 1; spot < tofix.Length; spot++)
                {
                    if (tofix[spot - 1] > tofix[spot])
                    {
                        tofix[spot] = tofix[spot - 1] + tofix[spot];
                        tofix[spot - 1] = tofix[spot] - tofix[spot - 1];
                        tofix[spot] = tofix[spot] - tofix[spot - 1];
                        wrong = true;
                    }
                }
            }
            return tofix;
        }
    }
}
