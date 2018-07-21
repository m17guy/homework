using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sort_tests
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 5, 2, -4, 3, 1, 9, 6 };
            if (arr.Min() > 0)
                arr = sort3(arr);
            else
                arr = sort2(arr);
            foreach(int i in arr)
                Console.WriteLine(i);
            Console.ReadKey();
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
        static int[] sort2(int[] tofix)
        {
            bool wrong = true;
            int count = 0;
            while (wrong)
            {
                wrong = false;
                for (int spot = 1; spot < tofix.Length - count; spot++)
                {
                    if (tofix[spot - 1] > tofix[spot])
                    {
                        tofix[spot] = tofix[spot - 1] + tofix[spot];
                        tofix[spot - 1] = tofix[spot] - tofix[spot - 1];
                        tofix[spot] = tofix[spot] - tofix[spot - 1];
                        wrong = true;
                    }
                }
                count++;
            }
            return tofix;
        }
        static int[] sort3(int[] get)
        {
            int[] witho = new int[get.Max()], give = new int[get.Length];
            foreach (int i in get)
            {
                int lok = i - 1;
                witho[lok] = i;
            }
            int count = 0;
            foreach (int i in witho)
            {
                if (i != 0)
                {
                    give[count] = i;
                    count++;
                }
            }
            return give;
        }
    }
}
