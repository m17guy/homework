using System;

namespace _12._11._18
{
    class Program
    {
        static void Main(string[] args)
        {/*
            int sum = 0;
            foreach(string s in args)
            {
                sum += int.Parse(s);
            }
            Console.WriteLine(sum);
            */
            fish shark = new fish("bob", "vrom", "ravinisly", 4, false);
            carp bob = new carp("blop", "slowly", 2, true);
            dog mo = new dog("mo", "bork bork", "fast");
            animal[] list = { new animal("lion", "roor", "with his mate"), shark, bob, mo };
            foreach(animal a in list)
            {
                a.iseating();
                a.makenois();
                Console.WriteLine(a.ToString());
            }



        }
    }
}
