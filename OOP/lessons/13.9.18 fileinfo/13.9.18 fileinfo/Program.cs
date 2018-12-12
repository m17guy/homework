using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace _13._9._18_fileinfo
{
    class LoginManager
    {
        private string path;

        public LoginManager(string path)
        {
            this.path = path;
        }

        public void AddUser(string userName)
        {
            FileStream stream = new FileStream(path, FileMode.OpenOrCreate);

            HashSet<string> uniqueNames = new HashSet<string>(ReadNames(stream));
            uniqueNames.Add(userName);

            StringBuilder sb = new StringBuilder();
            foreach (string n in uniqueNames) sb.Append(n + Environment.NewLine);

            WriteNames(stream, sb);
        }

        public void UpdateUser(string oldName, string newName)
        {
            FileStream stream = new FileStream(path, FileMode.OpenOrCreate);

            string[] names = ReadNames(stream);
            for (int i = 0; i < names.Length; i++)
            {
                if (names[i] == oldName)
                {
                    names[i] = newName; //change name
                    break;
                }
            }

            StringBuilder sb = new StringBuilder();
            foreach (string n in names) sb.Append(n + Environment.NewLine);

            WriteNames(stream, sb);
        }

        public void RemoveUser(string name)
        {
            FileStream stream = new FileStream(path, FileMode.OpenOrCreate);

            List<string> mNames = new List<string>(ReadNames(stream));

            for (int i = 0; i < mNames.Count; i++)
            {
                if (mNames[i] == name)
                {
                    mNames.RemoveAt(i);
                    break;
                }
            }

            StringBuilder sb = new StringBuilder();
            foreach (string n in mNames) sb.Append(n + Environment.NewLine);

            WriteNames(stream, sb);
        }

        private static void WriteNames(FileStream stream, StringBuilder sb)
        {
            stream.Position = 0; //write from beginning of file
            byte[] data = Encoding.ASCII.GetBytes(sb.ToString());
            stream.Write(data, 0, data.Length);

            stream.Close();
        }

        private string[] ReadNames(FileStream stream)
        {

            StringBuilder sb = new StringBuilder();
            int b;
            while ((b = stream.ReadByte()) != -1)
            {
                char c = (char)b;
                sb.Append(c);
            }

            return sb.ToString().Split(Environment.NewLine, StringSplitOptions.RemoveEmptyEntries);
        }
    }
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
        //hw 2
        public static void CountNames()
        {
            FileStream namesStream = new FileStream("names.txt", FileMode.Open);
            StringBuilder sb = new StringBuilder();
            int b = namesStream.ReadByte(); //read next byte
            while (b != -1)
            {
                sb.Append((char)b); //cast and append to string builder
                b = namesStream.ReadByte(); //read next byte
            }

            string[] names = sb.ToString().Split('\n');
            //*
            Console.WriteLine(sb);
            /*/
			foreach (string n in names) Console.WriteLine(n);
			//*/
            Console.WriteLine(names.Length);
        }
        static void ex1()
        {
            Console.WriteLine("file name:");
            FileStream file = new FileStream(Console.ReadLine(), FileMode.Create);
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
