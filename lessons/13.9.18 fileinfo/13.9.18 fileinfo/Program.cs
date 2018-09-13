using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace _13._9._18_fileinfo
{
    class Program
    {
        static void Main(string[] args)
        {/*
            //hw 1
            List<string> names = new List<string>();
            string name = Console.ReadLine();
            while(name.ToLower() !="done")
            {
                names.Add(name);
                name = Console.ReadLine();
            }
            FileStream namestream = new FileStream("names.txt", FileMode.Create);

            foreach(string n in names)
            {
                byte[] data = Encoding.ASCII.GetBytes(n + Environment.NewLine);// get raw data
                namestream.Write(data, 0, data.Length);
            }
            namestream.Close(); //cleanup
            //*/

            ex1();
            //ex2();
            ex3();
            Console.ReadKey();
        }
        static void ex1()
        {
            Console.WriteLine("file name:");
            string name = Console.ReadLine();
            FileStream file = new FileStream(name, FileMode.Create);
            file.Close();
            
        }
        static void ex2()
        {
            Console.WriteLine("what file:");
            string path = Console.ReadLine();
            /*
            FileStream file = new FileStream(path, FileMode.Open);
            StringBuilder sb = new StringBuilder();
            int asc = file.ReadByte();
            while (asc != -1)
            {
                sb.Append((char)asc);
                asc = file.ReadByte();
            }
            file.Close();// importent aperontly
            string[] names = sb.ToString().Split('\n');
            //*/
            string[] names2 = File.ReadAllText(path).Split('\n');
            string[] names2again = File.ReadAllLines(path);//same as names2
            foreach(string n in names2)
            {
                Console.WriteLine(n);
            }
            
        }
        static void ex3()
        {
            Console.WriteLine("file name:");
            string name = Console.ReadLine();
            File.Delete(name);
        }
    }
}
