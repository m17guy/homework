using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace injecting
{
    public class DB:Idb
    {
        List<string> score = new List<string>();

        public void addscore(string s)
        {
            score.Add(s);
        }

        public List<string> getscore()
        {
            return score;
        }
    }
}
