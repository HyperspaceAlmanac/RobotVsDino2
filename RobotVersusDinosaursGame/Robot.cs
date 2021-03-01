using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotVersusDinosaursGame
{
    class Robot : Combatant, IDisplayInformation
    {
        protected int armor;
        protected int energy;
        protected int fuelCell;
        protected int ballisticsAmmo;
        protected int batteryCharges;

        public Robot(SelfAction[] ownActions, TargettingAction[] targetActions, int health,
            int armor, int energy, int fuelCell, int ammo, int battery) : base(ownActions, targetActions, health)
        {
            this.armor = armor;
            this.energy = energy;
            this.fuelCell = fuelCell;
            ballisticsAmmo = ammo;
            batteryCharges = battery;
        }

        public int Armor
        {
            get;
        }

        public int Energy
        {
            get;
        }

        public int FuelCell
        {
            get;
        }
        public int BallisticAmmo
        {
            get;
        }
        public int BatteryCharge
        {
            get;
        }
    }
}
