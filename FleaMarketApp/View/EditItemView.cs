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
    public partial class EditItemView : Form, IEditItemView
    {
        private EditItemPresenter presenter;

        public EditItemView()
        {
            InitializeComponent();

            presenter = new EditItemPresenter(this);
        }

        public decimal ItemId { get ; set; }
        public string ItemName { get => txtItemName.Text; set => txtItemName.Text = value; }
        public string Description { get => txtItemDescription.Text; set => txtItemDescription.Text = value; }
        public decimal? Price {
            get {

                if (decimal.TryParse(txtPrice.Text, out decimal price))
                {
                    return price;
                }

                return null;
            } set => txtPrice.Text = value.ToString(); }
        public decimal CategoryId {
            get
            {
                ComboBoxItem cbi = (ComboBoxItem)comboCategory.SelectedItem;
                return cbi.Id;
            }
            set
            {
                foreach(ComboBoxItem cbi in comboCategory.Items)
                {
                    if (cbi.Id == value)
                    {
                        comboCategory.SelectedItem = cbi;
                        break;
                    }
                }
            }
        }
        public decimal StatusId {
            get
            {
                ComboBoxItem cbi = (ComboBoxItem)comboStatus.SelectedItem;
                return cbi.Id;
            }
            set
            {
                foreach (ComboBoxItem cbi in comboStatus.Items)
                {
                    if (cbi.Id == value)
                    {
                        comboStatus.SelectedItem = cbi;
                        break;
                    }
                }
            }
        }
        public bool ItemUpdated { get; set; }
        public List<category> Categories { 
            set {
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
        public List<status> Statuses {
            set {
                foreach (status status in value)
                {
                    ComboBoxItem cbi = new ComboBoxItem
                    {
                        Id = status.status_id,
                        Text = status.status_name
                    };

                    comboStatus.Items.Add(cbi);
                }
            }
        }

        public event EventHandler<EventArgs> UpdateItem;

        private void btnSave_Click(object sender, EventArgs e)
        {
            // Validálást végezzünk el
            if (ValidateInputs())
            {
                UpdateItem?.Invoke(this, EventArgs.Empty);

                if (ItemUpdated)
                {
                    Close();
                }
            }
        }

        private void EditItemView_FormClosed(object sender, FormClosedEventArgs e)
        {
            Owner.Enabled = true;
        }

        private bool ValidateInputs()
        {
            bool error = false;
            string dialogTitle = "Hiba a tárgy frissítésekor";

            // Üres név esetén off
            if (string.IsNullOrEmpty(txtItemName.Text))
            {
                MessageBox.Show("A tárgy neve nem lehet üres!", dialogTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
                error = true;
            }
            // Nem jó az ár
            if (!string.IsNullOrEmpty(txtPrice.Text) && !decimal.TryParse(txtPrice.Text, out _))
            {
                MessageBox.Show("A ára nem helyesen lett megadva!", dialogTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
                error = true;
            } else
            {
                ComboBoxItem selectedStatus = (ComboBoxItem)comboStatus.SelectedItem;
                // Ha nincs ár akkor csak új státusszal mehet ki
                if (string.IsNullOrEmpty(txtPrice.Text) && selectedStatus.Id != 1)
                {
                    MessageBox.Show("Ár nélküli termék csak újként lehet kint az adatbázisban!", dialogTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    error = true;
                }
                else if (!string.IsNullOrEmpty(txtPrice.Text) && selectedStatus.Id == 1)
                {
                    // Ha van ár megadva a termék már nem lehet új, hanem aktív kell hogy legyen
                    MessageBox.Show("Árral rendelkező termék nem lehet új!", dialogTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    error = true;
                }
            }

            return !error;
        }
    }
}
