using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_3_9._8._18
{
    class animal
    {
        internal bool isalive = true;
        private string priv = "a";
        //both get and set, this lets you put modifires and limits on the value
        public void setpriv(string newval)
        {
            priv = newval;
        }
        public string getpriv()
        {
            return priv;
        }
    }
}
