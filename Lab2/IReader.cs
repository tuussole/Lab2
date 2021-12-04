using Lab2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    interface IReader
    {
        void Load(string path);
        public IEnumerable<ScientificWork> GetScientificWorks();
        //public IEnumerable<ScientificWork> GetScientificWorks(Func<ScientificWork, bool> predicate);

        //public IEnumerable<Author> GetAuthors();

        //public IEnumerable<string> GetAuthorName(Func<Author, string> nameSelector);
    }
}
