using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotVersusDinosaursGame
{
    class Dinosaur : Combatant, IDisplayInformation
    {
        protected int stamina;
        protected int offenseLuck;
        protected int defenseLuck;
        protected Random rand;

        public Dinosaur(SelfAction[] ownActions, TargettingAction[] targetActions, int health, int stamina,
            int offenseLuck, int defenseLuck) :
            base(ownActions, targetActions, health)
        {
            this.stamina = stamina;
            this.offenseLuck = offenseLuck;
            this.defenseLuck = defenseLuck;
            rand = new Random(99);
        }
    }
}
