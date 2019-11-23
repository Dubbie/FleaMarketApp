using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FleaMarketApp.View
{
    interface IEditItemView
    {
        decimal ItemId { get; set; }
        string ItemName { get; set; }
        string Description { get; set; }
        decimal? Price { get; set; }
        decimal CategoryId { get; set; }
        decimal StatusId { get; set; }
        bool ItemUpdated { get; set; }

        List<category> Categories { set; }
        List<status> Statuses { set; }

        event EventHandler<EventArgs> UpdateItem;
    }
}
