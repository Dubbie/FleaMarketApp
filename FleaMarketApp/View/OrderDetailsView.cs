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
        private readonly bool _Admin;
        private readonly OrderDetailsPresenter presenter;
        private item_order _Order;

        public event EventHandler<EventArgs> BtnCancelOrderClicked;

        public OrderDetailsView()
        {
            InitializeComponent();

            _Admin = true;
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

                lblOrderId.Text = _Order.order_id.ToString();
                lblItemName.Text = _Order.item.item_name;
                lblOrderedAt.Text = _Order.ordered_at.ToString("yyyy MMMM dd, HH:mm:ss");

                UpdateCancelButton();
            }
        }

        public Form Form { get => this; }

        private void OrderDetailsView_FormClosed(object sender, FormClosedEventArgs e)
        {
            Owner.Enabled = true;
        }

        private void UpdateCancelButton()
        {
            if (GetBusinessDays(ItemOrder.ordered_at, DateTime.Now) > 1 && !_Admin)
            {
                btnCancel.Enabled = false;
            }
            else
            {
                btnCancel.Enabled = true;
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
    }
}
