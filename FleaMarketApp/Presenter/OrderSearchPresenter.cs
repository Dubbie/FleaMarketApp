using FleaMarketApp.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FleaMarketApp.Presenter
{
    public class OrderSearchPresenter
    {
        public IOrderSearchView _View;

        public OrderSearchPresenter(IOrderSearchView view)
        {
            _View = view;

            _View.BtnSearchClicked += SearchOrder;
        }

        private void SearchOrder(object sender, EventArgs e)
        {
            if (_View.ItemOrderId != -1)
            {
                // Megnézzük, hogy létezik-e a megrendelés az azonosító alapján
                using (var db = new FleaMarketContext())
                {
                    item_order foundOrder = db.item_order.Find(_View.ItemOrderId);

                    if (foundOrder == null)
                    {
                        MessageBox.Show("Nem található az adatbázisban megrendelés ezzel az azonosítóval!", "Keresési hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    } else
                    {
                        // Hozzuk létre a részletes nézetet a megrendeléshez
                        OrderDetailsView newView = new OrderDetailsView()
                        {
                            OrderedAt = foundOrder.ordered_at,
                            ItemName = foundOrder.item.item_name,
                            ItemPrice = foundOrder.item.GetFormattedPrice(),
                            OrdererAddress = foundOrder.orderer_address,
                            OrdererEmail = foundOrder.orderer_email,
                            OrdererName = foundOrder.orderer_name,
                            OrdererPhone = foundOrder.orderer_phone,
                            StatusId = foundOrder.item.status_id,

                            OrderItemId = foundOrder.item_id,
                            OrderId = foundOrder.order_id,
                            Owner = _View.Form
                        };
                        _View.Form.Enabled = false;
                        newView.Show();
                    }
                }
            }
        }
    }
}
