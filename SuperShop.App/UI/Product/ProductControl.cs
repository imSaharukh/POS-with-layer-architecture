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

        private void txtSearchProduct_Click(object sender, EventArgs e)
        {

        }
        void loadGridView()
        {
            this.dgvProduct.DataSource = productRepository.GetAll();
        }
        private void btnAddProductform_Click(object sender, EventArgs e)
        {
            AddProductForm addProductForm = new AddProductForm();
            addProductForm.Show();
        }
    }
}
