using System;
using System.Collections.Generic;
using System.Text;

namespace flyweight
{
    class imagefactory
    {
        private static Dictionary<string, image> dicpic = new Dictionary<string, image>();
        public static image GetImage(string p)
        {
            if (!dicpic.ContainsKey(p)) dicpic[p] = new image(p);
            return dicpic[p];
        }
    }
}
