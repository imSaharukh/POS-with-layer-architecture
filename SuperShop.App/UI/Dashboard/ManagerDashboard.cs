using MetroFramework.Forms;
using SuperShop.App.UI.Seller;
using SuperShop.App.UI.Statistics;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuperShop.App.UI.Dashboard
{
    public partial class ManagerDashboard : MetroForm
    {
        AllUsersControl AllUsersControl { get; set; }
        ProductControl ProductControl { get; set; }
        ReportControl ReportControl { get; set; }
        InvoiceControl Invoice { get; set; }
        StatisticsControl statistics { get; set; }

        public ManagerDashboard(string username)
        {
            InitializeComponent();
            AllUsersControl = new AllUsersControl(true);
            ProductControl = new ProductControl();
            ReportControl = new ReportControl();
            Invoice = new InvoiceControl(username);
            statistics = new StatisticsControl();
            showControl(AllUsersControl);
        }
        void showControl(Control control)
        {

            this.managerPanel2.Controls.Clear();
            control.Dock = DockStyle.Fill;
            control.BringToFront();
            control.Focus();
            this.managerPanel2.Controls.Add(control);

        }
        private void ManagerDashboard_Load(object sender, EventArgs e)
        {

        }

        private void btnlogout_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void btnStats_Click(object sender, EventArgs e)
        {
            showControl(statistics);
        }

        private void btnProductlist_Click(object sender, EventArgs e)
        {
            showControl(ProductControl);
        }

        private void btnSalesReport_Click(object sender, EventArgs e)
        {
            showControl(ReportControl);
        }

        private void btnSalesEmp_Click(object sender, EventArgs e)
        {
            showControl(AllUsersControl);
        }

        private void ManagerDashboard_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
