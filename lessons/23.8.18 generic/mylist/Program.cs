using System;

namespace mylist
{
    class Program
    {
        static void Main(string[] args)
        {
            mylist<int> a = new mylist<int>();
            Console.WriteLine(a.Size);
            a.Add(40);
            a.Add(-19);
            a.Add(3);
            Console.WriteLine(a.Size);

        }
    }
}
