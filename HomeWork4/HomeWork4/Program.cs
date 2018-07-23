using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork4
{
    class Program
    {
        static void Main(string[] args)
        {
            int q1 = 123321;
            Console.WriteLine(mirrornum(q1));
            string q2 = "ge rr eg";
            Console.WriteLine(mirrorstring(q2));
            int[] arr = { 4, -30, 2, 9, 7 }, arr2 = { 2, 3, 1, 5};
            foreach (int i in arr)
                Console.Write(i+",");
            Console.WriteLine();
            arr = cumbine(arr, arr2);
            //arr = sort1(arr);
            foreach (int i in arr)
                Console.Write(i + ",");
            Console.WriteLine();
            Console.WriteLine(MisNumArr(arr2));

            Console.ReadKey();
        }
        static bool mirrornum(int test)
        {
            //a great exampel from class
            int right = 10, left = 100000;
            for(int i=0;i<3;i++)
            {
                if(test% right!=(test/left)%10)
                {
                    return false;
                }
                test /= 10;
                left /= 100;
            }
            return true;

            //or ******************

            if (test < 0)
                test *= -1;
            bool ans=true;
            string num = Convert.ToString(test);
            if (num.Length % 2 != 0)
                ans = false;
            for(int i=0;i<num.Length/2;i++)
            {
               if( num[i]!=num[num.Length-1-i])
                {
                    ans = false;
                    break;
                }
            }
            return ans;
        }
        static bool mirrorstring(string test)
        {
            if (test.Length % 2 != 0)
                return false;
            for (int i = 0; i < test.Length / 2; i++)
            {
                if (test[i] != test[test.Length - 1 - i])
                    return false;
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
        static int[] cumbine(int[] a, int[] b)
        {
            int[] c = new int[a.Length + b.Length];
            for (int i = 0; i < a.Length; i++)
                c[i] = a[i];
            for (int i = 0; i < b.Length; i++)
                c[i + a.Length] = b[i];
            return c;
        }
        static int MisNumArr(int[] bad)
        {
            int[] good = new int[bad.Length+1];
            int missing=0;
            foreach (int i in bad)
            {
                int lok = i-1;
                good[lok] = i;
            }
            for (int i = 1; i < good.Length; i++)
            {
                if (good[i] == 0)
                {
                    missing = i+1;
                }
            }
            return missing;

        }
    }
}
