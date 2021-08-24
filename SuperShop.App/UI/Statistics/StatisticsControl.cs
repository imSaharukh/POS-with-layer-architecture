using LiveCharts;
using LiveCharts.Wpf;
using SuperShop.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuperShop.App.UI.Statistics
{
    public partial class StatisticsControl : UserControl
    {
        ExtraRepository extraRepository =new ExtraRepository();
        public StatisticsControl()
        {
            InitializeComponent();
          
            this.dtForm.Value = DateTime.Now.AddDays(-30);
            LoadBarChart();
            LoadPiChart();
            TotalSales();
        }
        void TotalSales()
        {
            var result = extraRepository.GetSalesAmountByDate(dtForm.Value.ToShortDateString(), dtTo.Value.ToShortDateString());
            this.lblTotalSales.Text = result.ToString()+" TK";
        }
        void LoadPiChart()
        {
            Func<ChartPoint, string> lablePoint = chartPoint => string.Format("{0} ({1:P})",chartPoint.Y ,chartPoint.Participation);
            SeriesCollection series = new SeriesCollection();
            try
            {
                var result = extraRepository.GetSellersData(dtForm.Value.ToShortDateString(), dtTo.Value.ToShortDateString());
                foreach (var item in result)
                {
                    series.Add(new PieSeries() { Title = item.SalesmanUsername, Values = new ChartValues<double> { item.NoOfSales }, DataLabels = true, LabelPoint = lablePoint });
                    //pieChart.Series["SalesData"].Points.AddXY(item.SalesmanUsername , item.NoOfSales);
                }
            }
            catch(Exception e)
            {
                MessageBox.Show("Something went wrong in the database", "Error!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            pieChart.Series = series;

        }
       void LoadBarChart() {
            this.lineChart.Series.Clear();
            SeriesCollection series = new SeriesCollection();
            List<double> value =new List<double>();
            List<string> dates = new List<string>();

            try
            {
                var result = extraRepository.GetSealsNumberByDate(dtForm.Value.ToShortDateString(), dtTo.Value.ToShortDateString());

                foreach (var item in result)
                {
                    value.Add(item.TotalSales);
                    dates.Add(item.PurchaseDate.ToShortDateString());
                    Console.WriteLine("sub total-> " + item.TotalSales);

                }
            }
            catch(Exception err1)
            {
                MessageBox.Show("Something went wrong in the database", "Error!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            series.Add(new LineSeries() { Title = "Total Sales", Values = new ChartValues<double>(value) });


            this.lineChart.AxisX.Clear();
            this.lineChart.AxisX.Add(new Axis {Title="Date" ,Labels = dates });
            this.lineChart.Series = series;

        }

        private void barChart_Click(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            LoadBarChart();
            LoadPiChart();
            TotalSales();
        }
    }
}
