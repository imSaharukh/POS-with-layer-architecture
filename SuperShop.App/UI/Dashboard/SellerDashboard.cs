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
        InvoiceForm invoiceForm { get; set; }
        ReportControl reportControl { get; set; }
        public SellerDashboard(string Username)
        {
            InitializeComponent();
            invoiceForm = new InvoiceForm(Username);
            reportControl = new ReportControl();
            showControl(invoiceForm);
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
            showReportControl(reportControl);
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
            
            showControl(invoiceForm);
           // invoiceForm.Show();


        }
    }
}
