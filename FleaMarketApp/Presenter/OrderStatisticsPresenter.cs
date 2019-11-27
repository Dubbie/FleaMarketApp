using FleaMarketApp.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.DataVisualization.Charting;

namespace FleaMarketApp.Presenter
{
    class OrderStatisticsPresenter
    {
        private IOrderStatisticsView _View;

        public OrderStatisticsPresenter(IOrderStatisticsView view)
        {
            _View = view;

            using (var db = new FleaMarketContext())
            {
                // Megnézzük mi volt a legelső rendelés dátuma, majd ezt átadjuk a nézetnek
                item_order oldestOrder = (from o in db.item_order
                                          orderby o.ordered_at
                                          select o).First();

                _View.From = oldestOrder.ordered_at;

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
                var orders = (from o in db.item_order
                              where o.ordered_at >= _View.From && o.ordered_at <= _View.To
                              group o by o.item.category.category_name into g
                              select new
                              {
                                  category = g.Key,
                                  count = g.Count()
                              });
                foreach (var order in orders)
                {
                    series.Points.AddXY(order.category, order.count);
                }
            }

            return series;
        }
    }
}
