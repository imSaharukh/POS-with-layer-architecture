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

namespace SuperShop.App.UI.Product
{
    public partial class AddCatagory : MetroForm
    {
        public AddCatagory()
        {
            InitializeComponent();
        }

        private void AddCatagory_Load(object sender, EventArgs e)
        {

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            ProductRepository productRepository = new ProductRepository();
         var result =    productRepository.CreateOneProductCatagory(this.txtCatagory.Text);
            if (result == 1) {
                MessageBox.Show("Catagory Added");
                this.Hide();
            
            } else {
                MessageBox.Show("Somthing went wrong");
            
            }


        }
    }
}
