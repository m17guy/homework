using System;
using System.Collections.Generic;
using System.Text;

namespace mediator_work
{
    class teamComm
    {
        private HashSet<soldier> gronot = new HashSet<soldier>();
        public void add(soldier s)
        {
            gronot.Add(s);
        }
        public void publish(soldier sender, string msg)
        {
            foreach (soldier s in gronot)
            {
                if (s != sender) s.receive(msg);
            }
            Console.WriteLine();
        }
        public void teamfight()
        {
            foreach(soldier s in gronot) { s.shoot();}
        }
    }
}
