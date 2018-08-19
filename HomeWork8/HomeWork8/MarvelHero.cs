using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork8
{
    class MarvelHero : Hero
    {
        private static int herocount = 0;
        private bool isantihero;
        private int numoffreiends;
        public MarvelHero()
        {
            herocount++;
        }
        public override void fight()
        {
            Console.WriteLine("Marvel");
            base.fight();
        }
        public static void printcount()
        {
            Console.WriteLine(herocount);
        }
    }
}
