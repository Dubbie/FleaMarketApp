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

        public OrderDetailsPresenter(IOrderDetailsView view)
        {
            _View = view;
            _View.BtnCancelOrderClicked += CancelOrder;
        }

        public void CancelOrder(object sender, EventArgs args)
        {
            Console.WriteLine(_View.ItemOrder.order_id);
            // Töröljük az adatbázisból a megrendelést
            using (var db = new FleaMarketContext())
            {
                item_order order = db.item_order.Find(_View.ItemOrder.order_id);
                db.item_order.Remove(order);

                db.SaveChanges();
            }

            _View.Form.Close();
        }
    }
}
