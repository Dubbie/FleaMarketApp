using FleaMarketApp.Model;
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
        Form Form {get;}
        List<item> Items { set; }
        item SelectedItem { get; }
        int? FilterItemId { get; }
        string FilterItemName { get; }
        ComboBoxItem FilterCategory { get; }

        string DetailItemId { set; }
        string DetailItemName { set; }
        string DetailItemDescription { set; }
        string DetailItemPrice { set; }
        string DetailCategory { set; }
        List<category> Categories { set; }

        event EventHandler<EventArgs> ItemSelected;
        event EventHandler<EventArgs> FiltersChanged;
        event EventHandler<EventArgs> BtnNewItemClicked;
    }
}
