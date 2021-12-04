using Lab2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2.Helpers
{
    static class AuthorHelper
    {
        public static Func<Author, string> FirstNameSelector = (a) => a.FirstName;
        public static Func<Author, string> MiddleNameSelector = (a) => a.MiddleName;
        public static Func<Author, string> LastNameSelector = (a) => a.LastName;

        public static IEnumerable<Func<Author, string>> AllNameSelectors = new List<Func<Author, string>>
        {
            FirstNameSelector,
            MiddleNameSelector,
            LastNameSelector
        };

        public static Func<ScientificWork, bool> GetAuthorFilter(ComboBox comboBox, Func<Author, string> nameSelector)
        {
            return ComboBoxHelper.GetFilter(comboBox, (sw) => nameSelector(sw.Author));
        }

        public static void LoadAuthorCombobox(ComboBox comboBox, Repository repository, Func<Author, string> nameSelector)
        {
            var authorNames = repository.GetAuthorName(nameSelector);

            ComboBoxHelper.LoadCombobox(comboBox, authorNames);
        }
    }
}
