using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FleaMarketApp.View
{
    public interface IOrderDetailsView
    {
        item_order ItemOrder { get; set; }

        Form Form { get; }

        event EventHandler<EventArgs> BtnSellItemClicked;
        event EventHandler<EventArgs> BtnCancelOrderClicked;
    }
}
