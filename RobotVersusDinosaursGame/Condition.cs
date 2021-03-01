using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotVersusDinosaursGame
{
    enum ConditionType{
        StaminaAboveValue,
        EnergyAboveValue,
        TargetAbnormalStatus,
        BatteryCharges,
        BallisticAmmo,
        FuelCell,

        // For passives
        Always,
        OnAttack,
        OnDefense
    }
    class Condition
    {
        private Tuple<ConditionType, int> condition;
        private int value;

        public Condition(ConditionType conditionType, int value)
        {
            this.condition = new Tuple<ConditionType, int>(conditionType, value);
        }

        public Tuple<ConditionType, int> GetValue()
        {
            return condition;
        }
    }
}
