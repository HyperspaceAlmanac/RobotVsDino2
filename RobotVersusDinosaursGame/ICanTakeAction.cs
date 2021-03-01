using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotVersusDinosaursGame
{
    interface ICanTakeAction
    {
        void PickAction(PlayerInputStatus status, ICanTakeAction otherArmy);
        
        int ArmyPriorityValue();
    }
}
