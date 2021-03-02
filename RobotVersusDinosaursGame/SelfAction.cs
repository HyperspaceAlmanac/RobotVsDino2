using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotVersusDinosaursGame
{
    class SelfAction : Action
    {
        protected ActionDescription actionType;
        protected Status actionStatus;
        protected int actionValue;

        public SelfAction(Combatant combatant, int speed, ActionDescription actionType, Status actionStatus, int value, List<Condition> conditions) : base(combatant)
        {
            this.speed = speed;
            this.actionType = actionType;
            this.actionStatus = actionStatus;
            actionValue = value;
            this.conditions = conditions;
        }

        public List<Condition> GetConditions()
        {
            return conditions;
        }

        public ActionDescription ActionType
        {
            get;
        }

        public Status ActionStatus
        {
            get;
        }
    }
}
