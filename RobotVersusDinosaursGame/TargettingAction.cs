using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotVersusDinosaursGame
{
    class TargettingAction : Action
    {
        protected ActionDescription actionType;
        protected Tuple<Status, int> selfStatus;
        protected Tuple<Status, int> otherStatus;
        protected List<Condition> selfConditions;
        protected List<Condition> otherConditions;

        public TargettingAction(Combatant combatant, int speed, ActionDescription actionType, int value,
            List<Condition> selfConditions, List<Condition> otherConditions,
            Status selfStatus, int selfValue, Status otherStatus, int otherValue) : base(combatant)
        {
            this.speed = speed;
            this.actionType = actionType;
            this.selfConditions = selfConditions;
            this.otherConditions = otherConditions;
            this.selfStatus = new Tuple<Status, int>(selfStatus, selfValue);
            this.otherStatus = new Tuple<Status, int>(otherStatus, otherValue);
        }

        public List<Condition> GetSelfConditions()
        {
            return selfConditions;
        }
        public List<Condition> GetOtherConditions()
        {
            return otherConditions;
        }
        public Tuple<Status, int> SelfStatusPair()
        {
            return selfStatus;
        }

        public Tuple<Status, int> OtherStatusPair()
        {
            return otherStatus;
        }
    }
}
