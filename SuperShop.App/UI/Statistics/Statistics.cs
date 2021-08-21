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
        public Statistics()
        {
            InitializeComponent();
            LoadBarChart();
        }
       void LoadBarChart() {

            //AddXY value in chart1 in series named as Salary  
            barChart.Series["Salary"].Points.AddXY("0", "10000");
            barChart.Series["Salary"].Points.AddXY("0", "8000");
            barChart.Series["Salary"].Points.AddXY("Ankit", "7000");
            barChart.Series["Salary"].Points.AddXY("Gurmeet", "10000");
            barChart.Series["Salary"].Points.AddXY("Suresh", "8500");
            barChart.Series["Salary"].Points.AddXY("0", "10000");
            barChart.Series["Salary"].Points.AddXY("0", "8000");
            barChart.Series["Salary"].Points.AddXY("Ankit", "7000");
            barChart.Series["Salary"].Points.AddXY("Gurmeet", "10000");
            barChart.Series["Salary"].Points.AddXY("Suresh", "8500");
            barChart.Series["Salary"].Points.AddXY("0", "10000");
            barChart.Series["Salary"].Points.AddXY("0", "8000");
            barChart.Series["Salary"].Points.AddXY("Ankit", "7000");
            barChart.Series["Salary"].Points.AddXY("Gurmeet", "10000");
            barChart.Series["Salary"].Points.AddXY("Suresh", "8500");
            barChart.Series["Salary"].Points.AddXY("0", "10000");
            barChart.Series["Salary"].Points.AddXY("0", "8000");
            barChart.Series["Salary"].Points.AddXY("Ankit", "7000");
            barChart.Series["Salary"].Points.AddXY("Gurmeet", "10000");
            barChart.Series["Salary"].Points.AddXY("Suresh", "8500");
            barChart.Series["Salary"].Points.AddXY("Gurmeet", "10000");
            barChart.Series["Salary"].Points.AddXY("Suresh", "8500");
            barChart.Series["Salary"].Points.AddXY("0", "10000");
            barChart.Series["Salary"].Points.AddXY("0", "8000");
            barChart.Series["Salary"].Points.AddXY("Ankit", "7000");
            barChart.Series["Salary"].Points.AddXY("Gurmeet", "10000");
            barChart.Series["Salary"].Points.AddXY("Suresh", "8500");
            barChart.Series["Salary"].Points.AddXY("0", "10000");
            barChart.Series["Salary"].Points.AddXY("0", "8000");
            barChart.Series["Salary"].Points.AddXY("Ankit", "7000");
            barChart.Series["Salary"].Points.AddXY("Gurmeet", "10000");
            barChart.Series["Salary"].Points.AddXY("Suresh", "8500");
            //chart title  
            barChart.Titles.Add("Salary Chart");
        }

        private void barChart_Click(object sender, EventArgs e)
        {

        }
    }
}
