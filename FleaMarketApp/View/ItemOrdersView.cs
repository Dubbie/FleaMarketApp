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
    public partial class ItemOrdersView : Form, IItemOrdersView
    {
        public ItemOrdersPresenter presenter;
        public ItemOrdersView()
        {
            InitializeComponent();

            presenter = new ItemOrdersPresenter(this);
        }

        public List<item_order> ItemOrders {
            set {
                listItemOrders.Items.Clear();

                foreach (item_order order in value)
                {
                    listItemOrders.Items.Add(order);
                }
            }
        }

        private void ItemOrdersView_FormClosed(object sender, FormClosedEventArgs e)
        {
            Owner.Enabled = true;
        }
    }
}
