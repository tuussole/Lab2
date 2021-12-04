using Lab2.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Lab2
{
    public partial class Form1 : Form
    {
        private readonly Dictionary<ComboBox, Func<Author, string>> _authorSelectors;

        private IReader _reader;
        public Form1()
        {
            InitializeComponent();

            _reader = new LinqToXmlReader(Consts.DataBaseLocation);

            _authorSelectors = new Dictionary<ComboBox, Func<Author, string>>
            {
                [this.firstNameComboBox] = AuthorHelper.FirstNameSelector,
                [this.middleNameComboBox] = AuthorHelper.MiddleNameSelector,
                [this.lastNameComboBox] = AuthorHelper.LastNameSelector
            };
            LoadAuthors(_reader);
        }
        
        private void LoadAuthors(IReader reader)
        {
            foreach(var map in _authorSelectors)
            {
                AuthorHelper.LoadAuthorCombobox(map.Key, reader, map.Value);
            }
        }

        private void Load()
        {
            var xmlDocument = new XmlDocument();
            xmlDocument.Load(Consts.DataBaseLocation);

            Debug.WriteLine(xmlDocument.InnerText);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var works = Filter(_reader);

            var writer = new Writer();
            var text = writer.Write(works);

            this.richTextBox1.Text = text;
        }

        private IEnumerable<ScientificWork> Filter(IReader reader)
        {
            var works = reader.GetScientificWorks();

            foreach (var map in _authorSelectors)
            {
                var filter = AuthorHelper.GetAuthorFilter(map.Key, map.Value);
                works = works.Where(filter);
            }

            return works.ToList();
        }
    }
}
