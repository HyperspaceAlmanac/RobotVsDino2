using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotVersusDinosaursGame
{
    // Interface that defines Methods to retrieve strings to display
    interface IDisplayInformation
    {
        int StatusNumberOfLines();
        void DisplayStatusLine(int line);
    }
}
