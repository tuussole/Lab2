using Lab2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2.StateMachines
{
    class AuthorStateMachine : IStateMachine
    {
        private ScientificWorkStateMachine _scientWorkStateMachine;

        private Author _author;

        public AuthorStateMachine(ScientificWorkStateMachine scientWorkStateMachine)
        {
            _scientWorkStateMachine = scientWorkStateMachine;
            _author = new Author();
        }

        public IStateMachine Start(string elementName)
        {
            switch (elementName)
            {
                case Consts.Parser.FirstName:
                    return new AuthorNameStateMachine(this, (n) => _author.FirstName = n, elementName);

                case Consts.Parser.MiddleName:
                    return new AuthorNameStateMachine(this, (n) => _author.MiddleName = n, elementName);

                case Consts.Parser.LastName:
                    return new AuthorNameStateMachine(this, (n) => _author.LastName = n, elementName);
            }

            throw new NotImplementedException();
        }

        public IStateMachine End(string elementName)
        {
            if (elementName != Consts.Parser.Author)
            {
                throw new Exception("Incorrect state");
            }

            _scientWorkStateMachine.AddAuthor(_author);
            return _scientWorkStateMachine;
        }


        public IStateMachine Text(string text)
        {
            throw new NotImplementedException();
        }
    }
}
