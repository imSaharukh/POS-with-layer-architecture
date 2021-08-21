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
    public partial class Statistics : UserControl
    {
        ExtraRepository extraRepository =new ExtraRepository();
        public Statistics()
        {
            InitializeComponent();
          
            this.dtForm.Value = DateTime.Now.AddDays(-30);
            LoadBarChart();
            LoadPiChart();
        }
        void LoadPiChart()
        {
            Func<ChartPoint, string> lablePoint = chartPoint => string.Format("{0} ({1:P})",chartPoint.Y ,chartPoint.Participation);
            SeriesCollection series = new SeriesCollection();
            var result = extraRepository.GetSellersData(dtForm.Value.ToShortDateString(), dtTo.Value.ToShortDateString());
            foreach (var item in result)
            {
                series.Add(new PieSeries() {Title = item.SalesmanUsername,Values = new ChartValues<double> {item.NoOfSales },DataLabels = true, LabelPoint = lablePoint });
                //pieChart.Series["SalesData"].Points.AddXY(item.SalesmanUsername , item.NoOfSales);
            }
            pieChart.Series = series;

        }
       void LoadBarChart() {
            this.lineChart.Series.Clear();
            SeriesCollection series = new SeriesCollection();
            List<double> value =new List<double>();
            List<string> dates = new List<string>();

            var result = extraRepository.GetSealsNumberByDate(dtForm.Value.ToShortDateString(), dtTo.Value.ToShortDateString());
            //value.Add(1);
            //value.Add(2);
            //value.Add(3);
            //value.Add(5);
            foreach (var item in result)
            {
                value.Add(item.TotalSales);
                dates.Add(item.PurchaseDate.ToShortDateString());
                Console.WriteLine("sub total-> "+item.TotalSales);
               
            }
            series.Add(new LineSeries() { Title = "Total Sales", Values = new ChartValues<double>(value) });



            this.lineChart.AxisX.Add(new Axis {Title="Date" ,Labels = dates });
            this.lineChart.Series = series;

        }

        private void barChart_Click(object sender, EventArgs e)
        {

        }
    }
}
