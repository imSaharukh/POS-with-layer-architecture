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
    public partial class AllUsersControl : UserControl
    {
        UserRepository userRepository = new UserRepository();

        //List<String> userRoles;
        public AllUsersControl()
        {
            InitializeComponent();
            LoadGridView();
        }
  


        void LoadGridView()
        {

            var result = userRepository.GetAll();
            Console.WriteLine(result[0].userRole.RoleName);
            this.dgv.DataSource = result;
        }

        private void metroButton3_Click(object sender, EventArgs e)
        {

        }

        private void metroPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddUserForm addUserForm = new AddUserForm();
            addUserForm.Show();
        }

        private void metroContextMenu1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (this.dgv.SelectedRows.Count == 0) {

                MessageBox.Show("please select a row");
            }

            else
            {
                DataGridViewRow row = this.dgv.SelectedRows[0];
                Console.WriteLine(row.Cells[0].Value);
                User user = new User();
                user.firstName = row.Cells["firstName"].Value.ToString();
                user.lastName = row.Cells["lastName"].Value.ToString();
                user.username = row.Cells["username"].Value.ToString();
                user.password = row.Cells["password"].Value.ToString();
                user.userRole =new UserRole();
                user.userRole.RoleName = row.Cells[4].Value.ToString();

                AddUserForm addUserForm = new AddUserForm(user);
                addUserForm.Show();
            }
            //Console.WriteLine(this.dgv.SelectedRows[0].Cells["firstName"]);
            //AddUserForm addUserForm = new AddUserForm();
            //addUserForm.Show();
        }

        private void txtSearch_Click(object sender, EventArgs e)
        {

        }

        private void AllUsersControl_Load(object sender, EventArgs e)
        {

        }

        private void txtSerachChanged(object sender, EventArgs e)
        {
    

            var result = userRepository.SearchByUsername(this.txtSearch.Text);
            //Console.WriteLine(result[0]?.userRole.RoleName);
            this.dgv.DataSource = result;
        }
    }
}
