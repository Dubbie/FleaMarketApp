﻿using FleaMarketApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FleaMarketApp.View
{
    interface IMainMarketView
    {
        Form Form { get; }

        bool Admin { get; set; }
        List<item> Items { set; }
        item SelectedItem { get; }
        int? FilterItemId { get; }
        string FilterItemName { get; }
        ComboBoxItem FilterCategory { get; }
        ComboBoxItem FilterStatus { get; }
        decimal? FilterPriceMin { get; }
        decimal? FilterPriceMax { get; }

        string DetailItemId { set; }
        string DetailItemName { set; }
        string DetailItemStatus { set; }
        string DetailItemDescription { set; }
        string DetailItemPrice { set; }
        string DetailCategory { set; }
        string DetailCreatedAt { set; }
        string DetailModifiedAt { set; }
        List<category> Categories { set; }
        List<status> Statuses { set; }

        // Események
        event EventHandler<EventArgs> ItemSelected;
        event EventHandler<EventArgs> FiltersChanged;
        event EventHandler<EventArgs> BtnNewItemClicked;
        event EventHandler<EventArgs> BtnEditItemClicked;
        event EventHandler<EventArgs> BtnItemOrdersClicked;
        event EventHandler<EventArgs> BtnMakeOrderClicked;
        event EventHandler<EventArgs> BtnCancelOrderClicked;
        event EventHandler<EventArgs> BtnShowOrderClicked;
        event EventHandler<EventArgs> BtnOfferItemClicked;
        event EventHandler<EventArgs> BtnSellClicked;
        event EventHandler<EventArgs> BtnOrderStatisticsClicked;
        event EventHandler<EventArgs> BtnShowIncomeClicked;
    }
}
