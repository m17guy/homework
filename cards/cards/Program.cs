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
            Card[] BDeck = NewDeck();
            ADeck = ShafelTamar(ADeck);
            //Console.WriteLine(ADeck.Length + " pick up");
            foreach(Card i in ADeck)
            {
                Console.WriteLine(i.name);
            }
            Console.ReadKey();
        }
        static Card[] Shafel1(Card[] a)
        {
            string temp;
            Random rnd = new Random();
            int r, r2;
            for (int i=0;i<100;i++)
            {
                r = rnd.Next(0, 52);
                r2 = rnd.Next(0, 52);
                temp = a[r].name;
                a[r].name = a[r2].name;
                a[r2].name = temp;
            }

            return a;
        }
        static Card[] ShafelTamar(Card[] a)
        {
            Random num = new Random();
            for(int z = 0;z<a.Length;z++)
            {
                a[z].randomnumber = num.Next(1, 1000);
            }
            Array.Sort(a, delegate (Card a1, Card b2) { return a1.randomnumber.CompareTo(b2.randomnumber); });
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
