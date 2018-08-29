using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork10_collection
{
    class Program
    {
        static void Main(string[] args)
        {
            newlist usernames = new newlist();
            usernames.add("guy");
            usernames.add("noy");
            usernames.add("");
            usernames.printall();
            usernames.add("ruven");
            Console.ReadKey();
        }
        static void login(string username, string passwork)
        {

        }
        
    }
}
