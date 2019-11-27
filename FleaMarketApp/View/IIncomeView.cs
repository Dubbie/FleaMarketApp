using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.DataVisualization.Charting;

namespace FleaMarketApp.View
{
    interface IIncomeView
    {
        DateTime From { get; set; }
        DateTime To { get; set; }
        Series Series { set; }

        event EventHandler<EventArgs> BtnUpdateStatistics;
    }
}
