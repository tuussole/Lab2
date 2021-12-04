using Lab2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2.Helpers
{
    class ComboBoxHelper
    {
        public static void LoadCombobox(ComboBox comboBox, IEnumerable<string> items)
        {
            var list = new List<string> { Consts.All };

            list.AddRange(items);

            comboBox.DataSource = list;
            comboBox.SelectedItem = Consts.All;
        }

        public static Func<ScientificWork, bool> GetFilter(ComboBox comboBox, Func<ScientificWork, string> selector)
        {
            var selected = comboBox.SelectedItem.ToString();

            return selected == Consts.All
                ? sw => true
                : sw => selector(sw) == selected;
        }
    }
}
