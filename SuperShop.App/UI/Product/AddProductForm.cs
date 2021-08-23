using MetroFramework.Controls;
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

namespace SuperShop.App
{
    public partial class AddProductForm : MetroForm
    {
        int productID = 0;
        bool isUpdate = false;
        ProductRepository productRepository = new ProductRepository();
        CallbackDelegate Loadgridviewcallback { get; set; }
        public AddProductForm(CallbackDelegate loadgridviewcallback,Product product = null)
        {
            InitializeComponent();
            loadInitialData();
            loadUpdateData(product);
            this.Loadgridviewcallback = loadgridviewcallback;
        }

        void loadUpdateData(Product product)
        {
            if(product !=null)
            {
                isUpdate = true;
                this.txtProductName.Text = product.productName.Trim();
                this.txtUnitPrice.Text = product.unitPrice.ToString();
                this.txtStock.Text = product.stock.ToString();
                this.txtPurchasePrice.Text = product.purchasePrice.ToString();
                //this.txtPurchasePrice.ReadOnly = true;
                this.cmbCategory.Text = product.categoryID.ToString();
                this.dtExpireDate.Value = product.expireDate;
                this.cmbUnit.Text = product.ProductUnit.ProductUnitName;
                this.productID = product.productID;
                this.Text = "Update Product";


            }    
        }
        void loadInitialData() {
            try
            {
                this.cmbCategory.DataSource = productRepository.GellAllProductCatagory();
                this.cmbUnit.DataSource = productRepository.GellAllProductUnits();
            }
            catch(Exception error)
            {
                MessageBox.Show("Something went wrong in the database", "Error!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
            else if(Convert.ToDouble(this.txtUnitPrice.Text)<=0)
            {
                result = false;
                this.lblErrUnitPrice.Text = "Unit Price can't be less than 1";
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
            product.productID = this.productID;
            product.ProductUnit = new ProductUnit();
            product.productCategory = new ProductCategory();
            product.productName = this.txtProductName.Text;
            product.purchasePrice = Convert.ToDouble(this.txtPurchasePrice.Text);
            product.ProductUnit.ProductUnitName = this.cmbUnit.Text;
           
            product.productCategory.productCategoryName = this.cmbCategory.Text;
            product.stock = Convert.ToInt32(this.txtStock.Text);
            product.unitPrice = Convert.ToDouble(this.txtUnitPrice.Text);
            product.expireDate = this.dtExpireDate.Value;
         
            int? result = 0;
            if (isUpdate) {
                try
                {
                    result = productRepository.UpdateOne(product);
                }
                catch(Exception error)
                {
                    MessageBox.Show("Something went wrong in the database", "Error!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
                Console.WriteLine("update: " + result);
            }
            else
            {
                try
                {
                    result = productRepository.CreateOne(product);
                }
                catch(Exception error)
                {
                    MessageBox.Show("Something went wrong in the database", "Error!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (result == 1)
            {
                MessageBox.Show(isUpdate?"Product updated":"Product added");
                Loadgridviewcallback();
                Hide();
            }
            else
            {
                MessageBox.Show("Somthing went wrong");
            }
            
        }

       

        private void txtUnitPrice_Click(object sender, EventArgs e)
        {

        }

        private void btnConfirmAdd_Click(object sender, EventArgs e)
        {
            if(validate())
            {
                CreateProduct();
            }
        }

        private void txtPurchasePrice_Click(object sender, EventArgs e)
        {

        }

        private void txtPurchasePrice_KeyPress(object sender, KeyPressEventArgs e)
        {
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

        private void txtUnitPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
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

        private void txtStock_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

        }
    }
}
