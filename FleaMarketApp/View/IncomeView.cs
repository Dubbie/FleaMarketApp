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
    public partial class IncomeView : Form, IIncomeView
    {
        private IncomePresenter presenter;

        public IncomeView()
        {
            InitializeComponent();

            presenter = new IncomePresenter(this);
        }

        public DateTime From
        {
            get => dateFrom.Value;
            set
            {
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
                newSeries.IsVisibleInLegend = false;
                newSeries.ChartType = SeriesChartType.Line;
                newSeries.IsValueShownAsLabel = true;
                newSeries.LabelFormat = "{0} Ft";
                foreach (DataPoint point in newSeries.Points)
                {
                    string dateLabel = point.AxisLabel;
                    double income = point.YValues[0];
                }

                // Kiürítjük
                chartIncome.Series.Clear();
                chartIncome.Series.Add(newSeries);
                chartIncome.ChartAreas[0].AxisY.LabelStyle.Format = "{0} Ft";
            }
        }

        public event EventHandler<EventArgs> BtnUpdateStatistics;

        private void IncomeView_FormClosed(object sender, FormClosedEventArgs e)
        {
            Owner.Enabled = true;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            BtnUpdateStatistics?.Invoke(null, EventArgs.Empty);
        }
    }
}
