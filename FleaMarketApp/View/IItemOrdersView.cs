using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FleaMarketApp.View
{
    interface IItemOrdersView
    {
        List<item_order> ItemOrders { set; }

        event EventHandler<EventArgs> UpdateOrders;
    }
}
