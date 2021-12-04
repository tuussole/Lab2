using Lab2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2.StateMachines
{
    class ScientificWorkStateMachine : IStateMachine
    {
        private readonly RootStateMachine _rootStateMachine;
        private readonly ScientificWork _scientificWork;

        public ScientificWorkStateMachine(RootStateMachine rootStateMachine)
        {
            _rootStateMachine = rootStateMachine;
            _scientificWork = new ScientificWork();
        }

        public IStateMachine Start(string elementName)
        {
            switch (elementName)
            {
                case Consts.Parser.Author:
                    return new AuthorStateMachine(this);

                case Consts.Parser.Name:
                    return new NameStateMachine(this, _scientificWork);

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
            if (elementName != Consts.Parser.ScientificWork)
            {
                throw new Exception("Incorrect state");
            }

            _rootStateMachine.AddScientificWork(_scientificWork);

            return _rootStateMachine;
        }

        public void AddAuthor(Author author)
        {
            _scientificWork.Author = author;
        }
    }
}
