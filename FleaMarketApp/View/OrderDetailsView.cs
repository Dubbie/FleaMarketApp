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
        private bool _Admin;
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
        public bool Admin
        {
            get
            {
                return _Admin;
            }
            set {
                _Admin = value;
            }
        }
        public event EventHandler<EventArgs> BtnCancelOrderClicked;
        public event EventHandler<EventArgs> BtnSellItemClicked;

        private void OrderDetailsView_FormClosed(object sender, FormClosedEventArgs e)
        {
            Owner.Enabled = true;
        }

        private void UpdateButtons()
        {
            // Visszavonási gomb
            if (GetBusinessDays(ItemOrder.ordered_at, DateTime.Now) > 1 && !_Admin)
            {
                btnCancel.Enabled = false;
            }
            else
            {
                btnCancel.Enabled = true;
            }

            // Eladási gomb
            if (_Order.item.status_id == 4)
            {
                btnSellItem.Enabled = false;
                btnCancel.Enabled = false;
            } else
            {
                if (_Admin == true)
                {
                    btnSellItem.Enabled = true;
                    btnSellItem.Visible = true;
                }
                else
                {
                    btnSellItem.Enabled = false;
                    btnSellItem.Visible = false;
                }
            }
        }

        private double GetBusinessDays(DateTime startD, DateTime endD)
        {
            double calcBusinessDays =
                1 + ((endD - startD).TotalDays * 5 -
                (startD.DayOfWeek - endD.DayOfWeek) * 2) / 7;

            if (endD.DayOfWeek == DayOfWeek.Saturday) calcBusinessDays--;
            if (startD.DayOfWeek == DayOfWeek.Sunday) calcBusinessDays--;

            return calcBusinessDays;
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            BtnCancelOrderClicked?.Invoke(this, EventArgs.Empty);
        }

        private void btnSellItem_Click(object sender, EventArgs e)
        {
            BtnSellItemClicked?.Invoke(this, EventArgs.Empty);
        }
    }
}
