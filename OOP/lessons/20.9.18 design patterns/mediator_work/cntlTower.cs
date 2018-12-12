using System;
using System.Collections.Generic;
using System.Text;

namespace mediator_work
{
    class cntlTower
    {
        private List<airCraft> planes;
        public cntlTower()
        {
            planes = new List<airCraft>();
        }
        public void register(airCraft plane)
        {
            planes.Add(plane);//adds new plane
        }
        public void publish(airCraft sender,string msg)
        {
            foreach(airCraft a in planes)
            {
               if(a!=sender) a.receive(msg);
            }
        }
    }
}
