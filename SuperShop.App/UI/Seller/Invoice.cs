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
    public partial class Invoice : UserControl
    {
        List<int> products { get; set; }
        ProductRepository productRepository = new ProductRepository();
        public Invoice()
        {
            InitializeComponent();
            loadGridView();
            products = new List<int>();
        }



        void loadGridView()
        {
            this.dgvAllProduct.DataSource = productRepository.GetAll();
        }

        private void metroLabel1_Click(object sender, EventArgs e)
        {

        }

        private void btnAddToCart_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = this.dgvAllProduct.SelectedRows[0];
            //Console.WriteLine(row.Cells[0].Value);
            var productID = Convert.ToInt32(row.Cells["productID"].Value);
            if (!products.Contains(productID))
            {
                //Console.WriteLine("inside if");
                //products.Add(productID);
                //var form = new invoiceProduct("asd", "asd", "Asd", productID);
                //form.TopLevel = false;
                //form.Show();
                //this.flowLayoutItems.Controls.Add(form);
                //form.Dock = DockStyle.Fill;
               

            }
            else
            {
                MessageBox.Show("Already Added");
            }
        }

        private void metroGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
