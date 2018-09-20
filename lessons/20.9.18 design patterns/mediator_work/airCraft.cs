using System;
using System.Collections.Generic;
using System.Text;

namespace mediator_work
{
    class airCraft
    {
        private cntlTower tower;
        private string name;
        public airCraft(cntlTower t, string n)
        {
            tower = t;
            name = n;
            tower.register(this);//dependency injection
        }
        public void send(string msg)
        {
            Console.WriteLine($"{name} sent: {msg}");
            tower.publish(this, msg);
        }
        public void receive(string msg)
        {
            Console.WriteLine($"{name} got text: {msg}");
        }
    }
}
