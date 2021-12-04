using Lab2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Lab2
{
    class LinqToXmlReader : IReader
    {
        private XDocument document;

        public void Load(string path)
        {
            document = XDocument.Load(path);
        }

        public IEnumerable<ScientificWork> GetScientificWorks()
        {
            return document.Element(Consts.Parser.Table)
                           .Elements(Consts.Parser.ScientificWork)
                           .Select(e => GetScientificWork(e));
        }

        public IEnumerable<Author> GetAuthors()
        {
            return GetScientificWorks()
                    .Select(sw => sw.Author)
                    .ToList();
        }

        public IEnumerable<string> GetAuthorName(Func<Author, string> nameSelector)
        {
            return GetAuthors()
                    .Select(nameSelector)
                    .ToHashSet();
        }


        private ScientificWork GetScientificWork(XElement xElement)
        {
            return new ScientificWork
            {
                Author = GetAuthor(xElement.Element(Consts.Parser.Author)),
                Name = GetValueFromElement(xElement, Consts.Parser.Name)
            };
        }

        private Author GetAuthor(XElement xElement)
        {
            return new Author
            {
                FirstName = GetValueFromElement(xElement, Consts.Parser.FirstName),
                MiddleName = GetValueFromElement(xElement, Consts.Parser.MiddleName),
                LastName = GetValueFromElement(xElement, Consts.Parser.LastName),
            };
        }

        private string GetValueFromElement(XElement xElement, string name)
        {
            return xElement.Element(name).Value;
        }
    }
}
