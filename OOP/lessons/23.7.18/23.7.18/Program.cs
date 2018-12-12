using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23._7._18
{
    class Program
    {
        static void Main(string[] args)
        {
            int Rbig = 99;
            bigsmall(Rbig);
            Console.ReadKey();
        }
        static void bigsmall(int limit)
        {
            bool newgame;
            do
            {
                int num = new Random().Next(1, limit + 1);
                int guess = int.Parse(Console.ReadLine());
                while (guess != num)
                {
                    if (guess > num)
                        Console.WriteLine("too big");
                    if (guess < num)
                        Console.WriteLine("too small");
                    guess = int.Parse(Console.ReadLine());
                }
                Console.WriteLine("you win");
                Console.WriteLine("new game?");
                if (Console.ReadLine() == "yes")
                    newgame = true;
                else
                    newgame = false;
            } while (newgame);
        }
    }
}
