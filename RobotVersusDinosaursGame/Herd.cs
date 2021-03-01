using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotVersusDinosaursGame
{
    class Herd: ICanTakeAction, ICanSelectUnits
    {
        protected int advantageValue;
        protected List<Dinosaur> dinosaurs;

        public int ArmyPriorityValue()
        {
            return advantageValue;
        }
    }
}
