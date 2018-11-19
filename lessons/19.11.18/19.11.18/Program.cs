using System;
using System.Collections.Generic;

namespace _19._11._18
{
    class Program
    {
        static void Main(string[] args)
        {
            //q1();
            q2();
            Console.ReadLine();
        }
        static void q1()
        {

            ArrayList L1 = new ArrayList();
            ArrayList L2 = new ArrayList();
            string input = "";
            while (true)
            {
                Console.WriteLine("L1:");
                input = Console.ReadLine();
                if (input == "stop")
                {
                    break;
                }
                L1.Add(input);
                Console.WriteLine("L2:");
                L2.Add(Console.ReadLine());
            }
            Console.WriteLine("sentance to tranz:");
            input = Console.ReadLine();
            for (int i = 0; i < L1.Count; i++)
            {
                if (input.Contains(L1[i].ToString()))
                {
                    input = input.Replace(L1[i].ToString(), L2[i].ToString());
                }

            }
            Console.WriteLine(input);
        }
        static void q2() //boxing and unboxing
        {
            ArrayList nums = new ArrayList();
            string input = "";
            int avrage = 0, counter = 0;
            while (input != "s")
            {
                Console.WriteLine("num:");
                input = Console.ReadLine();
                if (input != "s")
                {
                    avrage += int.Parse(input);
                    nums.Add(int.Parse(input));
                }
            }
            if (counter > 0)
                avrage /= nums.Count;
            for (int i = 0; i < nums.Count; i++)
            {
                if ((int)nums[i] > avrage)
                    Console.WriteLine(nums[i]);
            }
        }
        static void q3()//queue
        {
            Queue<string> line = new Queue<string>();
            Console.WriteLine("name:");
            string name = Console.ReadLine();
            while (name != "stop")
            {
                line.Enqueue(name);
                Console.WriteLine("name:");
                 name = Console.ReadLine();
            }
            while (line.Count != 0)
            {
                Console.WriteLine(line.Dequeue());
            }
        }
    }
}
