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
            //ex2:
            string input = "", inAt, inSco;
            List<string> students = new List<string>();
            Dictionary<string, List<string>> atributs = new Dictionary<string, List<string>>();

            while (input != "1")
            {
                Console.WriteLine("1. stop\n2. add student\n3. add atribut to student\n4. add num val to atribut");
                input = Console.ReadLine();
                switch (input)
                {
                    case "1":
                        break;
                    case "2":
                        students.Add(input);
                        break;
                    case "3":
                        Console.WriteLine("student:");
                        input = Console.ReadLine();
                        Console.WriteLine("atribut:");
                        inAt = Console.ReadLine();
                        if (!atributs.ContainsKey(input))
                        {
                            atributs.Add(input, new List<string>());
                        }
                        atributs[input].Add(inAt);
                        break;
                    case "4":
                        Console.WriteLine("student:");
                        input = Console.ReadLine();
                        Console.WriteLine("atribut:");
                        inAt = Console.ReadLine();
                        Console.WriteLine("score:");
                        inSco = Console.ReadLine();
                        atributs[input][atributs[input].IndexOf(inAt)] += inSco;
                        break;
                }
            }
            input = "";
            while (input != "1")
            {
                Console.WriteLine("1. stop\n2. get student list\n3. get atribut of student\n4. get num val of atribut");
                input = Console.ReadLine();
                switch (input)
                {
                    case "1":
                        break;
                    case "2":
                        foreach(string s in students)
                        {
                            Console.WriteLine(s);
                        }
                        break;
                    case "3":
                        Console.WriteLine("student:");
                        input = Console.ReadLine();
                        Console.WriteLine("atribut:");
                        inAt = Console.ReadLine();
                        if (!atributs.ContainsKey(input))
                        {
                            atributs.Add(input, new List<string>());
                        }
                        atributs[input].Add(inAt);
                        break;
                    case "4":
                        Console.WriteLine("student:");
                        input = Console.ReadLine();
                        Console.WriteLine("atribut:");
                        inAt = Console.ReadLine();
                        Console.WriteLine("score:");
                        inSco = Console.ReadLine();
                        atributs[input][atributs[input].IndexOf(inAt)] += inSco;
                        break;
                }
            }
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
    }
}
