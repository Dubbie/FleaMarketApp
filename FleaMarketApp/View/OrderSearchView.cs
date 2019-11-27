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
    public partial class OrderSearchView : Form, IOrderSearchView
    {
        private OrderSearchPresenter presenter;

        public OrderSearchView()
        {
            InitializeComponent();

            presenter = new OrderSearchPresenter(this);
        }

        public Form Form => this;

        public decimal ItemOrderId
        {
            get
            {
                if (decimal.TryParse(txtOrderId.Text, out decimal itemOrderId))
                {
                    return itemOrderId;
                } else
                {
                    MessageBox.Show("Kérem a bemeneti mezőt töltse ki helyesen", "Keresési hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return -1;
                }
            }
            set
            {
                txtOrderId.Text = value.ToString();
            }
        }

        public event EventHandler<EventArgs> BtnSearchClicked;

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            BtnSearchClicked?.Invoke(this, EventArgs.Empty);
        }

        private void OrderSearchView_FormClosed(object sender, FormClosedEventArgs e)
        {
            Owner.Enabled = true;
        }
    }
}
