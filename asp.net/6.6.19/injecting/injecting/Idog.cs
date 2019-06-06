using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace injecting
{
    public interface Idog
    {
        void adddog(dog d);
        List<dog> getdogs();
    }
}
