using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FleaMarketApp.View
{
    interface INewItemView
    {
        string ItemName { get; }
        string Description { get; }
        decimal Price { get; }
        decimal CategoryId { get; }
        bool ItemSaved { get; set; }

        List<category> Categories { set; }

        event EventHandler<EventArgs> SaveItem;
    }
}
