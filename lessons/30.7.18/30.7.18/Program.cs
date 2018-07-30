using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _30._7._18
{
    class Program
    {
        static void Main(string[] args)
        {
            //minigameWithcounter();
            Console.ReadKey();
        }
        static int count(int[] nums)
        {
            int score = 0;
            foreach (int i in nums)
            {
                if (i % 2 == 0)
                    score++;
                if (i < 0)
                    score--;
                if (i % 3 == 0)
                    continue;
                if (i % 7 == 0)
                    break;
                if (i > 11)
                    break;
            }
            return score;
        }
        static void minigameWithcounter()
            // i made this becouse the lesson was really boring
            // thats also why the "real" practis is so short
        {
            int count = 0;
            bool win = true;
            Random rnd = new Random();
            while (win)
            {
                int kills = 0;
                bool goon = true;
                Console.WriteLine("youre in");
                do
                {   
                    int mlv = rnd.Next(9);
                    goon = att(mlv);
                    if (goon && mlv != 0)
                        kills++;
                    // Console.WriteLine(kills);
                    // Console.ReadKey();
                } while (goon && kills < 10);
                if (goon)
                {
                    Console.WriteLine("you did it :)");
                    win = false;
                }
                count++;
            }
            Console.WriteLine(count);
        }

        static bool att(int lev)
        {
            bool alive = true;
                switch (lev)
                {
                    case (0):
                        {
                            Console.WriteLine("no monster here");
                            break;
                        }
                    case (1):
                    case (2):
                    case (3):
                    case (4):
                    case (5):
                    case (7):
                    case (8):
                    {
                        Console.WriteLine("you kill it");
                        break;

                    }
                    case (6):
                        {
                            Console.WriteLine("youre dead");
                            alive = false;
                            break;
                        }
                }
            return alive;
        }
    }
}
