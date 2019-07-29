using System;
using System.Collections.Generic;

namespace singelton_printserver
{
    class Program
    {
        static void Main(string[] args)
        {
            printserver myserv = printserver.GetPrintserver();
            myserv.addprinter();
            myserv.addjob(new job("test11", 1));
            myserv.addjob(new job("test41", 4));
            myserv.addjob(new job("test12", 1));
            myserv.addjob(new job("test32", 3));
            myserv.addjob(new job("test21", 2));
            myserv.addjob(new job("test31", 3));
            myserv.addjob(new job("test75", 7));
            myserv.addjob(new job("test33", 3));
            myserv.addjob(new job("test34", 3));
            myserv.addjob(new job("test36", 3));
            myserv.deletealljobs();
            myserv.addjob(new job("test12", 1));
            myserv.addjob(new job("test32", 3));
            myserv.addjob(new job("test21", 2));
            myserv.printall();
            Console.ReadKey();
        }
    }
    class job
    {
        public string text;
        public int importens;
        public job(string t,int i)
        {
            text = t;
            if (i < 1 || i > 10)
            {
                importens = 10;
            }
            else
                importens = i;
        }
        public override string ToString()
        {
            return text;
        }
    }
    class printserver
    {
        private static printserver myserver = new printserver();
        private printserver()
        {
            myprinters = 0;
        }
        private int myprinters;
        private List<job> myjobs=new List<job>();
        public static printserver GetPrintserver()
        {
            return myserver;
        }
        public void addjob(job j)
        {
            myjobs.Add(j);
        }
        public void addprinter()
        {
            myprinters++;
        }
        public void deletealljobs()
        {
            myjobs = new List<job>();
            Console.WriteLine("all jobs deleted");
        }
        public void printall()
        {
            int counter = 0;
            for (int i = 1; i <= 10; i++)
            {
                List<job> temp = new List<job>();
                foreach (job j in myjobs)
                {
                    if (j.importens == i)
                    {
                        temp.Add(j);
                    }
                }
                foreach (job j in temp)
                {
                    if (counter == myprinters)
                    {
                        System.Threading.Thread.Sleep(1000);
                        counter = 0;
                    }
                    Console.WriteLine(j);
                    counter++;
                }
            }
            Console.WriteLine("done printing");
            myjobs = new List<job>();
        }
    }
}
