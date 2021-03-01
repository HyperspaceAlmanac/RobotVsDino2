using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotVersusDinosaursGame
{
    enum ActionDescription{
        Heal,
        Attack,
        Defend,
        Utility,

        // For skill randomization
        BetterInitiative,
        WorseInitiative,
        MoreDamage,
        LessDmage,
        MoreResource,
        LessResource
    }

    enum Status
    {
        None,
        Damage,
        Stun,
        Blind,
        Enraged,
        Defensive,
        StaminaDamage,
        DestroyAmmo,
        DestroyFuelCell,
    }
    class Action
    {
        protected Combatant combatant;
        protected string name;
        protected string description;
        protected int speed;

        public Action(Combatant combatant)
        {
            this.combatant = combatant;
        }

        public string Name
        {
            get;
        }

        public string Description
        {
            get;
        }

        public int Speed
        {
            get;
        }
    }
}
