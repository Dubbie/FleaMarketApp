using FleaMarketApp.Helper;
using FleaMarketApp.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FleaMarketApp.Presenter
{
    class OrderDetailsPresenter
    {
        private readonly IOrderDetailsView _View;
        private readonly bool _Admin;

        public OrderDetailsPresenter(IOrderDetailsView view)
        {
            _View = view;

            _Admin = Auth.IsAdminUser();

            _View.Admin = _Admin;
            _View.BtnCancelOrderClicked += CancelOrder;
            _View.BtnSellItemClicked += SellOrderedItem;
        }

        public void CancelOrder(object sender, EventArgs args)
        {
            using (var db = new FleaMarketContext())
            {
                // Töröljük az adatbázisból a megrendelést
                item_order foundOrder = db.item_order.Find(_View.OrderId);
                db.item_order.Remove(foundOrder);

                // Állítsuk át a státuszt is
                item foundItem = db.item.Find(_View.OrderItemId);
                foundItem.status_id = 2;
                foundItem.modified_at = DateTime.Now;

                // Mentsük
                db.SaveChanges();
            }

            _View.Form.Close();
        }

        public void SellOrderedItem(object sender, EventArgs args)
        {
            // Frissítsük az adatbázisban a tárgyat
            using (var db = new FleaMarketContext())
            {
                item item = db.item_order.Find(_View.OrderId).item;
                item.status_id = 4;
                item.modified_at = DateTime.Now;

                db.SaveChanges();
            }

            _View.Form.Close();
        }
    }
}
