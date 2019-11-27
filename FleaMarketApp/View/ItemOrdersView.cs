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
        private ItemOrdersPresenter presenter;

        public event EventHandler<EventArgs> UpdateOrders;
        public event EventHandler<EventArgs> OrderSelected;

        public ItemOrdersView()
        {
            InitializeComponent();

            presenter = new ItemOrdersPresenter(this);
        }

        public List<item_order> ItemOrders
        {
            set
            {
                gridItemOrders.Rows.Clear();
                foreach (item_order order in value)
                {
                    int rowIndex = gridItemOrders.Rows.Add();
                    gridItemOrders.Rows[rowIndex].Cells["OrderId"].Value = order.order_id;
                    gridItemOrders.Rows[rowIndex].Cells["ItemName"].Value = order.item.item_name;
                    gridItemOrders.Rows[rowIndex].Cells["OrderedAt"].Value = order.ordered_at;
                    gridItemOrders.Rows[rowIndex].Cells["Orderer"].Value = order.orderer_name;
                    gridItemOrders.Rows[rowIndex].Cells["Sold"].Value = order.item.status_id == 4 ? "Igen" : "Nem";
                }
            }
        }

        public decimal ItemOrderId { get; set; }

        public Form Form => this;

        private void ItemOrdersView_FormClosed(object sender, FormClosedEventArgs e)
        {
            Owner.Enabled = true;
        }

        private void ItemOrdersView_EnabledChanged(object sender, EventArgs e)
        {
            // Update list
            UpdateOrders?.Invoke(this, EventArgs.Empty);
        }

        private void GridItemOrders_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                ItemOrderId = decimal.Parse(gridItemOrders.SelectedRows[0].Cells["OrderId"].Value.ToString());

                OrderSelected?.Invoke(this, EventArgs.Empty);
            }
        }
    }
}
