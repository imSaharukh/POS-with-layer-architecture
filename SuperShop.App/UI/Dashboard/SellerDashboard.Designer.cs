
namespace SuperShop.App.UI.Dashboard
{
    partial class SellerDashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Salesdisplay = new MetroFramework.Controls.MetroPanel();
            this.metroPanel2 = new MetroFramework.Controls.MetroPanel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.btnSales = new MetroFramework.Controls.MetroButton();
            this.btnLogOut = new MetroFramework.Controls.MetroButton();
            this.btnSalesReport = new MetroFramework.Controls.MetroButton();
            this.metroPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Salesdisplay
            // 
            this.Salesdisplay.HorizontalScrollbarBarColor = true;
            this.Salesdisplay.HorizontalScrollbarHighlightOnWheel = false;
            this.Salesdisplay.HorizontalScrollbarSize = 10;
            this.Salesdisplay.Location = new System.Drawing.Point(229, 66);
            this.Salesdisplay.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Salesdisplay.Name = "Salesdisplay";
            this.Salesdisplay.Size = new System.Drawing.Size(856, 518);
            this.Salesdisplay.TabIndex = 0;
            this.Salesdisplay.VerticalScrollbarBarColor = true;
            this.Salesdisplay.VerticalScrollbarHighlightOnWheel = false;
            this.Salesdisplay.VerticalScrollbarSize = 11;
            // 
            // metroPanel2
            // 
            this.metroPanel2.Controls.Add(this.metroLabel1);
            this.metroPanel2.Controls.Add(this.btnSales);
            this.metroPanel2.Controls.Add(this.btnLogOut);
            this.metroPanel2.Controls.Add(this.btnSalesReport);
            this.metroPanel2.HorizontalScrollbarBarColor = true;
            this.metroPanel2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel2.HorizontalScrollbarSize = 10;
            this.metroPanel2.Location = new System.Drawing.Point(23, 66);
            this.metroPanel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.metroPanel2.Name = "metroPanel2";
            this.metroPanel2.Size = new System.Drawing.Size(200, 518);
            this.metroPanel2.TabIndex = 1;
            this.metroPanel2.VerticalScrollbarBarColor = true;
            this.metroPanel2.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel2.VerticalScrollbarSize = 11;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(3, 487);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(114, 20);
            this.metroLabel1.TabIndex = 8;
            this.metroLabel1.Text = "Version 0.1 [Beta]";
            // 
            // btnSales
            // 
            this.btnSales.Location = new System.Drawing.Point(29, 18);
            this.btnSales.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSales.Name = "btnSales";
            this.btnSales.Size = new System.Drawing.Size(153, 23);
            this.btnSales.TabIndex = 7;
            this.btnSales.Text = "Sales";
            this.btnSales.UseSelectable = true;
            this.btnSales.Click += new System.EventHandler(this.btnSales_Click);
            // 
            // btnLogOut
            // 
            this.btnLogOut.Location = new System.Drawing.Point(29, 454);
            this.btnLogOut.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(153, 23);
            this.btnLogOut.TabIndex = 5;
            this.btnLogOut.Text = "Logout";
            this.btnLogOut.UseSelectable = true;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // btnSalesReport
            // 
            this.btnSalesReport.Location = new System.Drawing.Point(29, 75);
            this.btnSalesReport.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSalesReport.Name = "btnSalesReport";
            this.btnSalesReport.Size = new System.Drawing.Size(153, 23);
            this.btnSalesReport.TabIndex = 4;
            this.btnSalesReport.Text = "Sales Report";
            this.btnSalesReport.UseSelectable = true;
            this.btnSalesReport.Click += new System.EventHandler(this.btnSalesReport_Click);
            // 
            // SellerDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1108, 607);
            this.Controls.Add(this.metroPanel2);
            this.Controls.Add(this.Salesdisplay);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "SellerDashboard";
            this.Padding = new System.Windows.Forms.Padding(20, 74, 20, 20);
            this.Resizable = false;
            this.Text = "Seller Dashboard";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SellerDashboard_FormClosed);
            this.Load += new System.EventHandler(this.SellerDashboard_Load);
            this.metroPanel2.ResumeLayout(false);
            this.metroPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel Salesdisplay;
        private MetroFramework.Controls.MetroPanel metroPanel2;
        private MetroFramework.Controls.MetroButton btnLogOut;
        private MetroFramework.Controls.MetroButton btnSalesReport;
        private MetroFramework.Controls.MetroButton btnSales;
        private MetroFramework.Controls.MetroLabel metroLabel1;
    }
}