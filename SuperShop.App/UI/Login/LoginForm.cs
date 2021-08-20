using MetroFramework.Forms;
using SuperShop.App.UI.Dashboard;
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
         var result=   userRepository.VerifyUser(this.txtUsername.Text,this.txtPassword.Text);

            if (result == null) {
                MessageBox.Show("Invalid username or password");
              
            }
            else if (result.userRole.RoleName.Trim() == "admin") {
                Console.WriteLine("inside if");
                this.Hide();

                AdminDashboard adminDashboard = new AdminDashboard(this.txtUsername.Text);
                adminDashboard.Show();
            }
            else if (result.userRole.RoleName.Trim() == "manager") {
                Console.WriteLine("inside if");
                this.Hide();

                ManagerDashboard managerDashboard = new ManagerDashboard();
                managerDashboard.Show();
            }
            else if (result.userRole.RoleName.Trim() == "seller")
            {
                Console.WriteLine("inside if");
                this.Hide();
               
                SellerDashboard sellerboard = new SellerDashboard(this.txtUsername.Text);
                sellerboard.Show();
            }
            Console.WriteLine(result?.userRole);
        }
    }
}
