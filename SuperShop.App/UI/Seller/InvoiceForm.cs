﻿using SuperShop.Entity;
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
    
    public partial class InvoiceForm : UserControl
    {
        double Total { get; set; }
        double SubTotal { get; set; }
        double Discount { get; set; }
        string Username { get; set; }
        List<int> products { get; set; }
        ProductRepository productRepository = new ProductRepository();
        InvoiceRepository InvoiceRepository = new InvoiceRepository();

        public InvoiceForm(string username)
        {
            InitializeComponent();
            loadGridView();
            products = new List<int>();
            this.Username = username;
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
             this.SubTotal = Total - Convert.ToDouble(String.IsNullOrEmpty(this.txtBoxDiscount.Text) ? "0" : this.txtBoxDiscount.Text);
            lblSubTotal.Text = (SubTotal).ToString();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            Invoice invoice = new Invoice();
            invoice.SalesmanUsername = Username;
            invoice.InvoiceItems =new List<InvoiceItem>();
            invoice.TotalPrice = this.Total;
            invoice.SubTotal = this.SubTotal;
            invoice.Discount = this.Discount;
            foreach (DataGridViewRow item in this.dgvInvoiceProduct.Rows)
            {
                var product = new InvoiceItem();
                product.qty = Convert.ToInt32(item.Cells[2].Value);
                product.productID = Convert.ToInt32(item.Cells[3].Value);
                invoice.InvoiceItems.Add(product);
            }

           var result =  InvoiceRepository.CreateOne(invoice);
            if (result == 1)
            {
                UI.MiniStatement.SalesSlip salesSlip = new UI.MiniStatement.SalesSlip();
                salesSlip.Location = new Point(0, 0);
                salesSlip.Show();

                //Hide();
            }
            else
            {
                MessageBox.Show("Somthing went wrong");
            }
        }

        private void search_changed(object sender, EventArgs e)
        {
        this.dgvAllProduct.DataSource=    productRepository.SearchByProductname(this.txtSearch.Text);
        }

        private void metroPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnClearAll_Click(object sender, EventArgs e)
        {
            this.dgvInvoiceProduct.Rows.Clear();
           
            CalculateSubTotal();
        }
    }
}