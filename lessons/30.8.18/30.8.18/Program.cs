using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _30._8._18
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] data = { 'a', 'b', 'c' };
            string str = new string(data);
            Console.WriteLine(str);


            Console.WriteLine(string.Concat(str,"defg"));//similer to + " defg"
            Console.WriteLine(str.ToUpper());
            Console.WriteLine(str.ToLower());
            data = str.ToCharArray();//make an rray of chars from string
            string ext = ".txt";
            str = "      bubu  \n";
            Console.WriteLine(str.Trim() + ext);
            str = "ahatshtaim";
            Console.WriteLine(str.IndexOf('h'));//first index of substring
            Console.WriteLine(str.LastIndexOf('h'));//last index of substring
            Console.WriteLine(str.Substring(2,6));//cut substring that begins at index(2) INCLUSIVE and ends at index(8) EXCLUSIVE
            Console.WriteLine(str.Substring(5));//cut substring that begins at index(5) INCLUSIVE and ands with the sting itself
            Console.WriteLine("hello, guy is my name".Substring(4));// can also be used
            if (str.StartsWith("asdf")) Console.WriteLine("123");
            if (str.EndsWith("im")) Console.WriteLine("ends with im");
            str = "GUY";
            if (str.Equals("guy",StringComparison.CurrentCultureIgnoreCase)) Console.WriteLine("true1");//check if eqals without case sensitiv



            bool a = true;
            Console.WriteLine(a.ToString().ToString().ToString());



            string[] words = "Foo walks into a bar and says hellow  world".Split(' ');
            Console.WriteLine(words.Length);
            foreach(string s in words)
                Console.WriteLine(s);


            StringBuilder sb1 = new StringBuilder();
            sb1.Append(" c# is ");//adds to the end
            sb1.Insert(0, "good skill of ");
            sb1.Insert(14, "programing with ");
            Console.WriteLine(sb1);
            sb1.Remove(sb1.Length - 1, 1);
            Console.WriteLine(sb1);
            sb1.Remove(14, 17);
            Console.WriteLine(sb1);
            sb1.Append(" string munipulation");
            Console.WriteLine(sb1);

            StringBuilder df = new StringBuilder();
            df.Append("asdf");
            StringBuilder asdf = df;
            asdf.Clear();
            Console.WriteLine(df+"*");



            //test
            Console.WriteLine(SameIndex("kTt","LTYi"));


            Console.ReadKey();
        }
        static bool Checkpassword(string password)
        {
            return (password.Length > 7 && password.Contains(' '))
        }
        static bool SameIndex(string left,string right)
        {
            return (right.Contains('T') && left.Contains('T') && right.IndexOf('T') == left.IndexOf('T'));
        }
        static void startswithAr()
        {
            List<string> names = new List<string>();
            string now="";
            do
            {
                Console.WriteLine("add name:");
                now = Console.ReadLine();
                if(now.StartsWith("Ar"))
                //if(now[0]=='A'&&now[1]=='r')
                {
                    names.Add(now);
                }

            } while (now != "done");
            foreach(string a in names)
                Console.WriteLine(a);
        }
    }
    class guy //****************************************
    {
        string name = "Guy";
        int age = 22;
        public override string ToString()
        {
            return $"name-{name}, age: {age}";
        }
    }
}
