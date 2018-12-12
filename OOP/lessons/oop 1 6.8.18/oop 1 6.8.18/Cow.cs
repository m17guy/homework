using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_1_6._8._18
{
    class Cow
    {
        
        public bool isalive=true;
        public string name;
        public string noise = "moo";
        static int count = 1;
        public Cow()    
        {
            name = $"{count}";
            count++;
        }
        public void makenoise()
        {
            if (isalive)
                Console.WriteLine(noise);
        }
        public string makemilk()
        {
            //************************************************************
            return isalive ? "milk" : null; //trenary operator
            /****************************************************************
            if (isalive)
                return "milk";
            return null;
            */
        }
        public void die()
        {
            isalive = false;
        }
    }
}
