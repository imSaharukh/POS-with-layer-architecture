using MetroFramework.Forms;
using SuperShop.Entity;
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

namespace SuperShop.App.UI.Seller
{
    public partial class InvoiceProductList : MetroForm
    {

        List<InvoiceProduct> Invoice { get; set; }
        public InvoiceProductList(List<InvoiceProduct> invoice)
        {
            InitializeComponent();
            this.Invoice = invoice;
           
        }
        void loadGridView()
        {
            try {
                this.dgvInvoice.DataSource = Invoice;
            }
            catch(Exception err) { MessageBox.Show("Something went wrong in the database", "Error!!", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
        private void InvoiceProductList_Load(object sender, EventArgs e)
        {
            loadGridView();
        }


        private void dgvInvoice_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
