using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cards
{
    class Program
    {
        static void Main(string[] args)
        {

            int club = 1,spade=1, diamond=1, heart=1;
            Card[] deck =
                {
                new Card("club", club++),
                new Card("club", club++),
                new Card("club", club++),
                new Card("club", club++),
                new Card("club", club++),
                new Card("club", club++),
                new Card("club", club++),
                new Card("club", club++),
                new Card("club", club++),
                new Card("club", club++),
                new Card("club", club++),
                new Card("club", club++),
                new Card("club", club++),
                new Card("spade",spade ++),
                new Card("spade", spade++),
                new Card("spade", spade++),
                new Card("spade", spade++),
                new Card("spade", spade++),
                new Card("spade", spade++),
                new Card("spade", spade++),
                new Card("spade", spade++),
                new Card("spade", spade++),
                new Card("spade", spade++),
                new Card("spade", spade++),
                new Card("spade", spade++),
                new Card("spade", spade++),
            new Card("diamond", diamond++),
            new Card("diamond", diamond++),
            new Card("diamond", diamond++),
            new Card("diamond", diamond++),
            new Card("diamond", diamond++),
            new Card("diamond", diamond++),
            new Card("diamond", diamond++),
            new Card("diamond", diamond++),
            new Card("diamond", diamond++),
            new Card("diamond", diamond++),
            new Card("diamond", diamond++),
            new Card("diamond", diamond++),
            new Card("diamond", diamond++),
            new Card("heart", heart++),
            new Card("heart", heart++),
            new Card("heart", heart++),
            new Card("heart", heart++),
            new Card("heart", heart++),
            new Card("heart", heart++),
            new Card("heart", heart++),
            new Card("heart", heart++),
            new Card("heart", heart++),
            new Card("heart", heart++),
            new Card("heart", heart++),
            new Card("heart", heart++),
            new Card("heart", heart++)
            };
            Console.WriteLine(deck.Length + " pick up");
            foreach(Card i in deck)
            {
                Console.WriteLine(i.name);
            }
            Console.ReadKey();
        }
        static Card[] shafel(Card[] a)
        {
            int[] used = new int[52];
            Random ran = new Random();

            return a;
        }
    }
}
