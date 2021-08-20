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
    public partial class ProductControl : UserControl  
    {

        ProductRepository productRepository = new ProductRepository();
       
        public ProductControl()
        {
            InitializeComponent();
            loadGridView();
        }

        private void ProductControl_Load(object sender, EventArgs e)
        {

        }
        void loadGridView()
        {
            this.dgvProduct.DataSource = productRepository.GetAll();
        }
        private void btnAddProductform_Click(object sender, EventArgs e)
        {
            CallbackDelegate callbackDelegate = new CallbackDelegate(loadGridView);
            AddProductForm addProductForm = new AddProductForm(callbackDelegate);
            addProductForm.Show();
        }

        private void btnProductUpdate_Click(object sender, EventArgs e)
        {
            if (this.dgvProduct.SelectedRows.Count == 0)
            {

                MessageBox.Show("please select a row");
            }
            else
            {
                DataGridViewRow row = this.dgvProduct.SelectedRows[0];
                Console.WriteLine(row.Cells[0].Value);
                Product product = new Product();

                var productID = Convert.ToInt32(row.Cells["productID"].Value);
                //Console.WriteLine("-> "+ productID);
                product.productID = productID;
                product.ProductUnit = new ProductUnit();
                product.productCategory = new ProductCategory();
                product.productName = row.Cells["productName"].Value.ToString();
                product.unitPrice = Convert.ToDouble(row.Cells["unitPrice"].Value);
                product.stock = Convert.ToInt32(row.Cells["stock"].Value);
                product.productCategory.productCategoryName = row.Cells["productCategory"].Value.ToString();
                product.purchasePrice = Convert.ToDouble(row.Cells["purchasePrice"].Value);
                product.expireDate = Convert.ToDateTime(row.Cells["expireDate"].Value);
                product.ProductUnit.ProductUnitName = row.Cells["ProductUnit"].Value.ToString();
                CallbackDelegate callbackDelegate = new CallbackDelegate(loadGridView);
                AddProductForm addProductForm = new AddProductForm(callbackDelegate, product);
                addProductForm.Show();
            }
               
        }

        private void search_TextChanged(object sender, EventArgs e)
        {
            Console.WriteLine(this.txtSearchProduct.Text);
        this.dgvProduct.DataSource= productRepository.SearchByProductname(this.txtSearchProduct.Text);
        }
    }
}
