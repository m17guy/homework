using System;

namespace exersize
{
    class Program
    {
        static void Main(string[] args)
        {
            makingchars(2);
            Console.ReadKey();
        }
        static void makingchars(int num)
        {
            character[] list = new character[num];
            for (int i = 0; i < num; i++)
            {
                Console.WriteLine("would you like to make a hero?");
                switch (Console.ReadLine().ToLower())
                {
                    case "yes":
                    case "y":
                        Console.WriteLine("whats his name?");
                        list[i] = new hero(Console.ReadLine());
                        break;
                    case "no":
                    case "n":
                        Console.WriteLine("whats his name?");
                        list[i] = new villan(Console.ReadLine());
                        break;
                }
            }
            foreach (character c in list)
            {
                Console.WriteLine(c.Name);
                c.dostuff();
            }
        }
    }
}
