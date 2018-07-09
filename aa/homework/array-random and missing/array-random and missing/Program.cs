using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace array_random_and_missing
{
    class Program
    {
        static void Main(string[] args)
        {
                int[] testarr2 = { 6, 7, 1, 4, 17 };
                int[] answer = arrggg(testarr2);
                foreach (int i in answer)
                {
                    Console.Write(i + ",");
                }
                Console.WriteLine();
            Console.ReadLine();
        }

        static int[] arrggg(int[] bad)
        {
            int max = 0, min=0;
            foreach(int i in bad)
            {
                if (i < min)
                    min = i;
                if (i > max)
                    max = i;
            }
            int[] good = new int[max - min + 1];
            int[] missing= new int[good.Length - bad.Length - 1 ];
            foreach(int i in bad)
            {
                int lok=i-min;
                good[lok] = i;
            }
            int a = 0;
            for(int i=1;i<good.Length;i++)
            {
                if (good[i] == 0)
                {
                    missing[a] = min + i;
                    a++;
                }
            }
            return missing;

        }
    }
}
