using System;
using System.Collections.Generic;
using System.Text;

namespace singelton_deck
{
    class deck
    {
        private static deck thedeck = new deck();
        private deck()
        { }
        private List<string> cards = new List<string>();
        public List<string> Cards
        {
            get => cards;
        }
        public static deck Deck1
        {
            get => thedeck;
        }
        public void addCard(string card)
        {
            cards.Add(card);
        }
    }
}
