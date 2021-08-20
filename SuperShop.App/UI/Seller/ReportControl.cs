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
    public partial class ReportControl : UserControl
    {
        InvoiceRepository InvoiceRepository = new InvoiceRepository();
        public ReportControl()
        {
            InitializeComponent();
            loadGridView();
        }

        private void metroPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
       void loadGridView() {
            this.metroGrid1.DataSource = InvoiceRepository.GetAll();


        }
    }
}
