using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2.StateMachines
{
    interface IStateMachine
    {
        IStateMachine Start(string elementName);

        IStateMachine Text(string text);

        IStateMachine End(string elementName);
    }
}
