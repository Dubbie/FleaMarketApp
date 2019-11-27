﻿using FleaMarketApp.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FleaMarketApp.Presenter
{
    class ItemOrdersPresenter
    {
        private readonly IItemOrdersView _View;
        private List<item_order> _Orders;

        public ItemOrdersPresenter(IItemOrdersView view)
        {
            _View = view;

            using (var db = new FleaMarketContext())
            {
                _Orders = (from o in db.item_order.Include("item")
                           select o).ToList();
            }

            _View.ItemOrders = _Orders;
            _View.UpdateOrders += UpdateItemOrders;
        }

        private void UpdateItemOrders(object sender, EventArgs args)
        {
            using (var db = new FleaMarketContext())
            {
                _Orders = (from o in db.item_order.Include("item")
                           select o).ToList();
            }

            _View.ItemOrders = _Orders;
        }
    }
}
