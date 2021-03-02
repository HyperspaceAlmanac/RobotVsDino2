using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotVersusDinosaursGame
{
    enum CombatantClass
    {
        Vanguard,
        Support,
        Healer,
        Assault
    }
    enum CombatantState
    {
        Waiting,
        ExecutingMove,
        Recovery
    }
    abstract class Combatant
    {
        // Actions that the class can do
        protected SelfAction[] selfActions;
        protected TargettingAction[] targettingActions;

        protected bool isIncapacitated;
        protected int health;
        protected int initiative;

        public Combatant(SelfAction[] ownActions, TargettingAction[] targetActions, int health)
        {
            selfActions = new SelfAction[ownActions.Length];
            for (int i = 0; i < ownActions.Length; i++)
            {
                selfActions[i] = ownActions[i];
            }
            targettingActions = new TargettingAction[targetActions.Length];
            for (int i = 0; i < targetActions.Length; i++)
            {
                targettingActions[i] = targetActions[i];
            }
            this.health = health;
        }

        public SelfAction[] SelfActions
        {
            get;
        }
        public TargettingAction[] TargettingActions
        {
            get;
        }
        public bool IsIncapacitated
        {
            get;
        }
        public int Health
        {
            get;
        }
    }
}
