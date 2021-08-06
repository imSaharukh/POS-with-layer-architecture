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
//using SuperShop.Reposatory;
namespace shop_managment
{
    public partial class LoginForm : MetroForm
    {
        private UserRepository userRepo{get;set;}
        public LoginForm()
        {
            InitializeComponent();
            userRepo = UserRepository();
        }

        private void metroUserControl1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void metroTextBox3_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            
        }
    }
}
