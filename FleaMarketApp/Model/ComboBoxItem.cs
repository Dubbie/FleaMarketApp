﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FleaMarketApp.Model
{
    public class ComboBoxItem
    {
        public decimal Id { get; set; }
        public string Text { get; set; }

        public override string ToString()
        {
            return Text;
        }
    }
}
