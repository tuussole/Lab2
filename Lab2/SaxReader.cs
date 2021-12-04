using Lab2.Models;
using Lab2.StateMachines;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Lab2
{
    class SaxReader : IReader
    {
        private string _path;
        
        //public IEnumerable<ScientificWork> GetScientificWorks()
        //{
        //    Read();

        //    return new[] { new ScientificWork()};
        //}

        public void Load(string path)
        {
            _path = path;
        }


        //private void Read()

        public IEnumerable<ScientificWork> GetScientificWorks()
        {

            List<ScientificWork> scientificWorks = new List<ScientificWork>();
            var xmlReader = new XmlTextReader(_path);

            IStateMachine stateMachine = new RootStateMachine((works) => scientificWorks = works);

            while (xmlReader.Read())
            {
                //var nodeType = xmlReader.NodeType;
                //var name = xmlReader.Name;
                //var value = xmlReader.Value;

                if(xmlReader.NodeType == XmlNodeType.Element)
                {
                    stateMachine = stateMachine.Start(xmlReader.Name);

                }

                else if(xmlReader.NodeType == XmlNodeType.Text)
                {
                    stateMachine = stateMachine.Text(xmlReader.Value);
                }

                else if(xmlReader.NodeType == XmlNodeType.EndElement)
                {
                    stateMachine = stateMachine.End(xmlReader.Name);
                }
            }

            return scientificWorks;
        }

    }
}
