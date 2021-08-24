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

        bool IsManager { get; set; }

        //List<String> userRoles;
        public AllUsersControl(bool isManager =false)
        {
            InitializeComponent();
            this.IsManager = isManager;
            LoadGridView();
            if (isManager) {
                this.btnAdd.Enabled = false;
                this.btnUpdate.Enabled = false;
                this.btnDelete.Enabled = false;
            }
        }
  


        void LoadGridView()
        {
            try 
            {
                var result = userRepository.GetAll(this.IsManager);
                Console.WriteLine(result[0].userRole.RoleName);
                this.dgv.DataSource = result;
            }
            catch(Exception err)
            {
                MessageBox.Show("Something went wrong in the database", "Error!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void metroButton3_Click(object sender, EventArgs e)
        {

        }

        private void metroPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            CallbackDelegate callbackDelegate = new CallbackDelegate(LoadGridView);
            AddUserForm addUserForm = new AddUserForm(callbackDelegate);
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
                CallbackDelegate callbackDelegate = new CallbackDelegate(LoadGridView);
                AddUserForm addUserForm = new AddUserForm(callbackDelegate,user);
                addUserForm.Show();
            }
           
        }

        private void txtSearch_Click(object sender, EventArgs e)
        {

        }

        private void AllUsersControl_Load(object sender, EventArgs e)
        {

        }

        private void txtSerachChanged(object sender, EventArgs e)
        {

            try 
            {
                var result = userRepository.SearchByUsername(this.txtSearch.Text, this.IsManager);
                //Console.WriteLine(result[0]?.userRole.RoleName);
                this.dgv.DataSource = result;
            }
               
            catch(Exception err1)
            {
                MessageBox.Show("Something went wrong in the database", "Error!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (this.dgv.SelectedRows.Count == 0)
            {

                MessageBox.Show("please select a row");
            }
            else
            {

                DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete the User?", "Delete User  ", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.No)
                {
                    return;
                }
                DataGridViewRow row = this.dgv.SelectedRows[0];
                try
                {
                    var result = userRepository.DeleteOne(row.Cells["username"].Value.ToString());

                    if (result == 1)
                    {
                        MessageBox.Show("User deleted");
                        LoadGridView();
                    }
                    else { MessageBox.Show("Somthing went wrong"); }
                }
                catch(Exception err)
                {
                    MessageBox.Show("Something went wrong in the database", "Error!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
            }
        }
    }
}
