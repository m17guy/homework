using System;
using System.Collections.Generic;
using System.Text;

namespace _12._11._18
{
    class dog : animal
    {

        public dog(string Mname, string Mnoise, string Meating) : base(Mname, Mnoise, Meating)
        {
        }
        public override void iseating()
        {
            base.iseating();
            Console.WriteLine("dont toch its food");
        }
        public override string ToString()
        {
            return "im a dog yu";
        }
    }
}
