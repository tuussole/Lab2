using Lab2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Lab2
{
    class DomReader : IReader
    {
        private XmlDocument _document;


        public void Load(string path)
        {
            _document = new XmlDocument();
            _document.Load(path);
        }

        public IEnumerable<ScientificWork> GetScientificWorks()
        {
            return GetChildren(GetTable(), Consts.Parser.ScientificWork)
                    .Select(el => GetScientificWork(el));
                    
        }

        private ScientificWork GetScientificWork(XmlElement element)
        {
            return new ScientificWork
            {
                Name = GetFirstChildValue(element, Consts.Parser.Name),
                Author = GetAuthor(GetFirstChild(element, Consts.Parser.Author))
            };
        }

        private Author GetAuthor(XmlElement element)
        {
            return new Author
            {
                FirstName = GetFirstChildValue(element, Consts.Parser.FirstName),
                MiddleName = GetFirstChildValue(element, Consts.Parser.MiddleName),
                LastName = GetFirstChildValue(element, Consts.Parser.LastName),
            };
        }

        private XmlElement GetTable()
        {
            return _document.DocumentElement;
        }

        private IEnumerable<XmlElement> GetChildren(XmlNode node, string name)
        {
            return node.ChildNodes
                        .Cast<XmlElement>()
                        .Where(e => e.Name == name);
        }

        private XmlElement GetFirstChild(XmlElement element, string name)
        {
            return GetChildren(element, name)
                    .FirstOrDefault();

        }
        private string GetFirstChildValue(XmlElement element, string name)
        {
            return GetFirstChild(element, name)
                    .InnerText;
        }
    }
}
