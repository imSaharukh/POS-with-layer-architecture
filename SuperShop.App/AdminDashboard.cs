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
        AllUsersControl allUsersControl = new AllUsersControl();
        ProductControl productControl = new ProductControl();
        public AdminDashboard()
        {
            InitializeComponent();
            showControll(allUsersControl);
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
            //AllUsersControl allUsersControl = new AllUsersControl();
            showControll(allUsersControl);
        }
        void showProuductControl(Control control2)
        {

            this.displayPanel.Controls.Clear();
            control2.Dock = DockStyle.Fill;
            control2.BringToFront();
            control2.Focus();
            this.displayPanel.Controls.Add(control2);

        }

        private void btnProduct_Click(object sender, EventArgs e)
        {
       
            showProuductControl(productControl);
        }
    }
}
