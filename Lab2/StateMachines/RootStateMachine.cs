using Lab2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2.StateMachines
{
    class RootStateMachine : IStateMachine
    {
        private readonly List<ScientificWork> _scientificWorks = new List<ScientificWork>();
        private readonly Action<List<ScientificWork>> _workSetter;

        public RootStateMachine(Action<List<ScientificWork>> workSetter)
        {
            _workSetter = workSetter;
        }

        public IStateMachine Start(string elementName)
        {
            switch (elementName)
            {
                case Consts.Parser.Table:
                    return this;

                case Consts.Parser.ScientificWork:
                    return new ScientificWorkStateMachine(this);

                default:
                    return new DupmStateMachine(this, elementName);
            }
        }

        public IStateMachine Text(string text)
        {
            throw new NotImplementedException();
        }

        public IStateMachine End(string elementName)
        {
            _workSetter(_scientificWorks);

            return this;
        }

        public void AddScientificWork(ScientificWork work)
        {
            _scientificWorks.Add(work);
        }
    }
}
