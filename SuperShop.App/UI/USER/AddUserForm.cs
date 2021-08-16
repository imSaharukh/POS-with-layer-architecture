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
        UserRepository userRepository = new UserRepository();
        List<String> roleNames =new List<string>();

        public AddUserForm(User user = null)
        {
            InitializeComponent();
            loadUserRoles();
            loadUpdateData(user);

        }
        void loadUpdateData(User user)
        {
            if (user != null) {
                this.txtUsername.Text = user.username;
                this.txtFirstName.Text = user.firstName;
                this.txtLastName.Text = user.lastName;
                this.txtPassword.Text = user.password;
                this.cmbRole.Text = user.userRole.RoleName;

            }
        }
        private void AddUserForm_Load(object sender, EventArgs e)
        {

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
            var result = userRepository.CreateOne(user);
            Console.WriteLine(result);

            MessageBox.Show("user added");
            Hide();
            //Console.WriteLine(this.txtFirstName);
            //Console.WriteLine(this.cmbRole.Text);
        }

        private void cmbConfirm_Click(object sender, EventArgs e)
        {
            CreateUser();
        }
    }
}
