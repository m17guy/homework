using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork5
{
    class Program
    {
        static void Main(string[] args)
        { /*
            switchname(Console.ReadLine());
            Console.WriteLine("user name:");
            string username = Console.ReadLine();
            Console.WriteLine("password:");
            string password = Console.ReadLine();
            userswitch(username, password);
            long[] onezy = { 33, 77, 999 }, twozyz = { 123, 234, 345, 456, 567 };
            print2dl(twolongs(onezy, twozyz));
            Console.WriteLine();
            printjag2l(longer(onezy, twozyz));
            */
            qwikmafs(10, 3);
            string[] abc= { "guy", "noy", "momz" };
            printstring(abc);
            arrsize(5);
            gotostart(490, 555);
            Console.ReadKey();
        }
        static void switchname(string name)
        {
            switch (name)
            {
                case "groot":
                    Console.WriteLine("tree");
                    break;
                case "gamura":
                    Console.WriteLine("green chick");
                    break;
                case "starlord":
                    Console.WriteLine("cool guy");
                    break;
            }
        }
        static void userswitch(string username, string password)
        {
            switch (username+password)
            {
                case "m5guypassword12345":
                    Console.WriteLine("hello m5guy");
                    break;
                case "noyI<3guy":
                    Console.WriteLine("hello noy");
                    break;
                case "ruven the cook hunter696969":
                    Console.WriteLine("hello ruven the cook hunter");
                    break;
                default:
                    Console.WriteLine("error");
                    break;
            }
        }
        //part 1
        static long[,] twolongs(long[] one,long[] two)
        {
            int max;
            if (one.Length > two.Length)
                max = one.Length;
            else
                max = two.Length;
            long[,] longer = new long[2,max];
            for(int i=0;i<one.Length;i++)
            {
                longer[0, i] = one[i];
            }
            for (int i = 0; i < two.Length; i++)
            {
                longer[1, i] = two[i];
            }
            return longer;
        }
        //part 2
        static long[][] longer(long[] one, long[] two)
        {
            //better:
            //return new long[][] { one, two };

            long[][] a = new long[][] { one, two };
            return a;
        }
        //part 1
        static void print2dl(long[,] arr)
        {
            foreach(long i in arr)
                Console.WriteLine(i);
        }
        //part 2
        static void printjag2l(long[][] a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                foreach (long i2 in a[i])
                {
                    Console.WriteLine(i2);
                }
            }
        }

        //homework i was to lazy to do becouse it was to easy so im doing it now:
        static void qwikmafs(int a, int b)
        {
            Console.WriteLine($"{a}+{b} = {a + b}");
            Console.WriteLine($"{a}*{b} = {a * b}");
            Console.WriteLine($"{a}/{b} = {a / b} (+{a%b}/{b})");
        }
        static void printstring(string[] a)
        {
            foreach(string i in a)
            {
                Console.WriteLine(i);
            }
        }
        static int[] arrsize(int a)
        {
            int[] zx = new int[a];
            for (int i = 0; i < a; i++)
            {
                zx[i]= i + 1;
            }
            return zx;
        }
        static void gotostart(int a,int b)
        {
            for(int i=1;i<=100;i++)
            {
                if (i == a || i == b)
                    break;
                Console.WriteLine(i);
            }
        }
    }
}
