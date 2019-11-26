using FleaMarketApp.Helper;
using FleaMarketApp.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FleaMarketApp.Presenter
{
    public class OrderDetailsPresenter
    {
        private readonly IOrderDetailsView _View;
        private readonly bool _Admin;

        public OrderDetailsPresenter(IOrderDetailsView view)
        {
            _View = view;

            _Admin = Auth.IsAdminUser();

            _View.BtnCancelOrderClicked += CancelOrder;
            _View.BtnSellItemClicked += SellOrderedItem;
        }

        public void CancelOrder(object sender, EventArgs args)
        {
            // Töröljük az adatbázisból a megrendelést
            using (var db = new FleaMarketContext())
            {
                item_order order = db.item_order.Find(_View.ItemOrder.order_id);
                db.item_order.Remove(order);

                db.SaveChanges();
            }

            _View.Form.Close();
        }

        public void SellOrderedItem(object sender, EventArgs args)
        {
            // Frissítsük az adatbázisban a tárgyat
            using (var db = new FleaMarketContext())
            {
                item item = db.item_order.Find(_View.ItemOrder.order_id).item;
                item.status_id = 4;

                db.SaveChanges();
            }

            _View.Form.Close();
        }
    }
}
