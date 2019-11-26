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

        public event EventHandler<EventArgs> UpdateOrders;

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

        private void ListItemOrders_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listItemOrders.SelectedIndex != -1)
            {
                item_order foundOrder = (item_order)listItemOrders.SelectedItem;

                OrderDetailsView details = new OrderDetailsView
                {
                    ItemName = foundOrder.item.item_name,
                    ItemPrice = foundOrder.item.GetFormattedPrice(),
                    OrderedAt = foundOrder.ordered_at,
                    OrdererAddress = foundOrder.orderer_address,
                    OrdererEmail = foundOrder.orderer_email,
                    OrdererName = foundOrder.orderer_name,
                    OrdererPhone = foundOrder.orderer_phone,
                    StatusId = foundOrder.item.status_id,

                    OrderItemId = foundOrder.item_id,
                    OrderId = foundOrder.order_id,
                    Owner = this
                };

                Enabled = false;
                details.Show();
            }
        }

        private void ItemOrdersView_EnabledChanged(object sender, EventArgs e)
        {
            // Update list
            UpdateOrders?.Invoke(this, EventArgs.Empty);
        }
    }
}
