using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._7._18
{
    class Program
    {
        static void max(int[] testarr)
        {
            int max = testarr[0];
            for(int i=1;i< testarr.Length;i++)
            {
                if (max < testarr[i])
                    max = testarr[i];
            }
            Console.WriteLine(max);
        }

        static void min(int[] testarr)
        {
            int min = testarr[0];
            for (int i = 1; i < testarr.Length; i++)
            {
                if (min > testarr[i])
                    min = testarr[i];
            }
            Console.WriteLine(min);
        }
        
        static void trinum(int inx)
        {
            for(int a=1;a<=inx;a++)
            {
                Console.WriteLine(a*(a + 1) / 2);
            }

            //or
            //the arrey is just for fun
            int[] trinumnum = new int[inx];
            //
            int count=0;
            for (int a = 1; a <= inx; a++)
            {
                count += a;
                Console.WriteLine(count);
                trinumnum[a-1]=count;
            }
            foreach(int a in trinumnum)
                Console.WriteLine(a);
        }
        static void Main(string[] args)
        {
            int[] gm= { 3, 9, 14, 7 };
            max(gm);
            min(gm);
            trinum(4);
            Console.ReadLine();

        }
    }
}
