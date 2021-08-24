using MetroFramework.Controls;
using shortid;
using shortid.Configuration;
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
    
    public partial class InvoiceControl : UserControl
    {
        double Total { get; set; }
        double SubTotal { get; set; }
        double Discount { get; set; }
        string Username { get; set; }
        List<int> products { get; set; }
        ProductRepository productRepository = new ProductRepository();
        InvoiceRepository InvoiceRepository = new InvoiceRepository();

        public InvoiceControl(string username)
        {
            InitializeComponent();
            loadGridView();
            products = new List<int>();
            this.Username = username;
            Total = 0;
            SubTotal = 0;
            Discount = 0;
            this.txtProductQty.Text = "1";
        }



        void loadGridView()
        {
            try
            {
                this.dgvAllProduct.DataSource = productRepository.GetAll();
                for (int i = 0; i < this.dgvAllProduct.Rows.Count; i++)
                {
                    if (Convert.ToInt32(this.dgvAllProduct.Rows[i].Cells["stock"].Value) < 10)
                    {
                        Console.WriteLine("Changing color");
                        this.dgvAllProduct.Rows[i].DefaultCellStyle.BackColor = Color.OrangeRed;
                        this.dgvAllProduct.Rows[i].DefaultCellStyle.ForeColor = Color.Black;
                    }
                }
            }
            catch(Exception error)
            {
                MessageBox.Show("Something went wrong in the database", "Error!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
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
            var stock = Convert.ToDouble(row.Cells["stock"].Value.ToString());
            if (!String.IsNullOrEmpty(productQuantity) && Convert.ToDouble(productQuantity)>0)
            {
                if (!products.Contains(productID))
                {
                    if (Convert.ToInt32(productQuantity) > stock)
                    {
                        MessageBox.Show("qty can't be more then stock");
                        return;
                    }
                    this.dgvInvoiceProduct.Rows.Insert(0,productID, productName, productQuantity, unitPrice);
                    /* Total += (Convert.ToDouble(productQuantity) * Convert.ToDouble(unitPrice));
                     lblTotal.Text = CalculateTotal();*/
                    CalculateSubTotal();
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
                MessageBox.Show("Warning !!! Nothing to remove");
                return;
            }
            DataGridViewRow row = this.dgvInvoiceProduct.SelectedRows[0];
            if (row.Cells.Count > 0)
            {
                this.dgvInvoiceProduct.Rows.Remove(row);
                /*  Total -= Convert.ToDouble(row.Cells[1].Value)*Convert.ToDouble(row.Cells[2].Value);
                  lblTotal.Text = Total.ToString();*/
                this.products.Remove(Convert.ToInt32(row.Cells[0].Value));
                CalculateSubTotal();
            }
            else
                MessageBox.Show("Warning !!!! Nothing to remove");
                
        }

        private void DiscountChanged(object sender, EventArgs e)
        {
            CalculateSubTotal();
        }

 
        void CalculateTotal()
        {
            Total = 0;
            foreach (DataGridViewRow item in this.dgvInvoiceProduct.Rows)
            {
                Total += Convert.ToDouble(item.Cells[2].Value) * Convert.ToDouble(item.Cells[3].Value);
            }
            lblTotal.Text = Total.ToString();
        }
        void CalculateSubTotal()
        {
            SubTotal = 0;
            CalculateTotal();
             this.SubTotal = Total - (Convert.ToDouble(String.IsNullOrEmpty(this.txtBoxDiscount.Text) ? "0" : this.txtBoxDiscount.Text));
            lblSubTotal.Text = (SubTotal).ToString();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {

            if (products.Count < 1) {
                MessageBox.Show("Please Add Some Product first!");
                return;
            }


            //validate qty
            List<Entity.Product> allProducts = (List<Entity.Product>)this.dgvAllProduct.DataSource;
            foreach (DataGridViewRow item in this.dgvInvoiceProduct.Rows)
            {
                foreach (var item2 in allProducts)
                {
                    Console.WriteLine(item2.productID == Convert.ToInt32(item.Cells[0].Value));
   
                    if (item2.productID == Convert.ToInt32(item.Cells[0].Value) && Convert.ToInt32(item.Cells[2].Value) > item2.stock)
                    {
                        Console.WriteLine(Convert.ToInt32(item.Cells[2].Value).ToString() + " " + item2.stock);
                        Console.WriteLine(Convert.ToInt32(item.Cells[2].Value) > item2.stock);
                        MessageBox.Show(item.Cells[1].Value.ToString().Trim() +"'s qty can't be more then its stock", "Error");
                      
                        return;
                    }
                }
            }

            CalculateSubTotal();
            if (SubTotal > Convert.ToDouble(String.IsNullOrEmpty(this.txtGivenAmount.Text) ? "0" : this.txtGivenAmount.Text))
            {
                MessageBox.Show("Given Amount is less then SubTotal", "Error", MessageBoxButtons.OK);
                return;
            }


            Invoice invoice = new Invoice();
            var options = new GenerationOptions
            {
                Length = 9
            };

            invoice.invoiceID = ShortId.Generate(options);
            invoice.SalesmanUsername = Username;
            invoice.InvoiceItems = new List<InvoiceItem>();
            invoice.TotalPrice = this.Total;
            invoice.SubTotal = this.SubTotal;
            invoice.Discount = Convert.ToDouble(String.IsNullOrEmpty(this.txtBoxDiscount.Text) ? "0" : this.txtBoxDiscount.Text);
            foreach (DataGridViewRow item in this.dgvInvoiceProduct.Rows)
            {
                var product = new InvoiceItem();
                product.Product = new Entity.Product();

                product.Product.productName = item.Cells[1].Value.ToString();
                product.Product.unitPrice = Convert.ToDouble(item.Cells[3].Value);
                product.qty = Convert.ToInt32(item.Cells[2].Value);

                if (product.qty < 1)
                {
                    MessageBox.Show("Qty can't be 0");
                    return;


                }

                product.productID = Convert.ToInt32(item.Cells[0].Value);
                invoice.InvoiceItems.Add(product);
            }

            var result = InvoiceRepository.CreateOne(invoice);
            if (result == 1)
            {
                var exhangeAmount = Math.Round((Convert.ToDouble(String.IsNullOrEmpty(this.txtGivenAmount.Text) ? "0" : txtGivenAmount.Text) - SubTotal), 2);

                MessageBox.Show("Excahnge Amount " + exhangeAmount + " TK", "Message", MessageBoxButtons.OK);

                UI.MiniStatement.SalesSlip salesSlip = new UI.MiniStatement.SalesSlip(invoice, this.txtGivenAmount.Text, exhangeAmount.ToString());
                salesSlip.Location = new Point(0, 0);
                salesSlip.Show();
                ClearAll();
                loadGridView();

                //Hide();
            }
            else
            {
                MessageBox.Show("Somthing went wrong");
            }
        }

        void ClearAll()
        {
            this.products.Clear();
            this.dgvInvoiceProduct.Rows.Clear();
            CalculateSubTotal();
            this.txtBoxDiscount.Text = "";
            this.txtGivenAmount.Text = "";
        }
        private void search_changed(object sender, EventArgs e)
        {
            try
            {
                this.dgvAllProduct.DataSource = productRepository.SearchByProductname(this.txtSearch.Text);
            }
            catch(Exception error)
            {
                MessageBox.Show("Something went wrong in the database", "Error!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void metroPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnClearAll_Click(object sender, EventArgs e)
        {
            this.dgvInvoiceProduct.Rows.Clear();
            this.products.Clear();
            CalculateSubTotal();
        }

        private void dgvInvoiceProduct_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            CalculateSubTotal();
            Console.WriteLine("Value_Changed");
            
        }

        private void dgvInvoiceProduct_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            Console.WriteLine("Value_+Changed");
            e.Control.KeyPress -= new KeyPressEventHandler(this.QtyKeyPress);
            if (this.dgvInvoiceProduct.CurrentCell.ColumnIndex == 2) //Desired Column
            {
                TextBox tb = e.Control as TextBox;
                if (tb != null)
                {
                    tb.KeyPress += new KeyPressEventHandler(this.QtyKeyPress);
                }
            }
        }

        private void InvoiceForm_Load(object sender, EventArgs e)
        {
            loadGridView();
        }

        private void txtBoxDiscount_Click(object sender, EventArgs e)
        {

        }

        private void discountKeypress(object sender, KeyPressEventArgs e)
        {
            Console.WriteLine((sender as MetroTextBox).Text.IndexOf('.'));
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
           (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as MetroTextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
            //reject dot at first index
            if ((e.KeyChar == '.') && string.IsNullOrEmpty((sender as MetroTextBox).Text))
            {
                e.Handled = true;
            }
        }

        private void dgvInvoiceProduct_CellValidated(object sender, DataGridViewCellEventArgs e)
        {
           
        }
    }
}
