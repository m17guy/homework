using System;
using System.Collections.Generic;

namespace _8._11._18
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ligth of dic:");
            int dicL = int.Parse(Console.ReadLine());
            string[,] thedic = new string[2, dicL];
            for(int i = 0; i < dicL; i++)
            {
                Console.WriteLine("word in english:");
                thedic[0, i] = Console.ReadLine();
                Console.WriteLine("tranz:");
                thedic[1, i] = Console.ReadLine();
            }
            Console.WriteLine("what would you like to know?");
            string input = Console.ReadLine();
            while (input != "enough")
            {
                bool outt = false;
                for (int i = 0; i < dicL && !outt; i++)
                {
                    if (thedic[1, i] == input)
                    {
                        Console.WriteLine(thedic[0, i]);
                        outt = true;
                    }
                } 
                if(!outt)
                {
                    Console.WriteLine("i dont know");
                }
                Console.WriteLine("what would you like to know?");
                input = Console.ReadLine();
            }







            /* ex 1
            Console.WriteLine("enter a hexa num:");
            string num = Console.ReadLine();
            string bin = "";
            foreach(char c in num)
            {
                switch (c)
                {
                    case ('1'):
                        bin += "0001";
                        break;
                    case ('2'):
                        bin += "0010";
                        break;
                    case ('3'):
                        bin += "0011";
                        break;
                    case ('4'):
                        bin += "0100";
                        break;
                    case ('5'):
                        bin += "0101";
                        break;
                    case ('6'):
                        bin += "0110";
                        break;
                    case ('7'):
                        bin += "0111";
                        break;
                    case ('8'):
                        bin += "1000";
                        break;
                    case ('9'):
                        bin += "1001";
                        break;
                    case ('0'):
                        bin += "0000";
                        break;
                    case ('a'):
                        bin += "1010";
                        break;
                    case ('b'):
                        bin += "1011";
                        break;
                    case ('c'):
                        bin += "1100";
                        break;
                    case ('d'):
                        bin += "1101";
                        break;
                    case ('e'):
                        bin += "1110";
                        break;
                    case ('f'):
                        bin += "1111";
                        break;
                }
            }
            Console.WriteLine(bin);
            Console.ReadKey();
            */
        }
    }
}
