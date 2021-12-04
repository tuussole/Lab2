using Lab2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2
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
            var selected = comboBox.SelectedItem.ToString();

            return selected == Consts.All
                ? (sw) => true
                : sw => nameSelector(sw.Author) == selected;
        }

        public static void LoadAuthorCombobox(ComboBox comboBox, IReader reader, Func<Author, string> nameSelector)
        {
            var list = new List<string> { Consts.All };

            var authorNames = reader.GetAuthorName(nameSelector);
            list.AddRange(authorNames);

            comboBox.DataSource = list;
            comboBox.SelectedItem = Consts.All;
        }
    }
}
