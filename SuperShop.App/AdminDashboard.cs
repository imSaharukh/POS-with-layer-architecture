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
    public partial class AdminDashboard : MetroForm
    {
        UserRepository userRepository = new UserRepository();
        public AdminDashboard()
        {
            InitializeComponent();
        }

    

        private void AdminDashboard_Load(object sender, EventArgs e)
        {

        }
        
        private void metroPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
        void showControll(Control control) {

            this.displayPanel.Controls.Clear();
            control.Dock = DockStyle.Fill;
            control.BringToFront();
            control.Focus();
            this.displayPanel.Controls.Add(control);
        
        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            AllUsersControl allUsersControl = new AllUsersControl();
            showControll(allUsersControl);
        }
    }
}
