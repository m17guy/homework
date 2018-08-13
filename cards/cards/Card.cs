using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cards
{
    class Card
    {
        public string suit;
        public string face;
        public string name;
        public string[] suitop = { "heart", "diamond", "club", "spade" };
        public string[] faceop = { "ace", "two", "three", "four", "five", "six", "seven",
        "eaght", "nine", "ten", "jack", "queen", "king" };
        public Card(string s, int f)
        {
            face = faceop[f - 1];
            switch(s)
            {
                case "heart":
                    suit = suitop[0];
                    break;
                case "diamond":
                    suit = suitop[1];
                    break;
                case "club":
                    suit = suitop[2];
                    break;
                case "spade":
                    suit = suitop[3];
                    break;
            }
            name = $"the {face} of {suit}";
        }
    
    }
}
