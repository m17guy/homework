using System;
using System.Threading;

namespace threads
{
    class Program
    {
        static AutoResetEvent closedgate = new AutoResetEvent(false);
        static void Main(string[] args)
        {
            //printslow("guy is the best");

            //multythread(10);

            //new Thread(count).Start(new counter(1, 50, 1, 100));
            //new Thread(count).Start(new counter(150, 100, -1, 100));

            /*
            Thread f1 = new Thread(usethreads);
            f1.Start(new myprint { txt = "im first thread", times = 20, wiht = 100 });
            Thread f2 = new Thread(usethreads);
            f2.Start(new myprint { txt = "just to waste time", times = 30, wiht = 50 });
            usethreads(new myprint { txt = "i'll wait for you", times = 3, wiht = 20 });
            f2.Join();
            f1.Join();
            Console.WriteLine("done");
            */

            new Thread(germanhello).Start();
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("hi");
                Thread.Sleep(20);
            }
            closedgate.WaitOne();
            for (int i = 0; i < 7; i++)
            {
                Console.WriteLine("bye");
                Thread.Sleep(500);
            }
            Console.ReadLine();
        }
        static void germanhello()
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("goten morgen");
                Thread.Sleep(20);
            }
            closedgate.Set();
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("goten abend");
                Thread.Sleep(50);
            }

        }
        static void usethreads(object o)
        {
            myprint p = (myprint)o;
            for (int i = 0; i < p.times; i++)
            {
                Console.WriteLine(p.txt);
                Thread.Sleep(p.wiht);
            }

           
            
        }
        static void count(object o)
        {
            counter myC = (counter)o;
            while (myC.start != myC.fin)
            {
                Console.WriteLine(myC.start);
                myC.start += myC.step;
                Thread.Sleep(myC.sl);
            }
        }
        static void multythread(int num)
        {
            Thread[] mythreads = new Thread[num];
            for(int i =0;i<10;i++)
            {
                mythreads[i] = new Thread(countTen);
                mythreads[i].Start();
            }
        }
        static void countTen()
        {
            for(int i = 10; i >= 0; i--)
            {
                Console.WriteLine(i);
                Thread.Sleep(200);
            }
        }
        static void printslow(string s)
        {
            foreach(char c in s)
            {
                Console.Write(c);
                Thread.Sleep(1000);
            }
        }
    }
    class myprint
    {
        public string txt;
        public int times, wiht;
    }
    class counter
    {
        public int start, fin, step, sl;
        public counter(int s,int f, int st, int slep)
        {
            start = s;fin = f;step = st;sl = slep;
        }
       
    }
}
