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
            this.lblErrAddCategory.Visible = false;
        }

        private void AddCatagory_Load(object sender, EventArgs e)
        {
        }

        bool catvalidate()
        {
            if(String.IsNullOrWhiteSpace(this.txtCatagory.Text) && String.IsNullOrEmpty(this.txtCatagory.Text))
            {
                this.lblErrAddCategory.Text = "Category can't be empty";
                this.lblErrAddCategory.Visible = true;
                return false;
            }
            return true;
        }
        private void metroButton1_Click(object sender, EventArgs e)
        {
            if(catvalidate())
            {
                try
                {
                    ProductRepository productRepository = new ProductRepository();
                    var result = productRepository.CreateOneProductCatagory(this.txtCatagory.Text);
                    if (result == -1)
                    {
                        MessageBox.Show("Catagory Already Exist");
                    }
                  else  if (result == 1)
                    {
                        MessageBox.Show("Catagory Added");
                        this.Hide();

                    }
                    else
                    {
                        MessageBox.Show("Somthing went wrong");

                    }
                }
                catch(Exception error)
                {
                    MessageBox.Show("Something went wrong in the database", "Error!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }


        }

        private void metroLabel1_Click(object sender, EventArgs e)
        {
        }
    }
}
