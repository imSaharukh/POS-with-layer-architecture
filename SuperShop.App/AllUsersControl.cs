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
  
        private void metroGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
          
        }

        void LoadGridView()
        {

            var result = userRepository.GetAll();
            Console.WriteLine(result[0].userRole.RoleName);
            this.mgv.DataSource = result;
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
    }
}
