using FleaMarketApp.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FleaMarketApp.Presenter
{
    class NewOrderPresenter
    {
        private readonly INewOrderView _View;

        public NewOrderPresenter(INewOrderView view)
        {
            _View = view;

            _View.BtnSaveOrderClicked += CreateNewItemOrder;
        }

        private void CreateNewItemOrder(object sender, EventArgs e)
        {
            // Létrehozunk egy új megrendelést a jelenlegi dátummal
            item_order order = new item_order()
            {
                item_id = _View.ItemId,
                orderer_name = _View.OrdererName,
                orderer_address = _View.Address,
                orderer_email = _View.Email,
                orderer_phone = _View.Phone,
                ordered_at = DateTime.Now,
            };

            using (var db = new FleaMarketContext())
            {
                // A meglévő tárgy státuszát frissítjük
                item foundItem = db.item.Find(_View.ItemId);
                foundItem.status_id = 3;
                foundItem.modified_at = DateTime.Now;

                // Megrendelést hozzáadjuk
                db.item_order.Add(order);

                // Elmentjük
                db.SaveChanges();

                // Felhasználónak jelzünk
                if (
                    MessageBox.Show(
                        $"Megrendelés sikeresen létrehozva! \nMegrendelési azonosító: {order.order_id}",
                        "Sikeres megrendelés!",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    ) == DialogResult.OK)
                {
                    // Bezárjuk a formunkat
                    _View.Form.Close();
                }
            }
        }
    }
}
