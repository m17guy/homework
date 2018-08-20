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
            Card[] ADeck = NewDeck();
            //Console.WriteLine(ADeck.Length + " pick up");
            foreach(Card i in ADeck)
            {
                Console.WriteLine(i.name);
            }
            Console.ReadKey();
        }
        static Card[] Shafel(Card[] a)
        {
            string tepm;
            int[] used = new int[52];
            Random rnd = new Random();
            for(int i=0;i<300;i++)
            {

            }

            return a;
        }
        static Card[] NewDeck()
        {
            int club = 1, spade = 1, diamond = 1, heart = 1;
            Card[] deck = new Card[52];
            for (int i = 0; i < 52; i++)
            {
                if (i < 13) deck[i] = new Card("club", club++);
                else if (i < 26) deck[i] = new Card("spade", spade++);
                else if (i < 39) deck[i] = new Card("diamond", diamond++);
                else deck[i] = new Card("heart", heart++);
            }

            return deck;
        }
    }
}
