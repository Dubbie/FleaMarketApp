﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FleaMarketApp.View
{
    public interface IItemOrdersView
    {
        List<item_order> ItemOrders { set; }
    }
}