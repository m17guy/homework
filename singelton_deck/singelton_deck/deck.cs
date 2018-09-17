using System;
using System.Collections.Generic;
using System.Text;

namespace singelton_deck
{
    class deck
    {
        private deck thedeck = new deck();
        private deck()
        { }
        private List<string> cards = new List<string>();
        public List<string> Cards
        {
            get => cards;
        }
        public deck Deck
        {
            get => thedeck;
        }
        public void addCard(string card)
        {
            cards.Add(card);
        }
    }
}
