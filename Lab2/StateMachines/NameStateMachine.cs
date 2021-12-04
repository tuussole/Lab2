using Lab2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2.StateMachines
{
    class NameStateMachine : IStateMachine
    {
        private readonly ScientificWorkStateMachine _scientWorkStateMachine;
        private readonly ScientificWork _scientificWork;

        public NameStateMachine(ScientificWorkStateMachine scientWorkStateMachine, ScientificWork scientificWork)
        {
            _scientWorkStateMachine = scientWorkStateMachine;
            _scientificWork = scientificWork;
        }

        public IStateMachine Start(string elementName)
        {
            throw new NotImplementedException();
        }

        public IStateMachine Text(string text)
        {
            _scientificWork.Name = text;
            return this;
        }
        public IStateMachine End(string elementName)
        {
            if (elementName != Consts.Parser.Name)
            {
                throw new Exception("Incorrect state");
            }

            return _scientWorkStateMachine;
        }
    }
}
