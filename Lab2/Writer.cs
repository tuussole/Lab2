using Lab2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    public class Writer
    {
        private const string Template = "{0}: {1}";
        private const string Level = "\t";
        private const char Separator = '-';
        private const int InitLevel = 0;

        private readonly StringBuilder _builder = new StringBuilder();
        private readonly int _length;

        public Writer(int length)
        {
            _length = length;
        }

        public string Write(IEnumerable<ScientificWork> scientificWorks)
        {
            foreach(var work in scientificWorks)
            {
                WriteScientificWork(work);
            }

            return _builder.ToString();
        }

        private void WriteScientificWork(ScientificWork work)
        {
            WriteValue(Consts.Writer.ScientificWork, string.Empty, InitLevel);

            var nextLevel = InitLevel + 1;
            WriteAuthor(work.Author, nextLevel);
            WriteValue(Consts.Writer.Name, work.Name, nextLevel);

            WriteSeparator();
        }

        private void WriteAuthor(Author author, int level)
        {
            WriteValue(Consts.Writer.Author, string.Empty, level);

            var nextLevel = level + 1;
            WriteValue(Consts.Writer.FirstName, author.FirstName, nextLevel);
            WriteValue(Consts.Writer.MiddleName, author.MiddleName, nextLevel);
            WriteValue(Consts.Writer.LastName, author.LastName, nextLevel);
        }

        private void WriteValue(string key, object value, int level)
        {
            WriteLevel(level);
            _builder.AppendFormat(Template, key, value)
                    .AppendLine();
        }
        
        private void WriteLevel(int level)
        {
            foreach (var l in Enumerable.Repeat(Level, level))
            {
                _builder.Append(l);
            }
        }

        private void WriteSeparator()
        {
            _builder.AppendLine(new string(Enumerable.Repeat(Separator, _length).ToArray()));
        }

    }
}
