using System;

namespace p2
{
    class Program
    {
        static void Main(string[] args)
        {
            int avr = 0, counter = 0;
            string all="", num="";
            while (num != "stop")
            {
                num=getnum();
                all += num.ToLower()+".";
                if (num != "stop")
                {
                    avr += int.Parse(num);
                }
                counter++;
            }
            printall(all, avr / (counter - 1));
            Console.ReadLine();
        }

        static string getnum()
        {
            Console.WriteLine("enter num:");
            return Console.ReadLine();
        }
        static void printall(string it, int av)
        {
            for(int i = 0; it[i] != 's'; i++)
            {
                string corint = "";
                while(it[i] != '.')
                {
                    corint += it[i];
                    i++;
                }
                
                if (int.Parse(corint)>av)
                    Console.WriteLine(corint);

            }
        }
    }
}
