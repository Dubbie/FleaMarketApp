using FleaMarketApp.View;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.DataVisualization.Charting;

namespace FleaMarketApp.Presenter
{
    class IncomePresenter
    {
        private readonly IIncomeView _View;

        public IncomePresenter(IIncomeView view)
        {
            _View = view;

            using (var db = new FleaMarketContext())
            {
                // Megnézzük mi volt a legelső rendelés dátuma, majd ezt átadjuk a nézetnek
                item_order oldestSale = (from o in db.item_order
                                         where o.item.status_id == 4
                                         orderby o.ordered_at
                                         select o).First();

                _View.From = oldestSale.ordered_at;

                // Megcsináljuk az adathalmazt amit látni szeretnénk
                _View.Series = GetFilteredSeries();
            }

            _View.BtnUpdateStatistics += UpdateChart;
        }

        private void UpdateChart(object sender, EventArgs e)
        {
            Series newSeries = GetFilteredSeries();
            _View.Series = newSeries;
        }

        private Series GetFilteredSeries()
        {
            Series series = new Series();
            using (var db = new FleaMarketContext())
            {
                // Adjuk hozzá azokat amik a From előtt vannak, ha vannak
                var total = (from o in db.item_order
                             where o.ordered_at < _View.From && o.item.status_id == 4
                             group o by o.order_id into g
                             select new
                             {
                                 total = g.Sum(i => (decimal)i.item.item_price)
                             }).FirstOrDefault();

                // Összes bevétel a megadott From dátumig
                decimal totalIncome = total != null ? total.total : 0;

                // Hozzáadjuk azokat amiket találtunk a Fromtól kezdve
                var orders = (from o in db.item_order
                              where o.ordered_at >= _View.From && o.ordered_at <= _View.To && o.item.status_id == 4
                              let dt = DbFunctions.TruncateTime(o.ordered_at)
                              group o by dt into g
                              select new
                              {
                                  income = g.Sum(i => (decimal)i.item.item_price),
                                  date = g.Key
                              }).ToList();
                foreach (var order in orders)
                {
                    totalIncome += order.income;
                    series.Points.AddXY(order.date.Value.ToString("yyyy MMM dd"), totalIncome);
                }
            }

            return series;
        }
    }
}
