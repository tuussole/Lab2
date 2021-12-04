using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2.StateMachines
{
    class AuthorNameStateMachine : IStateMachine
    {
        private readonly AuthorStateMachine _authorStateMachine;
        private readonly Action<string> _nameSaver;
        private readonly string _elementName;

        public AuthorNameStateMachine(AuthorStateMachine authorStateMachine, Action<string> nameSaver, string elementName)
        {
            _authorStateMachine = authorStateMachine;
            _nameSaver = nameSaver;
            _elementName = elementName;
        }

        public IStateMachine Start(string elementName)
        {
            throw new NotImplementedException();
        }

        public IStateMachine Text(string text)
        {
            _nameSaver(text);
            return this;
        }

        public IStateMachine End(string elementName)
        {
            if (_elementName != elementName)
            {
                throw new Exception("Incorrect state");
            }

            return _authorStateMachine;
        }
    }
}
