using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuperShop.App.UI.MiniStatement
{
    public partial class SalesSlip : MetroForm
    {
        Entity.Invoice invoice { get; set; }
        string PaidAmount { get; set; }
        string ExchangeAmount { get; set; }
        public SalesSlip(Entity.Invoice invoice,string paidAmount,string exchangeAmount)
        {
            InitializeComponent();
            this.invoice = invoice;
            this.PaidAmount = paidAmount;
            this.ExchangeAmount = exchangeAmount;
            this.LoadData(invoice);
        }
        void LoadData(Entity.Invoice invoice)
        {
            this.txtInvoiceNo.Text = invoice.invoiceID;
            this.txtDate.Text = DateTime.Now.ToShortDateString();
            this.txtSellerID.Text = invoice.SalesmanUsername;
            this.txtSubtotal.Text = invoice.SubTotal.ToString();
            this.txtTotalBDT.Text = invoice.TotalPrice.ToString();
            this.txtDiscountBDT.Text = invoice.Discount.ToString();
            this.txtPaidAmount.Text = PaidAmount.ToString();
            this.txtExchange.Text = ExchangeAmount.ToString();
            Console.WriteLine("invoice.InvoiceItems.Count " + invoice.InvoiceItems.Count);
            for (int i = 0; i < invoice.InvoiceItems.Count; i++)
            {
                var item = invoice.InvoiceItems[i];
                this.dgvProducts.Rows.Insert(0,invoice.InvoiceItems.Count- i,
                    item.Product.productName, item.Product.unitPrice, item.qty);
            }
        }
        private void SalesSlip_Load(object sender, EventArgs e)
        {

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(bmp, -30, -30);
        }
        Bitmap bmp;
        private void SlipPrint_Click(object sender, EventArgs e)
        {

            var Bitmap = new System.Drawing.Bitmap(this.Width, this.Height);
            this.DrawToBitmap(Bitmap, this.Bounds);
            var path = "./../../../Invoice/"+ invoice.invoiceID+".jpg";
            Bitmap.Save(path, ImageFormat.Jpeg);
            Bitmap.Dispose();
            MessageBox.Show("Saved Invoice to " + invoice.invoiceID + ".jpg");
            this.Hide();
        }

        private void metroLabel4_Click(object sender, EventArgs e)
        {

        }
    }
}
