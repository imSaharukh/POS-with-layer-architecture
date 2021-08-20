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
    public partial class ReportControl : UserControl
    {
        InvoiceRepository InvoiceRepository = new InvoiceRepository();
        UserRepository userRepository = new UserRepository();
        public ReportControl()
        {
            InitializeComponent();
            loadGridView();
            LoadAllSeller();
        }


        void LoadAllSeller()
        {
            var users = userRepository.GetAllSeller();
            List<string> usernames = new List<string>();

            foreach (var item in users)
            {
                usernames.Add(item.username);
            }
            this.cmbUsername.DataSource = usernames;
        }
        private void metroPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
       void loadGridView() {
            
            this.metroGrid1.DataSource = InvoiceRepository.GetAll();
        }



        private void btnSearch_Click(object sender, EventArgs e)
        {
            Console.WriteLine(dtFrom.Value.ToShortDateString() +"  " + dtTo.Value.ToShortDateString());
            this.metroGrid1.DataSource = InvoiceRepository.GetByUsernameAndDateRange(this.cmbUsername.Text,dtFrom.Value.ToShortDateString(), dtTo.Value.ToShortDateString());
        }
    }
}
