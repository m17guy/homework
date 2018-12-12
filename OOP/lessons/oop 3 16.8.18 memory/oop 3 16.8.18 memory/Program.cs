using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_3_16._8._18_memory
{
    class Program
    {
        static void Main(string[] args)
        {
            //killmemory();
            //killstack(1);
            int i = 5;
            Inc(i);//pass by copy
            Console.WriteLine(i);
            bubo a = new bubo();
            a.name = "the king";
            Console.WriteLine(a.name);
            clearname(a);
            Console.WriteLine(a.name);
            
        }
        static void killmemory()
        {
            string s = "*";
            while(true)
            {
                s += s;
            }
        }
        static void killstack(int count)
        {
            Console.WriteLine(count);
            killstack(count + 1);
        }
        static void Inc(int num)
        {
            num++;
        }
        static void clearname(bubo b)
        {
            b.name = "no name";
        }
    }
    class bubo
    {
        public string name;
    }
}
