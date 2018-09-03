using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace work
{
    class FullName
    {
        private string fname="no", lname="name";
        public FullName(string first, string last)
        {
            setfn(first);
            setln(last);
            
        }
        public FullName(string fullname)
        {
            if (!fullname.Contains(' ')) throw new invalidCharsex("name must contain a space");
            string[] fn = fullname.Split(' ');
            setfn(fn[0]);
            setln(fn[1]);
            checkchuck();
        }
        public void setfn(string first)
        {
            lenthcheck(first);
            fname = first;
            checkchuck();
        }
        public void setln(string last)
        {
            lenthcheck(last);
            lname = last;
            checkchuck();
        }
        private void lenthcheck(string name)
        {
            if(name.Length>10)
            {
                throw new Lengthex("too long");
            }
        }
        private void checkchuck()
        {
            string fn = fname +  lname;
            if (fn.ToLower() == "chucknoris") throw new invalidCharsex("you are NOT HIM!");
        }
    }
}
