using FleaMarketApp.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FleaMarketApp.Presenter
{
    class MainMarketPresenter
    {
        private readonly IMainMarketView _View;
        private List<item> _Items;
        private List<category> _Categories;

        public MainMarketPresenter(IMainMarketView view)
        {
            _View = view;
            
            using (var db = new FleaMarketContext())
            {
                // Returns all the items we want to list
                _Items = (from i in db.item
                              select i).ToList();

                // Gets all the categories
                _Categories = (from c in db.category
                               select c).ToList();
            }

            _View.Items = _Items;
            _View.Categories = _Categories;
            _View.FiltersChanged += UpdateItems;
            _View.ItemSelected += ShowItemDetails;
        }

        private void ShowItemDetails(object sender, EventArgs e)
        {
            _View.DetailItemId = _View.SelectedItem.item_id.ToString();
            _View.DetailItemName = _View.SelectedItem.item_name;
            _View.DetailItemDescription = _View.SelectedItem.item_description;
            _View.DetailItemPrice = $"{_View.SelectedItem.item_price.ToString()} ft";
            _View.DetailCategory = _View.SelectedItem.category.category_name;
        }

        private void UpdateItems(object sender, EventArgs e)
        {
            using (var db = new FleaMarketContext())
            {
                // Returns all the items we want to list
                Console.WriteLine("-- Debug: --");
                Console.WriteLine("--- Filtered items:");

                // Handles category combo box
                _Items = (from i in db.item
                          where (i.item_id == _View.FilterItemId || _View.FilterItemId == null)
                          && (i.category_id == _View.FilterCategory.Id || _View.FilterCategory.Id == -1)
                          && (i.item_name.Contains(_View.FilterItemName))
                          select i).ToList();

                foreach (item item in _Items)
                {
                    Console.WriteLine($"{item.item_id} - {item.item_name} ({item.item_price}ft)");
                }

                _View.Items = _Items;
            }
        }
    }
}
