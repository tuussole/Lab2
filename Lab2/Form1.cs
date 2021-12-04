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
        private readonly Dictionary<RadioButton, IReader> _readers;
        private readonly List<ComboBox> _filters;

       // private IReader _reader;
        private Repository _repository;

        private RadioButton _selectedRadioButton;
        public Form1()
        {
            InitializeComponent();

            //_reader = new LinqToXmlReader(Consts.DataBaseLocation);

            _authorSelectors = new Dictionary<ComboBox, Func<Author, string>>
            {
                [this.firstNameComboBox] = AuthorHelper.FirstNameSelector,
                [this.middleNameComboBox] = AuthorHelper.MiddleNameSelector,
                [this.lastNameComboBox] = AuthorHelper.LastNameSelector
            };

            _readers = new Dictionary<RadioButton, IReader>
            {
                [this.linqReaderRadioButton] = new LinqToXmlReader(),
                [this.domReaderRadioButton] = new DomReader(),
                [this.saxReaderRadioButton] = new SaxReader()
            };

            _filters = new List<ComboBox>
            {
                this.firstNameComboBox,
                this.middleNameComboBox,
                this.lastNameComboBox
            };
            //Load();
        }

        private void Load()
        {
            var domReader = new DomReader();
            domReader.Load(Consts.DataBaseLocation);
            domReader.GetScientificWorks();

            var xmlDocument = new XmlDocument();
            xmlDocument.Load(Consts.DataBaseLocation);

            //xmlDocument.

            Debug.WriteLine(xmlDocument.InnerText);
        }

        #region Events

        private void filterButton_Click(object sender, EventArgs e)
        {
            if(_repository == null)
            {
                MessageBox.Show("Firstly select reader and press Fill button");
                return;
            }

            var works = Filter(_repository);

            var writer = new Writer();
            var text = writer.Write(works);

            this.richTextBox1.Text = text;
        }

        private void readerRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            var radioButton = sender as RadioButton;

            if (radioButton.Checked)
            {
                _selectedRadioButton = radioButton;
            }
        }
        private void fillButton_Click(object sender, EventArgs e)
        {
            if(_selectedRadioButton == null)
            {
                MessageBox.Show("Firstly select reader");
                return;
            }

            var reader = _readers[_selectedRadioButton];

            reader.Load(Consts.DataBaseLocation);

            _repository = new Repository(reader);
            LoadAuthors(_repository);
        }

        private void clearFilters_Click(object sender, EventArgs e)
        {
            foreach(var filter in _filters)
            {
                filter.SelectedItem = Consts.All;
            }
        }

        #endregion




        #region Helpers
        private void LoadAuthors(Repository repository)
        {
            foreach (var map in _authorSelectors)
            {
                AuthorHelper.LoadAuthorCombobox(map.Key, repository, map.Value);
            }
        }

        private IEnumerable<ScientificWork> Filter(Repository repository)
        {
            var works = repository.GetScientificWorks();

            foreach (var map in _authorSelectors)
            {
                var filter = AuthorHelper.GetAuthorFilter(map.Key, map.Value);
                works = works.Where(filter);
            }

            return works.ToList();
        }

        #endregion
    }
}
