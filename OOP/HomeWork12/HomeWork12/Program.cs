using System;

namespace HomeWork12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("test starts here");
            bankaccount guy = new bankaccount(50);
            guy.showbalance();
            Console.WriteLine("diposit here:");
            guy.diposet(int.Parse(Console.ReadLine()));
            guy.showbalance();
            Console.WriteLine("take enough for a lone");
            guy.takemoney(int.Parse(Console.ReadLine()));
            guy.showbalance();
            Console.WriteLine("now take even more");
            guy.takemoney(int.Parse(Console.ReadLine()));
            guy.showbalance();
            Console.WriteLine("now fix it");
            guy.diposet(int.Parse(Console.ReadLine()));
            guy.showbalance();
            Console.ReadLine();
        }
    }

    class bankaccount
    {
        int balance, lone = 0;
        public bankaccount(int diposet)
        {
            balance = diposet;
        }
        public int getbalance
        {
            get
            {
                return balance;
            }
        }
        public void showbalance()
        {
            Console.WriteLine("your balance is " + balance);
            if (lone < 0)
            {
                Console.WriteLine("with a lone of " + -lone + "$");
            }
        }
        public void takemoney(int x)
        {
            if (balance > x)
            {
                balance -= x;
                Console.WriteLine($"you took {x}$ out of your account");
            }
            else
            {
                if (balance + lone - x > -500)
                {
                    x -= balance;
                    balance = 0;
                    lone -= x;
                    Console.WriteLine($"to take this amount of money you have taken a lone of {x}$");
                }
                else
                {
                    Console.WriteLine("you can not take a lone this large");
                    Console.WriteLine("the amount you can corently take is at most "+(500+lone));
                }
            }
        }
        public void diposet(int dip)
        {
            lone += dip;
            if (lone > 0)
            {
                balance += lone;
                lone = 0;
            }
            Console.WriteLine($"your diposet of {dip} was seccesfull");
        }
    }
}
