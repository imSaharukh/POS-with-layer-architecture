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
        CallbackDelegate loadGridViewCallback;
        public AddUserForm(CallbackDelegate loadGridViewCallback, User user = null)
        {
            InitializeComponent();
            loadUserRoles();
            loadUpdateData(user);
            this.loadGridViewCallback = loadGridViewCallback;

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
            var result = userRepository.GetUserRoles();

            foreach (var item in result)
            {
                roleNames.Add(item.RoleName);
            }
            this.cmbRole.DataSource = roleNames;




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
                var result = userRepository.UpdateOne(user);
                MessageBox.Show("user updated");
            }
            else { var result = userRepository.CreateOne(user);
                MessageBox.Show("user added");

            }

            //Console.WriteLine(result);
            loadGridViewCallback();


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
         
            return result;
        }

        private void cmbConfirm_Click(object sender, EventArgs e)
        {
            if (validate()) { CreateUser(); }
            
        }
    }
}
