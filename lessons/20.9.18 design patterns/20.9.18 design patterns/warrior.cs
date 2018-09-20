using System;
using System.Collections.Generic;
using System.Text;


namespace _20._9._18_design_patterns
{
    class warrior
    {
        private IfightAbility ability;
        public warrior()
        {
            setability("bOx");
        }
        public void setability(string ability)
        {
            this.ability = fightAbilityFactory.createAbility(ability);
        }
        public void attack()
        {
            ability.engage();
        }
        
    }
}
