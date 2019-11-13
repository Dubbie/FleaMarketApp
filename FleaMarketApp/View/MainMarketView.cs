using FleaMarketApp.View;
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
using FleaMarketApp.Model;

namespace FleaMarketApp
{
    public partial class MainMarketView : Form, IMainMarketView
    {
        private readonly MainMarketPresenter presenter;

        public MainMarketView()
        {
            InitializeComponent();

            presenter = new MainMarketPresenter(this);

        }

        public List<item> Items {
            set {
                listItems.Items.Clear();

                foreach (item item in value)
                {
                    listItems.Items.Add(item);
                }
            }
        }

        public string FilterItemName => txtFilterItemName.Text;
        public int? FilterItemId {
            get
            {
                if (!int.TryParse(txtFilterItemId.Text, out int tmp))
                {
                    return null;
                }
                return tmp;
            }
        }
        public ComboBoxItem FilterCategory => (ComboBoxItem)comboCategory.SelectedItem;


        public item SelectedItem => (item)listItems.Items[listItems.SelectedIndex];

        public string DetailItemId { set => lblDetailItemId.Text = value; }
        public string DetailItemName { set => lblDetailItemName.Text = value; }
        public string DetailItemDescription { set => lblDetailItemDescription.Text = value; }
        public string DetailItemPrice { set => lblDetailItemPrice.Text = value; }
        public List<category> Categories { 
            set {
                // Reset
                comboCategory.Items.Clear();
                comboCategory.DisplayMember = "Key";
                comboCategory.ValueMember = "Value";

                // Initialize it with whatever
                ComboBoxItem whateverItem = new ComboBoxItem
                {
                    Id = -1,
                    Text = "Mindegy"
                };

                comboCategory.Items.Add(whateverItem);
                comboCategory.SelectedItem = whateverItem;

                foreach (category category in value)
                {
                    // Create the ComboBoxItem, the output comes from the ToString return value
                    ComboBoxItem cbi = new ComboBoxItem
                    {
                        Id = category.category_id,
                        Text = category.category_name
                    };

                    comboCategory.Items.Add(cbi);
                }
            } 
        }

        public event EventHandler<EventArgs> ItemSelected;
        public event EventHandler<EventArgs> FiltersChanged;

        private void listItems_SelectedIndexChanged(object sender, EventArgs e)
        {
            ItemSelected?.Invoke(this, EventArgs.Empty);

            // Show item details
            ShowDetails();
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            FiltersChanged?.Invoke(this, EventArgs.Empty);
        }

        private void ShowDetails()
        {
            lblDetails.Visible = true;
            panelDetails.Visible = true;
        }

        private void HideDetails()
        {
            lblDetails.Visible = false;
            panelDetails.Visible = false;
        }
    }
}
