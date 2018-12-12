using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6._8._18
{
    class Program
    {
        static void Main(string[] args)
        {
            //printarr(onetotenEasy());
            Console.WriteLine("input number of arrays you want:");
            int arrnum = int.Parse(Console.ReadLine());
            Console.WriteLine("input the bigest number:");
            int lastnum = int.Parse(Console.ReadLine());
            printarr(onetotenHard(arrnum, lastnum));
            
            Console.ReadKey();
        }
        static int[][] onetotenEasy()
        {
            return new int[][] { new int[] { 1, 2, 3 }, new int[] { 4, 5, 6 }, new int[] { 7, 8, 9, 10 } };
        }
        static int[][] onetotenHard(int arrnum, int lastnum)
        {
            int[][] a = new int[arrnum][];
            int size = lastnum / arrnum;
            int nums = 1;
            for(int i=0;i<arrnum-1;i++)
            {
                a[i] = new int[size];
                for(int j=0;j<size;j++)
                {
                    a[i][j] = nums++;
                }
            }
            a[arrnum - 1] = new int[size + (lastnum % arrnum)];
            for (int j = 0; j < size+(lastnum % arrnum); j++)
            {
                a[arrnum-1][j] = nums++;
            }
            return a;
        }
        static void printarr(int[][] a)
        {
            for(int i=0;i<a.Length;i++)
            {
                Console.WriteLine("array at location " + i);
                foreach (int b in a[i])
                {
                    Console.Write(b + ", ");
                    if(b<10)
                        Console.Write(" ");
                }
                Console.WriteLine();
            }
        }
    }
}
