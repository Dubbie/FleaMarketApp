using FleaMarketApp.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FleaMarketApp.Presenter
{
    class NewItemPresenter
    {
        private readonly INewItemView _View;
        private List<category> _Categories;

        public NewItemPresenter(INewItemView view)
        {
            _View = view;

            // Betöltjük a kategóriákat a nézetbe
            using (var db = new FleaMarketContext())
            {
                _Categories = (from c in db.category
                               select c).ToList();
            }

            _View.Categories = _Categories;
            _View.SaveItem += SaveNewItem;
        }

        public void SaveNewItem(object sender, EventArgs e)
        {
            // Státusz eldöntés
            // - 1. (Új) ha nincs ára
            // - 2. (Aktív) ha meg van adva ár
            int checked_status = _View.Price != null ? 2 : 1;

            // Létrehozunk egy új tárgy objektumot
            item newItem = new item
            {
                item_name = _View.ItemName,
                item_description = _View.Description,
                item_price = _View.Price,
                category_id = _View.CategoryId,
                status_id = checked_status, // Az ellenőrzött státusz megadása
                created_at = DateTime.Now,
                modified_at = DateTime.Now,
            };

            // Adatbázisba elmentés
            using (var db = new FleaMarketContext())
            {
                db.item.Add(newItem);
                db.SaveChanges();

                _View.ItemSaved = true;
            }
        }
    }
}
