﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotVersusDinosaursGame
{
    class Fleet : ICanTakeAction, ICanSelectUnits
    {
        protected Robot[] robots;
    }
}
