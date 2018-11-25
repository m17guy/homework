using System;
using System.Collections;
using System.Collections.Generic;

namespace _22._11._18
{
    class Program
    {
        static void Main(string[] args)
        {
            //ex1();
            ex2();
            
        }
        static void ex1()
        {
            Dictionary<string, List<string>> allmen = new Dictionary<string, List<string>>();
            string inputM, inputW;
            while (true)
            {
                Console.WriteLine("name of man");
                inputM = Console.ReadLine();
                if (inputM == "stop")
                {
                    break;
                }
                Console.WriteLine("name of women");
                inputW = Console.ReadLine();
                if (!allmen.ContainsKey(inputM))
                {
                    allmen.Add(inputM, new List<string>());
                    allmen[inputM].Add(inputW);
                }
                else
                {
                    allmen[inputM].Add(inputW);
                }
            }
            while (true)
            {
                Console.WriteLine("man:");
                inputM = Console.ReadLine();
                if (inputM == "stop")
                {
                    break;
                }
                if (allmen.ContainsKey(inputM))
                {
                    foreach (string w in allmen[inputM])
                    {
                        Console.WriteLine(w);
                    }
                }
                else
                {
                    Console.WriteLine("not found");
                }
            }
        }
        static void ex2()
        {
            string input = "", inAt, inSco;
            Dictionary<string, Dictionary<string, string>> atributs = new Dictionary<string, Dictionary<string, string>>();

            while (input != "1")
            {
                Console.WriteLine("1. stop\n2. add student\n3. add atribut to student\n4. add num val to atribut");
                input = Console.ReadLine();
                switch (input)
                {
                    case "1":
                        break;
                    case "2":
                        Console.WriteLine("student name:");
                        input = Console.ReadLine();
                        atributs.Add(input, new Dictionary<string, string>());
                        break;
                    case "3":
                        Console.WriteLine("student:");
                        input = Console.ReadLine();
                        if (!atributs.ContainsKey(input))
                        {
                            Console.WriteLine("no such student");
                            Console.ReadKey();
                            break;
                        }
                        Console.WriteLine("atribut name:");
                        inAt = Console.ReadLine();
                        if (atributs[input].ContainsKey(inAt))
                        {
                            break;
                        }
                        atributs[input].Add(inAt, null);
                        break;
                    case "4":
                        Console.WriteLine("student:");
                        input = Console.ReadLine();
                        if (!atributs.ContainsKey(input))
                        {
                            Console.WriteLine("no such student");
                            Console.ReadKey();
                            break;
                        }
                        Console.WriteLine("atribut:");
                        inAt = Console.ReadLine();
                        if (!atributs[input].ContainsKey(inAt))
                        {
                            Console.WriteLine("no such atribute");
                            Console.ReadKey();
                            break;
                        }
                        Console.WriteLine("score:");
                        inSco = Console.ReadLine();
                        atributs[input][inAt] +=" " + inSco;
                        break;
                }
                Console.Clear();
            }
            input = "";
            while (input != "1")
            {
                Console.WriteLine("1. stop\n2. get student list\n3. get atribut list of student\n4. get num val of atribut");
                input = Console.ReadLine();
                switch (input)
                {
                    case "1":
                        break;
                    case "2":
                        foreach (string s in atributs.Keys)
                        {
                            Console.WriteLine(s);
                        }
                        Console.ReadKey();
                        break;
                    case "3":
                        Console.WriteLine("student:");
                        input = Console.ReadLine();
                        if (!atributs.ContainsKey(input))
                        {
                            Console.WriteLine("no such student");
                            Console.ReadKey();
                            break;
                        }
                        foreach (string s in atributs[input].Keys)
                        {
                            Console.WriteLine(s);
                        }
                        Console.ReadKey();
                        break;
                    case "4":
                        Console.WriteLine("student:");
                        input = Console.ReadLine();
                        if (!atributs.ContainsKey(input))
                        {
                            Console.WriteLine("no such student");
                            Console.ReadKey();
                            break;
                        }
                        Console.WriteLine("atribut:");
                        inAt = Console.ReadLine();
                        if (!atributs[input].ContainsKey(inAt))
                        {
                            Console.WriteLine("no such atribute");
                            Console.ReadKey();
                            break;
                        }
                        foreach (string s in atributs[input].Values)
                        {
                            Console.Write(s);
                        }
                        Console.ReadKey();
                        break;
                }
                Console.Clear();
            }
        }
    }
}
