using System;
using System.Collections.Generic;
using System.Text;

namespace _20._9._18_design_patterns
{
    class IONcannon : IfightAbility
    {
        private static IONcannon instance = new IONcannon();
        public static IONcannon GetIONcannon()
        {
            return instance;
        }
        private IONcannon() { } //private constractor
        public void engage()
        {
            Console.WriteLine("firing ion - cannon");
        }
    }
}
