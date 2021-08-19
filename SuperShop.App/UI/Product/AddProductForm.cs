﻿using MetroFramework.Forms;
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

namespace SuperShop.App
{
    public partial class AddProductForm : MetroForm
    {
        ProductRepository productRepository = new ProductRepository();
        CallbackDelegate loadgridviewcallback;
        public AddProductForm(CallbackDelegate loadgridviewcallback,Product product = null)
        {
            InitializeComponent();
            loadInitialData();

            this.loadgridviewcallback = loadgridviewcallback;
        }

        void loadInitialData() {

            this.cmbCategory.DataSource = productRepository.GellAllProductCatagory();
            this.cmbUnit.DataSource = productRepository.GellAllProductUnits();
        
        }
        bool validate()
        {
            bool result = true;
            if (string.IsNullOrEmpty(this.txtProductName.Text))
            {
                result = false;
                this.lblErrProductName.Text = "First Name can't be empty";
                this.lblErrProductName.Visible = true;
            }
            
            if (string.IsNullOrEmpty(this.txtPurchasePrice.Text))
            {
                result = false;
                this.lblErrPrice.Text = "Purchase Price can't be empty";
                this.lblErrPrice.Visible = true;
            }
            
            if (string.IsNullOrEmpty(this.txtStock.Text))
            {
                result = false;
                this.lblErrStock.Text = "Stock can't be empty";
                this.lblErrStock.Visible = true;
            }
            else if (System.Text.RegularExpressions.Regex.IsMatch(txtStock.Text, "[^0-9]"))
            {
                result = false;
                this.lblErrStock.Text = "Stock must be a number";
                this.lblErrStock.Visible = true;
            }
            if (string.IsNullOrEmpty(this.txtUnitPrice.Text))
            {
                result = false;
                this.lblErrUnitPrice.Text = "Unit Price can't be empty";
                this.lblErrUnitPrice.Visible = true;
            }
                return result;
        }
        private void AddProductForm_Load(object sender, EventArgs e)
        {
            this.lblErrProductName.Visible = false;
            this.lblErrPrice.Visible = false;
            this.lblErrUnitPrice.Visible = false;
            this.lblErrStock.Visible = false;
       

        }

        private void lblErrName_Click(object sender, EventArgs e)
        {

        }


        void CreateProduct()
        {
           Product product = new Product();
            product.ProductUnit = new ProductUnit();
            product.productCategory = new ProductCategory();
            product.productName = this.txtProductName.Text;
            product.purchasePrice = Convert.ToDouble(this.txtPurchasePrice.Text);
            product.ProductUnit.ProductUnitName = this.cmbUnit.Text;
           
            product.productCategory.productCategoryName = this.cmbCategory.Text;
            product.stock = Convert.ToInt32(this.txtStock.Text);
            product.unitPrice = Convert.ToDouble(this.txtUnitPrice.Text);
            product.expireDate = this.dtExpireDate.Value;
            //Console.WriteLine(this.da)
            var result = productRepository.CreateOne(product);

            if (result == 1)
            {
                MessageBox.Show("Product added");
                loadgridviewcallback();
                Hide();
            }
            else
            {
                MessageBox.Show("Somthing went wrong");
            }
            
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            if (validate())
            {
                CreateProduct();
            }
        }
    }
}