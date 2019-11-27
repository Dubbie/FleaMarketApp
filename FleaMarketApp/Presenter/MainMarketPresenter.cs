using FleaMarketApp.Helper;
using FleaMarketApp.View;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FleaMarketApp.Presenter
{
    class MainMarketPresenter
    {
        private readonly IMainMarketView _View;
        private List<item> _Items;
        private List<category> _Categories;
        private List<status> _Statuses;
        private readonly bool _Admin;

        public MainMarketPresenter(IMainMarketView view)
        {
            _View = view;
            _Admin = Auth.IsAdminUser();

            using (var db = new FleaMarketContext())
            {
                // Kiszedjük az összes tárgyat ami éppen releváns
                if (_Admin == true)
                {
                    _Items = (from i in db.item
                              select i).ToList();
                }
                else
                {
                    _Items = (from i in db.item
                              where i.status_id == 2
                              select i).ToList();
                }


                // Gets all the categories
                _Categories = (from c in db.category
                               select c).ToList();

                // Gets all the statuses
                _Statuses = (from s in db.status
                             select s).ToList();
            }

            _View.Items = _Items;
            _View.Admin = _Admin;
            _View.Categories = _Categories;
            _View.Statuses = _Statuses;

            // Események
            _View.FiltersChanged += UpdateItems;
            _View.ItemSelected += ShowItemDetails;
            _View.BtnNewItemClicked += ShowNewItemView;
            _View.BtnEditItemClicked += ShowEditItemView;
            _View.BtnItemOrdersClicked += ShowItemOrdersView;
            _View.BtnMakeOrderClicked += OrderItem;
            _View.BtnCancelOrderClicked += CancelOrder;
            _View.BtnShowOrderClicked += ShowOrder;
            _View.BtnOfferItemClicked += ShowOfferView;
            _View.BtnSellClicked += SellItem;
            _View.BtnOrderStatisticsClicked += ShowOrderStatisticsView;
        }

        private void ShowOrderStatisticsView(object sender, EventArgs e)
        {
            _View.Form.Enabled = false;

            // Létrehozzuk a view-t
            OrderStatisticsView view = new OrderStatisticsView
            {
                Owner = _View.Form
            };
            view.Show();
        }

        private void SellItem(object sender, EventArgs e)
        {
            _View.Form.Enabled = false;

            // Átírjuk a terméket eladottra
            using (var db = new FleaMarketContext())
            {
                item foundItem = db.item.Find(_View.SelectedItem.item_id);
                foundItem.status_id = 4;
                foundItem.modified_at = DateTime.Now;
                db.SaveChanges();
            }

            if (MessageBox.Show("Termék sikeresen eladva!", "Termék eladva", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
            {
                _View.Form.Enabled = true;
            }
        }

        private void ShowOfferView(object sender, EventArgs e)
        {
            OfferItemView offerItemView = new OfferItemView
            {
                ItemId = _View.SelectedItem.item_id,
                Owner = _View.Form
            };
            offerItemView.Show();
        }

        private void ShowOrder(object sender, EventArgs e)
        {
            OrderSearchView view = new OrderSearchView
            {
                Owner = _View.Form
            };
            view.Show();
        }

        private void CancelOrder(object sender, EventArgs e)
        {
            if (
                MessageBox.Show(
                    "Biztosan törölni szeretné a termékhez tartozó megrendelést? Ez a folyamat nem visszafordítható.",
                    "Megrendelés törlése",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                ) == DialogResult.Yes)
            {
                using (var db = new FleaMarketContext())
                {
                    item foundItem = db.item.Find(_View.SelectedItem.item_id);
                    item_order foundOrder = foundItem.item_order.First();

                    // Töröljük a megrendelést
                    db.item_order.Remove(foundOrder);

                    // Átállítjuk a termék státuszát, módosítás dátumát frissítjük
                    foundItem.status_id = 2;
                    foundItem.modified_at = DateTime.Now;

                    // Elmentjük
                    db.SaveChanges();
                }
            }

            _View.Form.Enabled = true;
        }

        private void OrderItem(object sender, EventArgs e)
        {
            // Létrehozzuk az új megrendelés nézetet
            NewOrderView newOrderView = new NewOrderView
            {
                Owner = _View.Form,
                ItemId = _View.SelectedItem.item_id
            };
            newOrderView.Show();
        }

        private void ShowNewItemView(object sender, EventArgs e)
        {
            // Ezt a nézetet inaktívvá tesszük, megnyitjuk az új nézetet
            NewItemView newItemForm = new NewItemView
            {
                Owner = _View.Form
            };
            newItemForm.Show();
        }

        private void ShowEditItemView(object sender, EventArgs e)
        {
            // Ezt a nézetet inaktívvá tesszük, megnyitjuk az új nézetet
            EditItemView editItemView = new EditItemView
            {
                Owner = _View.Form,
                ItemId = _View.SelectedItem.item_id,
                ItemName = _View.SelectedItem.item_name,
                Description = _View.SelectedItem.item_description,
                Price = _View.SelectedItem.item_price,
                CategoryId = _View.SelectedItem.category.category_id,
                StatusId = _View.SelectedItem.status.status_id
            };
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
            _View.DetailCreatedAt = "Hozzáadva: " + _View.SelectedItem.created_at.ToString("yyyy MMM d, HH:mm");
            _View.DetailModifiedAt = _View.SelectedItem.modified_at != null ?
                "Módosítva: " + _View.SelectedItem.modified_at.ToString("yyyy MMM d, HH:mm") :
                "Nem volt módosítva";
        }

        private void ShowItemOrdersView(object sender, EventArgs e)
        {
            // Ezt a nézetet inaktívvá tesszük, megnyitjuk az új nézetet
            ItemOrdersView view = new ItemOrdersView
            {
                Owner = _View.Form
            };
            view.Show();
        }

        private void UpdateItems(object sender, EventArgs e)
        {
            using (var db = new FleaMarketContext())
            {
                // Visszaadjuk a listából az összes megfelelt tárgyat
                if (_Admin == true)
                {
                    _Items = (from i in db.item.Include("category").Include("status")
                              where (i.item_id == _View.FilterItemId || _View.FilterItemId == null)
                              && (i.category_id == _View.FilterCategory.Id || _View.FilterCategory.Id == -1)
                              && (i.status_id == _View.FilterStatus.Id || _View.FilterStatus.Id == -1)
                              && (i.item_name.Contains(_View.FilterItemName))
                              && (_View.FilterPriceMin == null || (i.item_price >= _View.FilterPriceMin))
                              && (_View.FilterPriceMax == null || (i.item_price <= _View.FilterPriceMax))
                              select i).ToList();
                }
                else
                {
                    _Items = (from i in db.item.Include("category").Include("status")
                              where (i.item_id == _View.FilterItemId || _View.FilterItemId == null)
                              && (i.category_id == _View.FilterCategory.Id || _View.FilterCategory.Id == -1)
                              && i.status_id == 2
                              && (i.item_name.Contains(_View.FilterItemName))
                              && (_View.FilterPriceMin == null || (i.item_price >= _View.FilterPriceMin))
                              && (_View.FilterPriceMax == null || (i.item_price <= _View.FilterPriceMax))
                              select i).ToList();
                }


                _View.Items = _Items;
            }
        }
    }
}
