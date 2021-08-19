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
            this.lblErrName.Visible = false;
        }
    }
}
