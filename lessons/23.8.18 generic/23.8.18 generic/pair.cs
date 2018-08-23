using System;
using System.Collections.Generic;
using System.Text;

namespace _23._8._18_generic
{
    class pair<t>
    {
        private string key;
        private t value;
        public pair(string key, t value)
        {
            this.key = key;
            this.value = value;
        }
        public string Key
        {
            get { return key; }
            set
            {
                if (value != null && value.Length > 0)
                    Key = value;
            }
        }
        public t Value
        {
            get { return value; }
            set
            {
                this.value = value;
            }
        }
    }
}
