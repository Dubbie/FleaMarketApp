using FleaMarketApp.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FleaMarketApp.Presenter
{
    class EditItemPresenter
    {
        private readonly IEditItemView _View;
        private List<category> _Categories;
        private List<status> _Statuses;

        public EditItemPresenter(IEditItemView view)
        {
            _View = view;

            // Load categories into view
            using (var db = new FleaMarketContext())
            {
                _Categories = (from c in db.category
                               select c).ToList();

                _Statuses = (from s in db.status
                             select s).ToList();
            }

            _View.Categories = _Categories;
            _View.Statuses = _Statuses;
            _View.UpdateItem += UpdateItem;
        }

        public void UpdateItem(object sender, EventArgs e)
        {
            // Db-ből kiszedjük ahol az azonosító megegyezik
            using (var db = new FleaMarketContext())
            {
                item foundItem = db.item.Find(_View.ItemId);

                foundItem.item_name = _View.ItemName;
                foundItem.item_description = _View.Description;
                foundItem.category_id = _View.CategoryId;
                foundItem.status_id = _View.StatusId;
                foundItem.modified_at = DateTime.Now;

                if (_View.Price != null)
                {
                    foundItem.item_price = (decimal)_View.Price;
                }

                db.SaveChanges();

                _View.ItemUpdated = true;
            }
        }
    }
}
