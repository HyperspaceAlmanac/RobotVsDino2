using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotVersusDinosaursGame
{
    class Passive
    {
        protected string name;
        protected string description;
        protected int currentDuration;
        protected bool isActive;
        protected int duration;
        protected Condition[] conditions;
        protected Status status;
        protected int value;
        protected ActionDescription actionType;

        public Passive(string name, string description, int cooldown, int duration,
            Condition[] conditions, Status status, int value, ActionDescription actionType)
        {
            this.name = name;
            this.description = description;
            currentDuration = duration;
            this.conditions = new Condition[conditions.Length];
            for (int i = 0; i < conditions.Length; i++)
            {
                this.conditions[i] = conditions[i];
            }
            this.status = status;
            this.actionType = actionType;
            this.value = value;
        }

        public string Name
        {
            get;
        }
        public string Description
        {
            get;
        }
        public void TriggerPassive() {
            isActive = true;
            currentDuration = duration;
        }

        public void OneStep()
        {
            if (isActive)
            {
                if (currentDuration > 0)
                {
                    currentDuration -= 1;
                }
                else
                {
                    isActive = false;
                }
            }
        }

        public int CurrentDuration { get; }
        public bool IsActive { get; }
        public int Duration { get; }
        public Condition[] Conditions { get; }
        public Status Status { get; }
        public ActionDescription ActionType { get; }
        public int Value { get; }
    }
}
