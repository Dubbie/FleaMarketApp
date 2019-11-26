using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FleaMarketApp.View
{
    public interface IOfferItemView
    {
        decimal ItemId { get; set; }
        Form Form { get; }
        double Price { get; }

        event EventHandler<EventArgs> BtnOfferClicked;
    }
}
