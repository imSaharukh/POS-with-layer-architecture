﻿using SuperShop.App.UI.Seller;
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
            try
            {
                var users = userRepository.GetAllSeller();
                List<string> usernames = new List<string>();

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
                this.dgvInvoice.DataSource = InvoiceRepository.GetAll();
            }
            catch(Exception err2)
            {
                MessageBox.Show("Something went wrong in the database", "Error!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
          
        }



        private void btnSearch_Click(object sender, EventArgs e)
        {
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
            InvoiceProductList productList = new InvoiceProductList(this.dgvInvoice.SelectedRows[0].Cells[0].Value.ToString());
            productList.Show();
        }
    }
}
