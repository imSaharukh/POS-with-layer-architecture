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
            this.mgv.DataSource = result;
        }
    }
}
