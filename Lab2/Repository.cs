using Lab2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class Repository
    {
        private readonly IReader _reader;

        public Repository(IReader reader)
        {
            _reader = reader;
        }

        public IEnumerable<ScientificWork> GetScientificWorks()
        {
            return _reader.GetScientificWorks();
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

        public IEnumerable<string> GetWorkNames()
        {
            return GetScientificWorks()
                    .Select(sw => sw.Name)
                    .ToList();
        }
    }
}
