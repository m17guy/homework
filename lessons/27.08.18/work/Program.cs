using System;
using System.Collections;
using System.Collections.Generic;

namespace work
{
    class Program
    {
        static void Main(string[] args)
        {
            printnum("three");
            printfirstchar("Badoba");
            Console.ReadKey();
        }
        static List<t> convertToList<t>(t[] arr)
        {
            return new List<t>(arr);
        }
        static void printnum(string num)
        {
            int count = 1;
            Dictionary<string, int> dic = new Dictionary<string, int>
            {
                {"one",count++},
                {"two",count++},
                {"three",count++},
                {"four",count++},
                {"five",count++},
                {"six",count++},
                {"seven",count++},
                {"eight",count++},
                {"nine",count++},
                {"ten",count++}
            };
            dic["zero"] = 0;
            Console.WriteLine(dic[num.ToLower()]);
        }
        static void printfirstchar(string a)
        {
            a=a.ToLower();
            HashSet<char> b = new HashSet<char>();
            for(int i=0;i<a.Length;i++)
            {
                if (b.Contains(a[i]))
                {
                    Console.WriteLine(a[i]);
                    break;
                }
                b.Add(a[i]);
            }
        }
        static bool login(string username, string password)
        {
            Dictionary<string, string> users = new Dictionary<string, string>();
            users["Bubu"] = "123";
            users["Bubu"] = "123";
            users["Bubu"] = "123";

            //if(users.ContainsKey(username))
            //{
            //    return users[username] == password;
            //}
            //return false;
            return users.ContainsKey(username) && users[username] == password;
        }
    }
}
