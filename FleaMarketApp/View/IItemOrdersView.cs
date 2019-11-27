using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FleaMarketApp.View
{
    interface IItemOrdersView
    {
        List<item_order> ItemOrders { set; }
        Form Form { get; }
        decimal ItemOrderId { get; set; }

        event EventHandler<EventArgs> UpdateOrders;
        event EventHandler<EventArgs> OrderSelected;
    }
}
