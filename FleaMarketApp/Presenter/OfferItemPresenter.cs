using FleaMarketApp.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FleaMarketApp.Presenter
{
    public class OfferItemPresenter
    {
        private readonly IOfferItemView _View;

        public OfferItemPresenter(IOfferItemView view)
        {
            _View = view;

            _View.BtnOfferClicked += UpdateItem;
        }

        private void UpdateItem(object sender, EventArgs e)
        {
            using (var db = new FleaMarketContext())
            {
                item foundItem = db.item.Find(_View.ItemId);

                // Frissítjük az adatokat
                foundItem.item_price = (decimal?)_View.Price;
                foundItem.status_id = 2;
                foundItem.modified_at = DateTime.Now;
                db.SaveChanges();

                // Alert, utána bezárjuk a formot
                MessageBox.Show("Termék sikeresen eladásra bocsájtva!", "Sikeres termék eladásra bocsájtás", MessageBoxButtons.OK, MessageBoxIcon.Information);
                _View.Form.Close();
            }
        }
    }
}
