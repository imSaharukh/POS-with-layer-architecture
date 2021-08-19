using MetroFramework.Forms;
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
        public AddProductForm()
        {
            InitializeComponent();
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
            

                //if (string.IsNullOrEmpty(this.txtFirstName.Text))
                //{

                //    result = false;
                //    this.lblErrFirstName.Text = "First Name can't be empty";
                //    this.lblErrFirstName.Visible = true;
                //    //Console.WriteLine("inside if");
                //}
                //if (string.IsNullOrEmpty(this.txtUsername.Text))
                //{

                //    result = false;
                //    this.lblErrUname.Text = "User Name can't be empty";
                //    this.lblErrUname.Visible = true;
                //    //Console.WriteLine("inside if");
                //}
                //if (string.IsNullOrEmpty(this.txtPassword.Text))
                //{

                //    result = false;
                //    this.lblErrPassword.Text = "Password can't be empty";
                //    this.lblErrPassword.Visible = true;
                //    //Console.WriteLine("inside if");
                //}
                //if (string.IsNullOrEmpty(this.txtLastName.Text))
                //{

                //    result = false;
                //    this.lblErrLastName.Text = "Last Name can't be empty";
                //    this.lblErrLastName.Visible = true;
                //    //Console.WriteLine("inside if");
                //}
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

        private void metroButton1_Click(object sender, EventArgs e)
        {
            validate();
        }
    }
}
