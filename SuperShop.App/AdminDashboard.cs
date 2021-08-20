using MetroFramework.Forms;
using SuperShop.App.UI.Seller;
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

namespace SuperShop.App
{
    public partial class AdminDashboard : MetroForm
    {
        AllUsersControl allUsersControl = new AllUsersControl();
        ProductControl productControl = new ProductControl();
        ReportControl reportControl = new ReportControl();
        Invoice invoice = new Invoice();
        public AdminDashboard()
        {
            InitializeComponent();
            showControll(allUsersControl);
        }

    

        private void AdminDashboard_Load(object sender, EventArgs e)
        {

        }
        
        private void metroPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
        void showControll(Control control) {

            this.displayPanel.Controls.Clear();
            control.Dock = DockStyle.Fill;
            control.BringToFront();
            control.Focus();
            this.displayPanel.Controls.Add(control);
        
        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            //AllUsersControl allUsersControl = new AllUsersControl();
            showControll(allUsersControl);
        }
        void showProuductControl(Control control2)
        {

            this.displayPanel.Controls.Clear();
            control2.Dock = DockStyle.Fill;
            control2.BringToFront();
            control2.Focus();
            this.displayPanel.Controls.Add(control2);

        }

        private void btnProduct_Click(object sender, EventArgs e)
        {
       
            showProuductControl(productControl);
        }
        void showReportControl(Control control3)
        {
            this.displayPanel.Controls.Clear();
            control3.Dock = DockStyle.Fill;
            control3.BringToFront();
            control3.Focus();
            this.displayPanel.Controls.Add(control3);
        }

        private void btnSalesReport_Click(object sender, EventArgs e)
        {
            showReportControl(reportControl);
        }

        private void btnSales_Click(object sender, EventArgs e)
        {
            showReportControl(invoice);
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            UI.MiniStatement.SalesSlip salesSlip = new UI.MiniStatement.SalesSlip();
            salesSlip.Show();
        }
    }
}
