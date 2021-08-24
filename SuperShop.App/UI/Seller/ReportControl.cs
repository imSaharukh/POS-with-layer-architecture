using SuperShop.App.UI.Seller;
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
        string Username { get; set; }
        public ReportControl(string username = null)
        {
            InitializeComponent();
            
          
            this.Username = username;
            this.dtFrom.Value = this.dtFrom.Value.AddDays(-30);
            LoadAllSeller();
            loadGridView();

        }


        void LoadAllSeller()
        {
            if(Username != null)
            {
                List<string> users = new List<string>();
                
                users.Add(this.Username);
                this.cmbUsername.DataSource = users;
                this.cmbUsername.Text = this.Username;
                this.cmbUsername.Enabled = false;
                return;
            }
            try
            {
                var users = userRepository.GetAllSeller();
                List<string> usernames = new List<string>();
                usernames.Add("All");
                foreach (var item in users)
                {
                    usernames.Add(item.username);
                }
                this.cmbUsername.DataSource = usernames;
            }
            catch(Exception err1)
            {
                MessageBox.Show("Something went wrong in the database", "Error!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void metroPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
       void loadGridView() {
            try
            {
                this.dgvInvoice.DataSource = InvoiceRepository.GetAll(Username);
            }
            catch (Exception err2)
            {

                Console.WriteLine(err2);
                MessageBox.Show("Something went wrong in the database", "Error!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }



        private void btnSearch_Click(object sender, EventArgs e)
        {
            this.txtInvoiceSearch.Clear();
            Console.WriteLine(dtFrom.Value.ToShortDateString() +"  " + dtTo.Value.ToShortDateString());
            try
            {
                this.dgvInvoice.DataSource = InvoiceRepository.GetByUsernameAndDateRange(this.cmbUsername.Text, dtFrom.Value.ToShortDateString(),
               dtTo.Value.ToShortDateString());
            }
            catch (Exception error)
            {
                MessageBox.Show("Something went wrong in the database", "Error!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvInvoice_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Console.WriteLine("cell content click");
         var result =    this.InvoiceRepository.GetAllInvoiceProduct(this.dgvInvoice.SelectedRows[0].Cells[0].Value.ToString());

            if (result.Count < 1)
            {

                MessageBox.Show("No Product Found! Maybe Deleted");
              
                return;
            }
            InvoiceProductList productList = new InvoiceProductList(result);
            productList.Show();
        }

        private void txtInvoiceSearch_TextChanged(object sender, EventArgs e)
        {
            this.dgvInvoice.DataSource = InvoiceRepository.GetByUsernameAndDateRangeAndInvoice(this.txtInvoiceSearch.Text,this.cmbUsername.Text, dtFrom.Value.ToShortDateString(),
                         dtTo.Value.ToShortDateString());
        }
    }
}
