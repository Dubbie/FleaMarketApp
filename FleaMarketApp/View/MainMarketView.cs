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
        private bool _Admin;

        public MainMarketView()
        {
            InitializeComponent();

            presenter = new MainMarketPresenter(this);
        }

        public Form Form => this;

        public bool Admin
        {
            get
            {
                return _Admin;
            }
            set
            {
                _Admin = value;
                UpdateView();
            }
        }

        private void UpdateView()
        {
            if (_Admin != true)
            {
                // Megrendelések gomb
                btnItemOrders.Enabled = false;
                btnItemOrders.Visible = false;

                // Új tárgy gomb
                btnNewItem.Enabled = false;
                btnNewItem.Visible = false;

                // Státusz választó
                lblStatus.Enabled = false;
                lblStatus.Visible = false;
                comboStatus.Enabled = false;
                comboStatus.Visible = false;

                // Megveszem gomb megjelenítése
                btnMakeOrder.Enabled = true;
                btnMakeOrder.Visible = true;

                // Szerkesztés gomb eltüntetése
                btnEdit.Enabled = false;
                btnEdit.Visible = false;
            }
            else
            {
                // Megveszem gomb eltünetése
                btnMakeOrder.Enabled = false;
                btnMakeOrder.Visible = false;
            }
        }

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
                // Töröljük alaphelyzetbe
                comboCategory.Items.Clear();
                comboCategory.DisplayMember = "Key";
                comboCategory.ValueMember = "Value";

                // Alapértelmezés hozzáadása
                ComboBoxItem whateverItem = new ComboBoxItem
                {
                    Id = -1,
                    Text = "Mindegy"
                };

                comboCategory.Items.Add(whateverItem);
                comboCategory.SelectedItem = whateverItem;

                foreach (category category in value)
                {
                    // Létrehozzuk a ComboBoxItem-et, a szöveg a ToString-ból jön
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
                // Töröljük alaphelyzetbe
                comboStatus.Items.Clear();
                comboStatus.DisplayMember = "Key";
                comboStatus.ValueMember = "Value";

                // Alapértelmezés hozzáadása
                ComboBoxItem whateverItem = new ComboBoxItem
                {
                    Id = -1,
                    Text = "Mindegy"
                };

                comboStatus.Items.Add(whateverItem);
                comboStatus.SelectedItem = whateverItem;

                foreach (status status in value)
                {
                    // Létrehozzuk a ComboBoxItem-et, a szöveg a ToString-ból jön
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
        public event EventHandler<EventArgs> BtnItemOrdersClicked;
        public event EventHandler<EventArgs> BtnMakeOrderClicked;

        // Szűrés
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
        // Részletek
        public string DetailItemId { set => lblDetailItemId.Text = value; }
        public string DetailItemName { set => lblDetailItemName.Text = value; }
        public string DetailItemStatus { set => lblDetailItemStatus.Text = value; }
        public string DetailItemDescription { set => lblDetailItemDescription.Text = value; }
        public string DetailItemPrice { set => lblDetailItemPrice.Text = value; }
        public string DetailCategory { set => lblDetailCategory.Text = value; }
        public string DetailCreatedAt { set => lblDetailCreatedAt.Text = value; }
        public string DetailModifiedAt { set => lblDetailModifiedAt.Text = value; }

        // Eseménykezelés
        private void listItems_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listItems.SelectedIndex != -1)
            {
                lastSelectedItemId = listItems.SelectedIndex;
                ItemSelected?.Invoke(this, EventArgs.Empty);

                // Mutassuk a részletek panelt
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

            // Módosítás gomb csak akkor elérhető, ha a tárgy nincs eladva vagy megrendelés alatt
            if (SelectedItem.status_id == 4 || SelectedItem.status_id == 3)
            {
                btnEdit.Enabled = false;
            } else
            {
                btnEdit.Enabled = true;
            }
        }

        private void HideDetails()
        {
            lblDetails.Visible = false;
            panelDetails.Visible = false;
        }

        private void btnNewItem_Click(object sender, EventArgs e)
        {
            Enabled = false;

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
            Enabled = false;

            BtnEditItemClicked?.Invoke(this, EventArgs.Empty);
        }

        private void BtnItemOrders_Click(object sender, EventArgs e)
        {
            Enabled = false;

            BtnItemOrdersClicked?.Invoke(this, EventArgs.Empty);
        }

        private void BtnOrder_Click(object sender, EventArgs e)
        {
            Enabled = false;

            BtnMakeOrderClicked?.Invoke(this, EventArgs.Empty);
        }
    }
}
