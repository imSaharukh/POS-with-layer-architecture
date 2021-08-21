using MetroFramework.Forms;
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
        InvoiceRepository invoiceRepository = new InvoiceRepository();
        public InvoiceProductList(string invoice)
        {
            InitializeComponent();
            loadGridView(invoice);
        }
        void loadGridView(string invoice)
        {
            this.dgvInvoice.DataSource = invoiceRepository.GetAllInvoiceProduct(invoice);
        }
        private void InvoiceProductList_Load(object sender, EventArgs e)
        {

        }

        private void dgvInvoice_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
