using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FleaMarketApp.View
{
    interface IOrderSearchView
    {
        decimal ItemOrderId { get; set; }
        Form Form { get; }

        event EventHandler<EventArgs> BtnSearchClicked;
    }
}
