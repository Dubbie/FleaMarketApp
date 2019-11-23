using FleaMarketApp.Model;
using FleaMarketApp.Presenter;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FleaMarketApp.View
{
    public partial class NewItemView : Form, INewItemView
    {
        private NewItemPresenter presenter;

        public NewItemView()
        {
            InitializeComponent();

            presenter = new NewItemPresenter(this);
        }

        public bool ItemSaved { get; set; }
        public string ItemName { get => txtItemName.Text; }
        public string Description { get => txtItemDescription.Text; }
        public decimal? Price { 
            get {
                if (string.IsNullOrEmpty(txtPrice.Text))
                {
                    return null;
                }

                return decimal.Parse(txtPrice.Text);
            } 
        }
        public decimal CategoryId
        {
            get
            {
                ComboBoxItem cbi = (ComboBoxItem)comboCategory.SelectedItem;
                return cbi.Id;
            }
        }
        public List<category> Categories
        {
            set
            {
                // Add default to category
                comboCategory.Items.Clear();
                ComboBoxItem defaultCbi = new ComboBoxItem
                {
                    Id = -1,
                    Text = "Válasszon kategóriát..."
                };
                comboCategory.Items.Add(defaultCbi);
                comboCategory.SelectedItem = defaultCbi;

                foreach (category category in value)
                {
                    ComboBoxItem cbi = new ComboBoxItem
                    {
                        Id = category.category_id,
                        Text = category.category_name
                    };

                    comboCategory.Items.Add(cbi);
                }
            }
        }

        public event EventHandler<EventArgs> SaveItem;

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveItem?.Invoke(this, EventArgs.Empty);

            if (ItemSaved)
            {
                Close();
            }
        }

        private void NewItemView_FormClosed(object sender, FormClosedEventArgs e)
        {
            Owner.Enabled = true;
        }
    }
}
