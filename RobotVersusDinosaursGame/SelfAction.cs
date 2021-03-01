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
        protected List<Condition> conditions;

        public SelfAction(Combatant combatant, int speed, ActionType actionType, Status actionStatus, int value, List<Condition> conditions) : base(combatant)
        {
            this.speed = speed;
            this.actionType = actionType;
            this.actionStatus = actionStatus;
            actionValue = value;
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
