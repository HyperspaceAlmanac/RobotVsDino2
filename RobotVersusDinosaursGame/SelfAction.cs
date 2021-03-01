using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotVersusDinosaursGame
{
    class SelfAction : Action
    {
        protected ActionType actionType;
        protected Status actionStatus;
        protected int actionValue;

        public SelfAction(Combatant combatant) : base(combatant)
        {
        }

        public bool CanPerformAction()
        {
            return false;
        }

        public void PerformAction()
        {
        }
    }
}
