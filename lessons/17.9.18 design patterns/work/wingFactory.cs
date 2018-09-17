using System;
using System.Collections.Generic;
using System.Text;

namespace work
{
    class wingFactory
    {
        public static Ifliable factory(string name)
        {
            switch (name.ToLower())
            {
                case ("plane"):
                case ("the big one"):
                    return new plane();
                case ("helicopter"):
                case ("heli"):
                case ("the fast one"):
                    return new helicopter();
                case ("stealth"):
                case ("the cool one"):
                case ("its a secrit"):
                    return new stealth();
                default:
                    Console.WriteLine("you picked poorly");
                    return null;

            }
        }
    }
}
