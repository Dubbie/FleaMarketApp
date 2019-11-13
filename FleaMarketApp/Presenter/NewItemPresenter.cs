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

            // Load categories into view
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
            // Creates the new item object
            item newItem = new item
            {
                item_name = _View.ItemName,
                item_description = _View.Description,
                item_price = _View.Price,
                category_id = _View.CategoryId,
                status_id = 2, // Aktív status
                created_at = DateTime.Now,
                modified_at = DateTime.Now,
            };

            // Adds to database
            using (var db = new FleaMarketContext())
            {
                db.item.Add(newItem);
                db.SaveChanges();

                _View.ItemSaved = true;
            }
        }
    }
}
