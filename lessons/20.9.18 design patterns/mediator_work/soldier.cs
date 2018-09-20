using System;
using System.Collections.Generic;
using System.Text;

namespace mediator_work
{
    class soldier:IfightAbility
    {
        private string name;
        private teamComm rad;
        public soldier(teamComm t, string n)
        {
            rad = t;
            name = n;
            rad.add(this);//dependency injection
        }
        public void send(string msg)
        {
            Console.WriteLine($"{name} sent: {msg}");
            rad.publish(this, msg);
        }
        public void receive(string msg)
        {
            Console.WriteLine($"{name} got text: {msg}");
        }

        public void attack()
        {
            rad.teamfight();
        }
        public void shoot()
        {
            Console.WriteLine(name+"'s gun: pew pew pew!");
        }
    }
}
