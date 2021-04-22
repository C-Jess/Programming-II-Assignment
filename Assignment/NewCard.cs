using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Assignment
{
    public partial class NewCard : Form
    {
        Dictionary<string, IInfoCardFactory> _factories;
        string _selectedCategory;

        public NewCard()
        {
            InitializeComponent();
        }

        public Dictionary<string, IInfoCardFactory> Factories
        {
            set
            {
                _factories = value;
            }
        }

        public string SelectedCategory
        {
            get
            {
                return _selectedCategory;
            }
        }
        private void NewCard_Load(object sender, EventArgs e)
        {
            listViewCategories.Columns[1].Width = listViewCategories.Width - listViewCategories.Columns[0].Width;
            if (_factories != null)
            {
                foreach (KeyValuePair<string,IInfoCardFactory> factoryPair in _factories)
                {
                    ListViewItem item = new ListViewItem(factoryPair.Key);
                    item.SubItems.Add(factoryPair.Value.GetDescription(factoryPair.Key));
                    listViewCategories.Items.Add(item);
                }
            }
        }

        private void buttonSelect_Click(object sender, EventArgs e)
        {
            ListViewItem item = listViewCategories.SelectedItems[0];
            _selectedCategory = item.Text;
        }

        private void listViewCategories_SelectedIndexChanged(object sender, EventArgs e)
        {
            buttonSelect.Enabled = true;
        }
    }
}
