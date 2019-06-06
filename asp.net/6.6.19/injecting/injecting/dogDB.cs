using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace injecting
{
    public class dogDB : Idog
    {
        List<dog> mydogs = new List<dog>();
        public void adddog(dog d)
        {
            mydogs.Add(d);
        }
        public List<dog> getdogs()
        {
            return mydogs;
        }
    }
}
