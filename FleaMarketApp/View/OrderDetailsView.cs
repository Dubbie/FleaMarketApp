using FleaMarketApp.Helper;
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
    public partial class OrderDetailsView : Form, IOrderDetailsView
    {
        private readonly OrderDetailsPresenter presenter;
        private item_order _Order;

        public OrderDetailsView()
        {
            InitializeComponent();

            presenter = new OrderDetailsPresenter(this);
        }

        public item_order ItemOrder
        {
            get
            {
                return _Order;
            }

            set
            {
                _Order = value;

                lblOrderId.Text = "Megrendelési azonosító: " + _Order.order_id.ToString();
                lblItemName.Text = _Order.item.item_name;
                lblOrderedAt.Text = _Order.ordered_at.ToString("yyyy MMMM dd, HH:mm:ss");
                lblItemPrice.Text = _Order.item.GetFormattedPrice();

                UpdateLabels();
                UpdateButtons();
            }
        }

        private void UpdateLabels()
        {
            if (_Order.item.status_id != 4)
            {
                lblSold.Visible = false;
            }
        }

        public Form Form { get => this; }
        public bool Admin { get; set; }

        public event EventHandler<EventArgs> BtnCancelOrderClicked;
        public event EventHandler<EventArgs> BtnSellItemClicked;

        private void OrderDetailsView_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (Owner != null)
            {
                Owner.Enabled = true;
            }
        }

        private void UpdateButtons()
        {
            // Visszavonási gomb
            if (GetBusinessDays(ItemOrder.ordered_at, DateTime.Now) > 1 && Admin == false)
            {
                btnCancel.Enabled = false;
            }
            else
            {
                btnCancel.Enabled = true;
            }

            // Eladási gomb
            if (Admin != true)
            {
                btnSellItem.Enabled = false;
                btnSellItem.Visible = false;
            }

            if (_Order.item.status_id == 4)
            {
                btnSellItem.Enabled = false;
                btnCancel.Enabled = false;
            }
        }

        private int GetBusinessDays(DateTime from, DateTime to)
        {
            var dayDifference = (int)to.Subtract(from).TotalDays;
            return Enumerable
                .Range(1, dayDifference)
                .Select(x => from.AddDays(x))
                .Count(x => x.DayOfWeek != DayOfWeek.Saturday && x.DayOfWeek != DayOfWeek.Sunday);
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(
                "Biztosan szeretné törölni a megrendelést? Ez a folyamat nem visszafordítható.",
                "Törlés megerősítése",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                BtnCancelOrderClicked?.Invoke(this, EventArgs.Empty);
            }
        }

        private void btnSellItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(
                 "Biztosan el szeretné adni ezt a tárgyat?",
                 "Eladás megerősítése",
                 MessageBoxButtons.YesNo,
                 MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                BtnSellItemClicked?.Invoke(this, EventArgs.Empty);
            }
        }
    }
}
