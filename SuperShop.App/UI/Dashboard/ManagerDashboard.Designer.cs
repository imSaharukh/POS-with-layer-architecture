
namespace SuperShop.App.UI.Dashboard
{
    partial class ManagerDashboard
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
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.metroPanel2 = new MetroFramework.Controls.MetroPanel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.btnSalesEmp = new MetroFramework.Controls.MetroButton();
            this.btnProductlist = new MetroFramework.Controls.MetroButton();
            this.btnStats = new MetroFramework.Controls.MetroButton();
            this.btnlogout = new MetroFramework.Controls.MetroButton();
            this.btnSalesReport = new MetroFramework.Controls.MetroButton();
            this.btnCustomize = new MetroFramework.Controls.MetroButton();
            this.metroPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroPanel1
            // 
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(216, 66);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(867, 518);
            this.metroPanel1.TabIndex = 0;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // metroPanel2
            // 
            this.metroPanel2.Controls.Add(this.btnCustomize);
            this.metroPanel2.Controls.Add(this.btnSalesReport);
            this.metroPanel2.Controls.Add(this.btnlogout);
            this.metroPanel2.Controls.Add(this.btnStats);
            this.metroPanel2.Controls.Add(this.btnProductlist);
            this.metroPanel2.Controls.Add(this.btnSalesEmp);
            this.metroPanel2.Controls.Add(this.metroLabel1);
            this.metroPanel2.HorizontalScrollbarBarColor = true;
            this.metroPanel2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel2.HorizontalScrollbarSize = 10;
            this.metroPanel2.Location = new System.Drawing.Point(10, 66);
            this.metroPanel2.Name = "metroPanel2";
            this.metroPanel2.Size = new System.Drawing.Size(200, 518);
            this.metroPanel2.TabIndex = 1;
            this.metroPanel2.VerticalScrollbarBarColor = true;
            this.metroPanel2.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel2.VerticalScrollbarSize = 10;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(3, 486);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(55, 20);
            this.metroLabel1.TabIndex = 2;
            this.metroLabel1.Text = "Version";
            // 
            // btnSalesEmp
            // 
            this.btnSalesEmp.Location = new System.Drawing.Point(23, 18);
            this.btnSalesEmp.Name = "btnSalesEmp";
            this.btnSalesEmp.Size = new System.Drawing.Size(153, 23);
            this.btnSalesEmp.TabIndex = 3;
            this.btnSalesEmp.Text = "Sales Employee";
            this.btnSalesEmp.UseSelectable = true;
            // 
            // btnProductlist
            // 
            this.btnProductlist.Location = new System.Drawing.Point(23, 67);
            this.btnProductlist.Name = "btnProductlist";
            this.btnProductlist.Size = new System.Drawing.Size(153, 23);
            this.btnProductlist.TabIndex = 4;
            this.btnProductlist.Text = "Products";
            this.btnProductlist.UseSelectable = true;
            // 
            // btnStats
            // 
            this.btnStats.Location = new System.Drawing.Point(23, 121);
            this.btnStats.Name = "btnStats";
            this.btnStats.Size = new System.Drawing.Size(153, 23);
            this.btnStats.TabIndex = 5;
            this.btnStats.Text = "Statistics";
            this.btnStats.UseSelectable = true;
            // 
            // btnlogout
            // 
            this.btnlogout.Location = new System.Drawing.Point(23, 449);
            this.btnlogout.Name = "btnlogout";
            this.btnlogout.Size = new System.Drawing.Size(153, 23);
            this.btnlogout.TabIndex = 6;
            this.btnlogout.Text = "Log Out";
            this.btnlogout.UseSelectable = true;
            // 
            // btnSalesReport
            // 
            this.btnSalesReport.Location = new System.Drawing.Point(23, 174);
            this.btnSalesReport.Name = "btnSalesReport";
            this.btnSalesReport.Size = new System.Drawing.Size(153, 23);
            this.btnSalesReport.TabIndex = 7;
            this.btnSalesReport.Text = "Sales Report";
            this.btnSalesReport.UseSelectable = true;
            // 
            // btnCustomize
            // 
            this.btnCustomize.Location = new System.Drawing.Point(23, 229);
            this.btnCustomize.Name = "btnCustomize";
            this.btnCustomize.Size = new System.Drawing.Size(153, 23);
            this.btnCustomize.TabIndex = 8;
            this.btnCustomize.Text = "Customization";
            this.btnCustomize.UseSelectable = true;
            // 
            // ManagerDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1108, 607);
            this.Controls.Add(this.metroPanel2);
            this.Controls.Add(this.metroPanel1);
            this.MaximizeBox = false;
            this.Name = "ManagerDashboard";
            this.Text = "Manager Dashboard";
            this.Load += new System.EventHandler(this.ManagerDashboard_Load);
            this.metroPanel2.ResumeLayout(false);
            this.metroPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroPanel metroPanel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroButton btnCustomize;
        private MetroFramework.Controls.MetroButton btnSalesReport;
        private MetroFramework.Controls.MetroButton btnlogout;
        private MetroFramework.Controls.MetroButton btnStats;
        private MetroFramework.Controls.MetroButton btnProductlist;
        private MetroFramework.Controls.MetroButton btnSalesEmp;
    }
}