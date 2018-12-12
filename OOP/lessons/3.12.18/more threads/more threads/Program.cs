using System;
using System.Threading;

namespace more_threads
{
    class Program
    {
        static object takingoutmoney = new object();
        static void Main(string[] args)
        {
            Console.Title = "guy"; //just for fun

            bankacount couple = new bankacount();
            Thread wife = new Thread(takemoney);
            wife.Start(couple);
            couple.withdroul(50);
            Console.WriteLine(couple.getbalance());



            Console.ReadLine();
        }
        static void takemoney(object o)
        {
            bankacount person = (bankacount)o;
            person.withdroul(50);
            Console.WriteLine(person.getbalance());
        }
    } 
    class bankacount
    {
        private int balance = 70;
        public void withdroul(int x)
        {
            lock (this)
            {
                if (balance > x)
                {
                    Console.WriteLine("you have taken " + x + "$ from your acount");
                    Thread.Sleep(2000);
                    balance -= x;
                }
                else
                {
                    Console.WriteLine("you dont have the founds for that");
                }
            }
        }
        public int getbalance()
        {
            return balance;
        }
        public override string ToString()
        {
            return base.ToString();
        }
    }
}
