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
            LoadBarChart();
            LoadPiChart();
        }
        void LoadPiChart()
        {
            var result = extraRepository.GetSellersData();
            foreach (var item in result)
            {
                piChart.Series["SalesData"].Points.AddXY(item.SalesmanUsername , item.NoOfSales);
            }

        }
       void LoadBarChart() {
            this.lineChart.Series.Clear();
            SeriesCollection series = new SeriesCollection();
            List<double> value =new List<double>();

       var result = extraRepository.GetSealsNumberByDate();
            //value.Add(1);
            //value.Add(2);
            //value.Add(3);
            //value.Add(5);
            foreach (var item in result)
            {
                value.Add(item.TotalSales);
                Console.WriteLine("sub total-> "+item.TotalSales);
            }
            series.Add(new LineSeries() { Title = "Total Sales", Values = new ChartValues<double>(value) });

            this.lineChart.Series = series;

        }

        private void barChart_Click(object sender, EventArgs e)
        {

        }
    }
}
