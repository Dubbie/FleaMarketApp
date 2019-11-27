using FleaMarketApp.Model;
using FleaMarketApp.Presenter;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace FleaMarketApp.View
{
    public partial class OrderStatisticsView : Form, IOrderStatisticsView
    {
        private OrderStatisticsPresenter presenter;

        public OrderStatisticsView()
        {
            InitializeComponent();

            presenter = new OrderStatisticsPresenter(this);
        }

        public DateTime From { 
            get => dateFrom.Value;
            set {
                dateFrom.Value = value;
                dateFrom.MinDate = value;
            }
        }
        public DateTime To { get => dateTo.Value; set => dateTo.Value = value; }
        public Series Series
        {
            set
            {
                Series newSeries = value;
                newSeries.ChartType = SeriesChartType.Pie;
                newSeries.IsVisibleInLegend = false;

                foreach (var point in newSeries.Points)
                {
                    string countLabel = point.YValues[0].ToString() + "db";
                    point.Label = $"{point.AxisLabel} ({countLabel})";
                }

                // Kiürítjük
                chartOrders.Series.Clear();
                chartOrders.Series.Add(newSeries);
            }
        }

        public event EventHandler<EventArgs> BtnUpdateStatistics;

        private void OrderStatisticsView_FormClosed(object sender, FormClosedEventArgs e)
        {
            Owner.Enabled = true;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            BtnUpdateStatistics?.Invoke(this, EventArgs.Empty);
        }
    }
}
