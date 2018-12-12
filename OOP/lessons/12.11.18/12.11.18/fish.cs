using System;
using System.Collections.Generic;
using System.Text;

namespace _12._11._18
{
    class fish : animal
    {
        int gills;
        bool tasty;

        public fish(string Mname, string Mnoise, string Meating,int Mgills,bool Mtasty) : base(Mname, Mnoise, Meating)
        {
            gills = Mgills;
            tasty = Mtasty;
        }
        public override string ToString()
        {
            return "blob blob";
        }
    }
}
