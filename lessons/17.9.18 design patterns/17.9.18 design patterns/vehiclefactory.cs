using System;
using System.Collections.Generic;
using System.Text;

namespace _17._9._18_design_patterns
{
    class vehiclefactory
    {
        public Idrivable createvehicle(string name)
        {
            switch(name.ToLower())
            {
                case "car":
                case "private":
                    return new car();
                case ("truck"):
                    return new truck();
                case ("bike"):
                case ("motor"):
                    return new bike();
                default:
                    return new car();
            }
        }
    }
}
