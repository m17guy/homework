using System;
using System.Collections.Generic;
using System.Text;

namespace strategy_work
{
    class Fan
    {
        private IPhrase phrase=new stanph();
        public void setPhrase(IPhrase ph)
        {
            phrase = ph;
        }
        public void Quate()
        {
            phrase.say();
        }
    }
}
