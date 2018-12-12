using System;

namespace exersize_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //i should proboly add names, if i get around to it
            human ruven = new human();
            human guy = new human();
            ruven.sayhito(guy);
            guy.eat(new cow());
            Console.ReadKey();
        }
    }
}
