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
        protected bool isActive;
        protected int cooldown;
        protected int duration;
        protected int current;
        protected Condition condition;
        protected Status status;
        protected ActionDescription actionDescription;
    }
}
