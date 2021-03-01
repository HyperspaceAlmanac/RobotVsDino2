using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotVersusDinosaursGame
{
    class TargettingAction : Action
    {

        public TargettingAction(Combatant combatant) : base (combatant)
        {
        }

        public bool CanPerformActionOn(Combatant target)
        {
            return false;
        }

        public void PerformAction(Combatant target)
        {
        }
    }
}
