using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotVersusDinosaursGame
{
    enum PlayerInputStatus
    {
        DoubleBlindPick,
        PickCombatant,
        PickAction
    }
    enum GameStateStatus
    {
        DoubleBlindPlayerOne,
        DoubleBlinkdPlayerTwo,
        ReactionPlayerOne,
        ReactionPlayerTwo
    }
    enum GameState
    {
        SelectMode,
        SelectArmy,
        CreateArmy,
        MainGameLogic,
        GameOver
    }
    class Game
    {
    }
}
