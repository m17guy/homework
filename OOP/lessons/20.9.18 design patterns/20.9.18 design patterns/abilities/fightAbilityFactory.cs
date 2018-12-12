using System;
using System.Collections.Generic;
using System.Text;

namespace _20._9._18_design_patterns
{
    class fightAbilityFactory
    {
        public static IfightAbility createAbility(string name)
        {
            switch (name.ToLower())
            {
                case "box":
                case "punch":
                    return new Box();
                case "kick":
                    return new Kick();
                case "gun":
                case "shoot":
                    return new Gun();
                case "ioncannon":
                case "ion-cannon":
                    return IONcannon.GetIONcannon();
                default:
                    return new Box();
            }
        }
    }
}
