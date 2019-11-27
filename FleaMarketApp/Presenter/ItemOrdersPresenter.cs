using FleaMarketApp.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FleaMarketApp.Presenter
{
    class ItemOrdersPresenter
    {
        private readonly IItemOrdersView _View;
        private List<item_order> _Orders;

        public ItemOrdersPresenter(IItemOrdersView view)
        {
            _View = view;

            using (var db = new FleaMarketContext())
            {
                _Orders = (from o in db.item_order.Include("item")
                           select o).ToList();
            }

            _View.ItemOrders = _Orders;
            _View.UpdateOrders += UpdateItemOrders;
            _View.OrderSelected += ShowOrderDetailsView;
        }

        private void ShowOrderDetailsView(object sender, EventArgs e)
        {
            using (var db = new FleaMarketContext())
            {
                item_order foundOrder = db.item_order.Find(_View.ItemOrderId);

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
                    StatusName = foundOrder.item.status.status_name,

                    OrderItemId = foundOrder.item_id,
                    OrderId = foundOrder.order_id,
                    Owner = _View.Form,
                };

                _View.Form.Enabled = false;
                details.Show();
            }
        }

        private void UpdateItemOrders(object sender, EventArgs args)
        {
            using (var db = new FleaMarketContext())
            {
                _Orders = (from o in db.item_order.Include("item")
                           select o).ToList();
            }

            _View.ItemOrders = _Orders;
        }
    }
}
