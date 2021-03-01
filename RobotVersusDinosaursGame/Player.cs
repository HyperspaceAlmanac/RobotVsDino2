using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotVersusDinosaursGame
{
    class Player : CanTakeAction
    {
        protected CanTakeAction army;
        
        public Player(CanTakeAction army)
        {
            this.army = army;
        }
    }
}
