using FleaMarketApp.View;
using System;
using System.Collections.Generic;
using System.Globalization;
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
        private List<status> _Statuses;

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

                // Gets all the statuses
                _Statuses = (from s in db.status
                               select s).ToList();
            }

            _View.Items = _Items;
            _View.Categories = _Categories;
            _View.Statuses = _Statuses;
            _View.FiltersChanged += UpdateItems;
            _View.ItemSelected += ShowItemDetails;
            _View.BtnNewItemClicked += ShowNewItemView;
            _View.BtnEditItemClicked += ShowEditItemView;
        }

        private void ShowNewItemView(object sender, EventArgs e)
        {
            // Disable this view, open new view
            NewItemView newItemForm = new NewItemView();
            newItemForm.Owner = _View.Form;
            newItemForm.Show();
        }

        private void ShowEditItemView(object sender, EventArgs e)
        {
            // Disable this view, open new view
            EditItemView editItemView = new EditItemView();
            editItemView.Owner = _View.Form;
            editItemView.ItemId = _View.SelectedItem.item_id;
            editItemView.ItemName = _View.SelectedItem.item_name;
            editItemView.Description = _View.SelectedItem.item_description;
            editItemView.Price = _View.SelectedItem.item_price;

            // FONTOS: Adjuk meg először a kategóriákat és a státuszokat
            editItemView.Categories = _Categories;
            editItemView.Statuses = _Statuses;
            // Most már be lehet állítani azonosítókat is
            editItemView.CategoryId = _View.SelectedItem.category.category_id;
            editItemView.StatusId = _View.SelectedItem.status.status_id;
            editItemView.Show();
        }

        private void ShowItemDetails(object sender, EventArgs e)
        {
            _View.DetailItemId = _View.SelectedItem.item_id.ToString();
            _View.DetailItemName = _View.SelectedItem.item_name;
            _View.DetailItemStatus = _View.SelectedItem.status.status_name;
            _View.DetailItemDescription = _View.SelectedItem.item_description;
            _View.DetailItemPrice = _View.SelectedItem.GetFormattedPrice();
            _View.DetailCategory = _View.SelectedItem.category.category_name;
        }

        private void UpdateItems(object sender, EventArgs e)
        {
            using (var db = new FleaMarketContext())
            {
                // Returns all the items we want to list
                _Items = (from i in db.item.Include("category").Include("status")
                          where (i.item_id == _View.FilterItemId || _View.FilterItemId == null)
                          && (i.category_id == _View.FilterCategory.Id || _View.FilterCategory.Id == -1)
                          && (i.status_id == _View.FilterStatus.Id || _View.FilterStatus.Id == -1)
                          && (i.item_name.Contains(_View.FilterItemName))
                          select i).ToList();

                _View.Items = _Items;
            }
        }
    }
}
