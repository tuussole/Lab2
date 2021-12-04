using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2.StateMachines
{
    class DupmStateMachine : IStateMachine
    {
        private readonly IStateMachine _parent;

        private string _elementName;

        public DupmStateMachine(IStateMachine parent, string elementName)
        {
            _parent = parent;
            _elementName = elementName;
        }

        public IStateMachine Start(string elementName)
        {
            return this;
        }
        public IStateMachine Text(string text)
        {
            return this;
        }

        public IStateMachine End(string elementName)
        {
            if (_elementName != elementName)
            {
                return this;
            }

            return _parent;
        }
    }
}
