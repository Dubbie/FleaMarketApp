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
        private int? lastSelectedItemId;

        public MainMarketView()
        {
            InitializeComponent();

            presenter = new MainMarketPresenter(this);
        }

        public Form Form => this;

        public List<item> Items
        {
            set
            {
                listItems.Items.Clear();

                foreach (item item in value)
                {
                    listItems.Items.Add(item);
                }
            }
        }

        public List<category> Categories
        {
            set
            {
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

        public List<status> Statuses
        {
            set
            {
                // Reset
                comboStatus.Items.Clear();
                comboStatus.DisplayMember = "Key";
                comboStatus.ValueMember = "Value";

                // Initialize it with whatever
                ComboBoxItem whateverItem = new ComboBoxItem
                {
                    Id = -1,
                    Text = "Mindegy"
                };

                comboStatus.Items.Add(whateverItem);
                comboStatus.SelectedItem = whateverItem;

                foreach (status status in value)
                {
                    // Create the ComboBoxItem, the output comes from the ToString return value
                    ComboBoxItem cbi = new ComboBoxItem
                    {
                        Id = status.status_id,
                        Text = status.status_name
                    };

                    comboStatus.Items.Add(cbi);
                }
            }
        }

        public event EventHandler<EventArgs> ItemSelected;
        public event EventHandler<EventArgs> FiltersChanged;
        public event EventHandler<EventArgs> BtnNewItemClicked;
        public event EventHandler<EventArgs> BtnEditItemClicked;

        // Filter stuff
        public string FilterItemName => txtFilterItemName.Text;
        public int? FilterItemId
        {
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
        public ComboBoxItem FilterStatus => (ComboBoxItem)comboStatus.SelectedItem;
        public decimal? FilterPriceMin
        {
            get
            {
                if (string.IsNullOrEmpty(txtFilterPriceMin.Text))
                {
                    return null;
                }
                else
                {
                    return decimal.Parse(txtFilterPriceMin.Text);
                }
            }
        }
        public decimal? FilterPriceMax
        {
            get
            {
                if (string.IsNullOrEmpty(txtFilterPriceMax.Text))
                {
                    return null;
                }
                else
                {
                    return decimal.Parse(txtFilterPriceMax.Text);
                }
            }
        }

        public item SelectedItem => (item)listItems.Items[listItems.SelectedIndex];
        // Details
        public string DetailItemId { set => lblDetailItemId.Text = value; }
        public string DetailItemName { set => lblDetailItemName.Text = value; }
        public string DetailItemStatus { set => lblDetailItemStatus.Text = value; }
        public string DetailItemDescription { set => lblDetailItemDescription.Text = value; }
        public string DetailItemPrice { set => lblDetailItemPrice.Text = value; }
        public string DetailCategory { set => lblDetailCategory.Text = value; }
        public string DetailCreatedAt { set => lblDetailCreatedAt.Text = value; }
        public string DetailModifiedAt { set => lblDetailModifiedAt.Text = value; }

        // Event handling
        private void listItems_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listItems.SelectedIndex != -1)
            {
                lastSelectedItemId = listItems.SelectedIndex;
                ItemSelected?.Invoke(this, EventArgs.Empty);

                // Show item details
                ShowDetails();
            }
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

        private void btnNewItem_Click(object sender, EventArgs e)
        {
            this.Enabled = false;

            BtnNewItemClicked?.Invoke(this, EventArgs.Empty);
        }

        private void MainMarketView_EnabledChanged(object sender, EventArgs e)
        {
            if (Enabled)
            {
                FiltersChanged?.Invoke(this, EventArgs.Empty);

                if (lastSelectedItemId != null)
                {
                    listItems.SelectedIndex = (int)lastSelectedItemId;
                }
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            this.Enabled = false;

            BtnEditItemClicked?.Invoke(this, EventArgs.Empty);
        }
    }
}
