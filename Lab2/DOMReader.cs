using Lab2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Lab2
{
    class DOMReader : IReader
    {
        private XmlDocument _document;

        public DOMReader(string path)
        {
            _document = new XmlDocument();
            _document.Load(path);
        }

        public IEnumerable<string> GetAuthorName(Func<Author, string> nameSelector)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Author> GetAuthors()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ScientificWork> GetScientificWorks()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ScientificWork> GetScientificWorks(Func<ScientificWork, bool> predicate)
        {
            throw new NotImplementedException();
        }
    }
}
