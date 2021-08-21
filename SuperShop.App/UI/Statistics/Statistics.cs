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
            var result = extraRepository.GetSalesData();
            foreach (var item in result)
            {
                piChart.Series["SalesData"].Points.AddXY(item.SalesmanUsername , item.NoOfSales);
            }

        }
       void LoadBarChart() {
            SeriesCollection series = new SeriesCollection();
            //series.Add(new LineSeries() { Title = "1", Values = new ChartValues<double>("1") });
            ////AddXY value in chart1 in series named as Salary  
            //this.lineChart.Series.Add();
            //this.lineChart.Series["Salary"].Points.AddXY("0", "8000");
            //this.lineChart.Series["Salary"].Points.AddXY("Ankit", "7000");
            //this.lineChart.Series["Salary"].Points.AddXY("Gurmeet", "10000");
            //this.lineChart.Series["Salary"].Points.AddXY("Suresh", "8500");
            //this.lineChart.Series["Salary"].Points.AddXY("0", "10000");
            //this.lineChart.Series["Salary"].Points.AddXY("0", "8000");

            
            ////chart title  
            //barChart.Titles.Add("Salary Chart");
        }

        private void barChart_Click(object sender, EventArgs e)
        {

        }
    }
}
