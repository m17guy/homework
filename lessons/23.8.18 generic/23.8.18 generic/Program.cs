using System;

namespace _23._8._18_generic
{
    class Program   //you can also make a generic class, just by putting <> next to the name (here)
        //but when you make a new instenc of it you NEED to decler its type
    {
        static void Main(string[] args)
        {
            Console.WriteLine(getter<int>(3));
            // you dont need the "<tipe>"  =>
            print("3");


            pair<int> a = new pair<int>("five", 5);
            Console.WriteLine(a.Key);
            Console.WriteLine(a.Value);
            a.Value = 8;
            Console.WriteLine(a.Value);
            Console.ReadKey();
        }
        static void print<t>(t data)
        {
            Console.WriteLine(data);
        }
        static t getter<t>(t data)
        {
            return data;
        }
    }
}
