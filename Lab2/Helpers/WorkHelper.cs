using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2.Helpers
{
    class WorkHelper
    {
        public static void LoadNameComboBox(ComboBox comboBox, Repository repository)
        {
            var names = repository.GetWorkNames();

            ComboBoxHelper.LoadCombobox(comboBox, names);
        }
    }
}
