using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FleaMarketApp.View
{
    interface INewOrderView
    {
        decimal ItemId { get; set; }
        Form Form { get; }

        string OrdererName { get; }
        string Address { get; }
        string Email { get; }
        string Phone { get; }

        event EventHandler<EventArgs> BtnSaveOrderClicked;
    }
}
