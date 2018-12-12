using System;

namespace strategy_work
{
    class Program
    {
        static void Main(string[] args)
        {
            Fan guy = new Fan();
            guy.Quate();
            guy.setPhrase(new ygritteph());
            guy.Quate();
            Console.ReadKey();
        }
    }
}
