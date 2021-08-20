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
        double Total { get; set; }
        double SubTotal { get; set; }
        double Discount { get; set; }
        List<int> products { get; set; }
        ProductRepository productRepository = new ProductRepository();
        public Invoice()
        {
            InitializeComponent();
            loadGridView();
            products = new List<int>();
            Total = 0;
            SubTotal = 0;
            Discount = 0;
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
            var productName = row.Cells["productName"].Value.ToString();
            var unitPrice = row.Cells["unitPrice"].Value.ToString();
            var productQuantity = txtProductQty.Text;
            
            if (!String.IsNullOrEmpty(productQuantity) && Convert.ToDouble(productQuantity)>0)
            {
                if (!products.Contains(productID))
                {
                    this.dgvInvoiceProduct.Rows.Insert(0,productID, productName, productQuantity, unitPrice);
                    /* Total += (Convert.ToDouble(productQuantity) * Convert.ToDouble(unitPrice));
                     lblTotal.Text = CalculateTotal();*/
                    CalculateTotal();
                    products.Add(productID);

                }
                else
                {
                    MessageBox.Show("Already Added");
                }
            }
            else
                MessageBox.Show("Quantity can't be empty");
            
        }

        private void metroGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtProductQty_Click(object sender, EventArgs e)
        {
            
        }

        private void QtyKeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnCartItemRemove_Click(object sender, EventArgs e)
        {
            if(this.dgvInvoiceProduct.SelectedRows.Count <1)
            {
                MessageBox.Show("Are u cocky !!!Nothing to remove");
                return;
            }
            DataGridViewRow row = this.dgvInvoiceProduct.SelectedRows[0];
            if (row.Cells.Count > 0)
            {
                this.dgvInvoiceProduct.Rows.Remove(row);
                /*  Total -= Convert.ToDouble(row.Cells[1].Value)*Convert.ToDouble(row.Cells[2].Value);
                  lblTotal.Text = Total.ToString();*/
                CalculateTotal();
            }
            else
                MessageBox.Show("U drunk !!!! go home and sleep");
                
        }

        private void DiscountChanged(object sender, EventArgs e)
        {
            CalculateSubTotal();
        }

        void CalculateDiscount()
        {
            SubTotal = Total - Discount;

        }
        void CalculateTotal()
        {
           // this.dgvInvoiceProduct.Rows.
            Total = 0;
            foreach (DataGridViewRow item in this.dgvInvoiceProduct.Rows)
            {
                Total += Convert.ToDouble(item.Cells[1].Value) * Convert.ToDouble(item.Cells[2].Value);
            }
            lblTotal.Text = Total.ToString();
        }
        void CalculateSubTotal()
        {
            SubTotal = 0;
            CalculateTotal();
            lblSubTotal.Text = (Total - Convert.ToDouble(String.IsNullOrEmpty(this.txtBoxDiscount.Text) ? "0":this.txtBoxDiscount.Text)).ToString();
        }
    }
}
