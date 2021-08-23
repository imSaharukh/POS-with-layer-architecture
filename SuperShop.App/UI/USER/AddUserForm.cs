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
    public partial class AddUserForm : MetroForm
    {
        bool isUpdate = false;
        UserRepository userRepository = new UserRepository();
        List<string> roleNames =new List<string>();
        CallbackDelegate LoadGridViewCallback { get; set; }
        public AddUserForm(CallbackDelegate loadGridViewCallback, User user = null)
        {
            InitializeComponent();
            loadUserRoles();
            loadUpdateData(user);
            this.LoadGridViewCallback = loadGridViewCallback;
             
        }
        
        void loadUpdateData(User user)
        {
            if (user != null) {
                this.txtUsername.Text = user.username;
                this.txtFirstName.Text = user.firstName;
                this.txtLastName.Text = user.lastName;
                this.txtPassword.Text = user.password;
                this.cmbRole.Text = user.userRole.RoleName;
                this.Text = "Update User";
                this.txtUsername.ReadOnly = true;
                this.cmbRole.Enabled = false;
                this.isUpdate = true;

            }
        }
        private void AddUserForm_Load(object sender, EventArgs e)
        {
            this.lblErrFirstName.Visible = false;
            this.lblErrLastName.Visible = false;
            this.lblErrUname.Visible = false;
            this.lblErrPassword.Visible = false;
        }

        private void metroTextBox2_Click(object sender, EventArgs e)
        {

        }

        private void metroTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel1_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel2_Click(object sender, EventArgs e)
        {

        }

        private void metroTextBox3_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel3_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel4_Click(object sender, EventArgs e)
        {

        }

        private void metroTextBox4_Click(object sender, EventArgs e)
        {

        }

        private void metroTextBox5_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel5_Click(object sender, EventArgs e)
        {

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {

        }

        void loadUserRoles()
        {
            try
            {
                var result = userRepository.GetUserRoles();

                foreach (var item in result)
                {
                    roleNames.Add(item.RoleName);
                }
                this.cmbRole.DataSource = roleNames;

            }
            catch(Exception er)
            {
                MessageBox.Show("Something went wrong in the database", "Error!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }
        private void CreateUser()
        {

          
            User user = new User();
            user.userRole = new UserRole();
            user.username = this.txtUsername.Text;
            user.password = this.txtPassword.Text;
            user.firstName = this.txtFirstName.Text;
            user.lastName = this.txtLastName.Text;
            user.userRole.RoleName = this.cmbRole.Text;


            if (isUpdate)
            {
                try
                {
                    var result = userRepository.UpdateOne(user);
                    MessageBox.Show("user updated");
                }
                catch(Exception error)
                {
                    MessageBox.Show("Something went wrong in the database", "Error!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
            }
            else
            {
                try
                {
                    var result = userRepository.CreateOne(user);
                    if (result == -1)
                    {
                        MessageBox.Show("User Already Exist"); 
                    }
                    else if (result == 1)
                    {
                        MessageBox.Show("User Added");
                        this.Hide();

                    }
                    else
                    {
                        MessageBox.Show("Somthing went wrong");

                    }
                }
                catch(Exception err)
                {
                    MessageBox.Show("Something went wrong in the database", "Error!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            //Console.WriteLine(result);
            LoadGridViewCallback();


            Hide();
            //Console.WriteLine(this.txtFirstName);
            //Console.WriteLine(this.cmbRole.Text);
        }


        bool validate()
        {
            bool result = true;
            if (string.IsNullOrEmpty(this.txtFirstName.Text))
            {
               
                result = false;
                this.lblErrFirstName.Text = "First Name can't be empty";
                this.lblErrFirstName.Visible = true;
                //Console.WriteLine("inside if");
            }
            if (string.IsNullOrEmpty(this.txtUsername.Text))
            {

                result = false;
                this.lblErrUname.Text = "User Name can't be empty";
                this.lblErrUname.Visible = true;
                //Console.WriteLine("inside if");
            }
            if (string.IsNullOrEmpty(this.txtPassword.Text))
            {

                result = false;
                this.lblErrPassword.Text = "Password can't be empty";
                this.lblErrPassword.Visible = true;
                //Console.WriteLine("inside if");
            }
            if (string.IsNullOrEmpty(this.txtLastName.Text))
            {

                result = false;
                this.lblErrLastName.Text = "Last Name can't be empty";
                this.lblErrLastName.Visible = true;
                //Console.WriteLine("inside if");
            }
            return result;
        }

        private void cmbConfirm_Click(object sender, EventArgs e)
        {
            if (validate()) { CreateUser(); }
            
        }

        private void metroLabel6_Click(object sender, EventArgs e)
        {
        }

        private void metroLblErrUname_Click(object sender, EventArgs e)
        {

        }
    }
}
