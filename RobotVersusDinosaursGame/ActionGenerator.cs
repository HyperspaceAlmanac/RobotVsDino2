using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotVersusDinosaursGame
{
    class ActionGenerator
    {
        private Random rand;

        public ActionGenerator()
        {
            rand = new Random();
            // Populate tables

        }

        public SelfAction GenerateDinoSelfAction(CombatantClass specialty)
        {
        }
        public TargettingAction GenerateDinoTargettingAction(CombatantClass specialty)
        {
        }
        public SelfAction GenerateRobotSelfAction(CombatantClass specialty)
        {
        }
        public TargettingAction GenerateRobotTargettingAction(CombatantClass specialty)
        {
        }
        public Passive[] GenerateRobotPassives(CombatantClass specialty)
        {
        }
        public Passive[] GenerateDinoPassives(CombatantClass specialty)
        {
        }

    }
}
