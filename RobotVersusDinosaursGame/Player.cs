using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotVersusDinosaursGame
{
    abstract class Player
    {
        protected ICanTakeAction army;
        
        public Player(ICanTakeAction army)
        {
            this.army = army;
        }

        public ICanTakeAction Army
        {
            get;
        }
    }
}
