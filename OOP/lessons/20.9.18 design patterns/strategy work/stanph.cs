using System;
using System.Collections.Generic;
using System.Text;

namespace strategy_work
{
    class stanph : IPhrase
    {
        public void say()
        {
            Console.WriteLine("oh my god they killed kenny!");
        }
    }
}
