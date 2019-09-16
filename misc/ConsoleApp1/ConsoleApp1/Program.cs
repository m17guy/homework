using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length != 0)
            {
                Console.WriteLine("ive sentence");
            }
            else
            {
                Console.WriteLine("give sentence");
            }
            string mystring = Console.ReadLine();
            Console.WriteLine("give number");
            string mynum=Console.ReadLine();
            if (mynum.ToLower() == "all")
            {
                mynum = mystring.Length.ToString();
            }
            for(int i = 0; i <= int.Parse(mynum); i++)
            {
                if (i<=mystring.Length)
                {
                    for (int ii = 0; ii < i; ii++)
                    {
                        Console.Write(mystring[ii]);
                    }
                    Console.WriteLine();
                }
            }

            Console.WriteLine();
            Console.WriteLine("to try again press g");
            if (Console.ReadKey().Key.ToString().ToLower()== "g")
            {
                Main(new string[1]);
            }
        }
    }
}
