using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FleaMarketApp.View
{
    interface IOrderDetailsView
    {
        decimal OrderId { get; set; }
        string ItemName { set; }
        string ItemPrice { set; }
        DateTime OrderedAt { get; set; }
        decimal OrderItemId { get; set; }

        string OrdererName { set; }
        string OrdererAddress { set; }
        string OrdererEmail { set; }
        string OrdererPhone { set; }

        decimal StatusId { get; set; }
        string StatusName { set; }

        Form Form { get; }
        bool Admin { get; set; }

        event EventHandler<EventArgs> BtnSellItemClicked;
        event EventHandler<EventArgs> BtnCancelOrderClicked;
    }
}
