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

namespace SuperShop.App
{
    public partial class LoginForm : MetroForm
    {
     private   UserRepository userRepository { get; set; }
        public LoginForm()
        {
            InitializeComponent();
            userRepository = new UserRepository();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            //Console.WriteLine(this.txtUsername.Text);

            //Console.WriteLine(this.txtPassword.Text);
         var result=   userRepository.VerifyUser(this.txtUsername.Text,this.txtPassword.Text);

            if (result == null) {
                MessageBox.Show("Invalid username or password");
              
            }
            else if (result.RoleName.ToString().Trim() == "admin") {
                Console.WriteLine("inside if");
                this.Hide();

                AdminDashboard adminDashboard = new AdminDashboard();
                adminDashboard.Show();
            }
            Console.WriteLine(result?.RoleName);
        }
    }
}
