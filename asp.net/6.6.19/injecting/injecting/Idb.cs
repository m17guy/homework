using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace injecting
{
    public interface Idb
    {
        void addscore(string s);
        List<string> getscore();
    }
}
