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
            int[] arr = { 5, -1, 4, -3, 3, 1, 9, 6, -4, 0};
            arr = sort33(arr);
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
            int[] withoneg = new int[get.Min() * -1];
            int[] witho = new int[get.Max()], give = new int[get.Length];
            foreach (int i in get)
            {
                if (i > 0)
                {
                    int lok = i - 1;
                    witho[lok] = i;
                }
                if(i<0)
                {
                    int lok = (i * -1) - 1;
                    withoneg[withoneg.Length - 1 - lok] = i * -1;
                }
            }
            int count = 0;
            foreach (int i in withoneg)
            {
                if (i != 0)
                {
                    give[count] = i * -1;
                    count++;
                }
            }
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
        static int[] sort33(int[] get)
            //trying a list
        {
            bool zero = false;
            int[] withoneg = new int[get.Min() * -1];
            int[] witho = new int[get.Max()];
            foreach (int i in get)
            {
                if (i > 0)
                {
                    int lok = i - 1;
                    witho[lok] = i;
                }
                if (i < 0)
                {
                    int lok = (i * -1) - 1;
                    withoneg[withoneg.Length - 1 - lok] = i * -1;
                }
                if (i == 0)
                    zero = true;
            }
            int count = 0;
            if (zero)
            {
                int[] give = new int[get.Length+1];
                foreach (int i in withoneg)
                {
                    if (i != 0)
                    {
                        give[count] = i * -1;
                        count++;
                    }
                }
                if (zero)
                {
                    give[count] = 0;
                    count++;
                }
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
            else
            {
                int[] give = new int[get.Length];
                foreach (int i in withoneg)
                {
                    if (i != 0)
                    {
                        give[count] = i * -1;
                        count++;
                    }
                }
                if (zero)
                {
                    give[count] = 0;
                    count++;
                }
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
}
