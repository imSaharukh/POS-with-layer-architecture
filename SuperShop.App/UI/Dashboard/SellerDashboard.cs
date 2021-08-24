using MetroFramework.Forms;
using SuperShop.App.UI.Seller;
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

    public partial class SellerDashboard : MetroForm
    {
        string Username { get; set; }
        InvoiceControl InvoiceForm { get; set; }
        ReportControl ReportControl { get; set; }
        public SellerDashboard(string Username)
        {
            InitializeComponent();
            InvoiceForm = new InvoiceControl(Username);
            ReportControl = new ReportControl();
            this.Username = Username;
            showControl(InvoiceForm);
        }

        private void SellerDashboard_Load(object sender, EventArgs e)
        {

        }
        void showReportControl(Control control3)
        {
            this.Salesdisplay.Controls.Clear();
            control3.Dock = DockStyle.Fill;
            control3.BringToFront();
            control3.Focus();
            this.Salesdisplay.Controls.Add(control3);
        }
        private void btnSalesReport_Click(object sender, EventArgs e)
        {
            ReportControl = new ReportControl(Username);
            showReportControl(ReportControl);
        }
        void showControl(Control control)
        {

            this.Salesdisplay.Controls.Clear();
            control.Dock = DockStyle.Fill;
            control.BringToFront();
            control.Focus();
            this.Salesdisplay.Controls.Add(control);

        }

        private void btnSales_Click(object sender, EventArgs e)
        {
            
            showControl(InvoiceForm);
           // invoiceForm.Show();


        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void SellerDashboard_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
