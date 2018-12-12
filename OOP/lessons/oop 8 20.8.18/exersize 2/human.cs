using System;
using System.Collections.Generic;
using System.Text;

namespace exersize_2
{
    class human : creature, Ivegen, Ihunter
    {
        public void eat(plant p)
        {
            eat((creature)p);//to make it go to the right place insted of going back to start
        }

        public void eat(animal a)
        {
            eat((creature)a);//to make it go to the right place insted of going back to start
        }
        private void eat (creature c)
        {
            Console.WriteLine(Name + " is eating " + c.Name);
            c.die();
        }
        public void drink(string beverage)
        {
            Console.WriteLine(beverage == "beer" || beverage == "milk" || beverage == "water" ? Name + "is drinking the " + beverage : Name + " will not drink " + beverage); 
        }
        public void sayhito(human person)
        {
            Console.WriteLine(Name+" is saying hi to "+person.Name);
        }
    }
}
