using System;

namespace singelton_deck
{
    class Program
    {
        static void Main(string[] args)
        {
            deck d = deck.Deck1;
            d.addCard("arina");
            d.addCard("lambermill");
            Console.WriteLine(d.Cards.Count);
            Console.ReadKey();
        }
    }
}
