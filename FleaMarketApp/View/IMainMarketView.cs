using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FleaMarketApp.View
{
    interface IMainMarketView
    {
        List<item> Items { set; }
        item SelectedItem { get; }
        int? FilterItemId { get; }
        string FilterItemName { get; }

        string DetailItemId { set; }
        string DetailItemName { set; }
        string DetailItemDescription { set; }
        string DetailItemPrice { set; }

        event EventHandler<EventArgs> ItemSelected;
        event EventHandler<EventArgs> FiltersChanged;
    }
}
