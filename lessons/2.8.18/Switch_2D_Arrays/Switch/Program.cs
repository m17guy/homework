using System;

namespace Switch
{
    class Program
    {
        static void Main(string[] args)
        {
            //Switch();
            PrintDigit("NINE");
            Console.WriteLine();

            PrintAllDigits(new string[] { "One","TWO","three","three"});
        }

        static void Switch()
        {
            /*
             switch: control flow with multiple cases, which only one is executed or none

            Syntax:

            switch(value) 
            {
                case ##:
                    //statements
                    break;
                case ##:
                    //statements
                    break;
                case ##:
                    //statements
                    break;
                default:
                    //statements
            }
             */

            int x = 9;
            switch(x)
            {
                case 0:
                    Console.WriteLine("Zero");
                    break;
                case 1:
                    Console.WriteLine("One");
                    break;
                case 2:
                    Console.WriteLine("Two");
                    break;
                case 3:
                    Console.WriteLine("Three");
                    break;
                case 4:
                    Console.WriteLine("Four");
                    break;
                case 5:
                    Console.WriteLine("Five");
                    break;
                case 6:
                    Console.WriteLine("Six");
                    break;
                case 7:
                    Console.WriteLine("Seven");
                    break;
                case 8:
                    Console.WriteLine("Eight");
                    break;
                case 9:
                    Console.WriteLine("Nine");
                    break;
                default:
                    Console.WriteLine("not a digit");
                    break;
            }
        }

        //Exercises: write the following methods
        //1) static void PrintDigit(string num), print digit value by name (0-9).
        //2) static void PrintAllDigits(string[] nums), print all digit values by name (0-9).

        static void PrintDigit(string num)
        {
            switch (num.ToLower()) //check value of num in lower case, (ToUpper() in uppercase)
            {
                case "zero":
                    Console.Write(0);
                    break;
                case "one":
                    Console.Write(1);
                    break;
                case "two":
                    Console.Write(2);
                    break;
                case "three":
                    Console.Write(3);
                    break;
                case "four":
                    Console.Write(4);
                    break;
                case "five":
                    Console.Write(5);
                    break;
                case "six":
                    Console.Write(6);
                    break;
                case "seven":
                    Console.Write(7);
                    break;
                case "eight":
                    Console.Write(8);
                    break;
                case "nine":
                    Console.Write(9);
                    break;
                default:
                    Console.Write("Not a digit");
                    break;
            }
        }

        static void PrintAllDigits(string[] nums)
        {
            foreach(string n in nums)
            {
                PrintDigit(n);
            }
            Console.WriteLine();
        }


    }
}
