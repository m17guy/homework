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
            int[] arr = { 5, 4, 3, 3, 1, 9, 6 };
            if (arr.Min() > 0)
                arr = sort32(arr);
            else
                arr = sort12(arr);
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
        static int[] sort12(int[] tofix)
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
        static int[] sort32(int[] get)
        {
            int count = 0;
            int[] witho = new int[get.Max()+count], give = new int[get.Length];
            //int[] withoneg = new int[get.Min() * -1];
            foreach (int i in get)
            {
                int lok = i - 1;
                if (witho[lok] != 0)
                    count++;
                else
                    witho[lok] = i;
            }
            if (count > 0)
            {
                int[] newwitho = new int[witho.Length + count];
                count = 0;
                foreach (int i in get)
                {
                    int lok = i - 1;
                    if (newwitho[lok] != 0)
                    {
                        count++;
                        newwitho[lok + count] = i;
                    }
                    else
                        newwitho[lok] = i;
                }
                count = 0;
                foreach (int i in newwitho)
                {
                    if (i != 0) //the if to to get it the right size
                    {
                        give[count] = i;
                        count++;
                    }
                }
            }
            else
            {
                count = 0;
                foreach (int i in witho)
                {
                    if (i != 0)
                    {
                        give[count] = i;
                        count++;
                    }
                }
            }
            return give;
        }
    }
}
