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
    public partial class ProductList : MetroForm
    {
        InvoiceRepository InvoiceRepository = new InvoiceRepository();
        public ProductList(string invoice)
        {
            InitializeComponent();
            loadGridView(invoice);
        }

        void loadGridView(string invoice)
        {
            this.dgvInvoice.DataSource = InvoiceRepository.GetAllInvoiceProduct(invoice);
        }
        private void ViewInvoiceProductList_Load(object sender, EventArgs e)
        {

        }

        private void dgvInvoice_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
