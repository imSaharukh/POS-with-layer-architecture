using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuperShop.App.UI.MiniStatement
{
    public partial class SalesSlip : MetroForm
    {
        public SalesSlip()
        {
            InitializeComponent();
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
            /* Graphics pnt = this.CreateGraphics();
             bmp = new Bitmap(this.Size.Width, this.Size.Height, pnt);
             Graphics pt = Graphics.FromImage(bmp);
             pt.CopyFromScreen(this.Location.X, this.Location.Y, 0, 0, this.Size);
             printPreviewDialog1.Document.DefaultPageSettings.Landscape = true;
             printPreviewDialog1.ShowDialog();*/

            // printDocument1.Print(this,printDocument1.PrintPage())
            var Bitmap = new System.Drawing.Bitmap(this.Width, this.Height);
            this.DrawToBitmap(Bitmap, this.Bounds);
            Bitmap.Save("Shium.jpg",ImageFormat.Jpeg)
        }

        
    }
}
