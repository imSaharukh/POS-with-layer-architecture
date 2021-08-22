
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
            this.managerPanel2 = new MetroFramework.Controls.MetroPanel();
            this.metroPanel2 = new MetroFramework.Controls.MetroPanel();
            this.btnSalesReport = new MetroFramework.Controls.MetroButton();
            this.btnlogout = new MetroFramework.Controls.MetroButton();
            this.btnStats = new MetroFramework.Controls.MetroButton();
            this.btnProductlist = new MetroFramework.Controls.MetroButton();
            this.btnSalesEmp = new MetroFramework.Controls.MetroButton();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // managerPanel2
            // 
            this.managerPanel2.HorizontalScrollbarBarColor = true;
            this.managerPanel2.HorizontalScrollbarHighlightOnWheel = false;
            this.managerPanel2.HorizontalScrollbarSize = 8;
            this.managerPanel2.Location = new System.Drawing.Point(162, 54);
            this.managerPanel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.managerPanel2.Name = "managerPanel2";
            this.managerPanel2.Size = new System.Drawing.Size(650, 421);
            this.managerPanel2.TabIndex = 0;
            this.managerPanel2.VerticalScrollbarBarColor = true;
            this.managerPanel2.VerticalScrollbarHighlightOnWheel = false;
            this.managerPanel2.VerticalScrollbarSize = 8;
            // 
            // metroPanel2
            // 
            this.metroPanel2.Controls.Add(this.btnSalesReport);
            this.metroPanel2.Controls.Add(this.btnlogout);
            this.metroPanel2.Controls.Add(this.btnStats);
            this.metroPanel2.Controls.Add(this.btnProductlist);
            this.metroPanel2.Controls.Add(this.btnSalesEmp);
            this.metroPanel2.Controls.Add(this.metroLabel1);
            this.metroPanel2.HorizontalScrollbarBarColor = true;
            this.metroPanel2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel2.HorizontalScrollbarSize = 8;
            this.metroPanel2.Location = new System.Drawing.Point(8, 54);
            this.metroPanel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.metroPanel2.Name = "metroPanel2";
            this.metroPanel2.Size = new System.Drawing.Size(150, 421);
            this.metroPanel2.TabIndex = 1;
            this.metroPanel2.VerticalScrollbarBarColor = true;
            this.metroPanel2.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel2.VerticalScrollbarSize = 8;
            // 
            // btnSalesReport
            // 
            this.btnSalesReport.Location = new System.Drawing.Point(17, 141);
            this.btnSalesReport.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSalesReport.Name = "btnSalesReport";
            this.btnSalesReport.Size = new System.Drawing.Size(115, 19);
            this.btnSalesReport.TabIndex = 7;
            this.btnSalesReport.Text = "Sales Report";
            this.btnSalesReport.UseSelectable = true;
            this.btnSalesReport.Click += new System.EventHandler(this.btnSalesReport_Click);
            // 
            // btnlogout
            // 
            this.btnlogout.Location = new System.Drawing.Point(17, 356);
            this.btnlogout.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnlogout.Name = "btnlogout";
            this.btnlogout.Size = new System.Drawing.Size(115, 19);
            this.btnlogout.TabIndex = 6;
            this.btnlogout.Text = "Log Out";
            this.btnlogout.UseSelectable = true;
            this.btnlogout.Click += new System.EventHandler(this.btnlogout_Click);
            // 
            // btnStats
            // 
            this.btnStats.Location = new System.Drawing.Point(17, 98);
            this.btnStats.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnStats.Name = "btnStats";
            this.btnStats.Size = new System.Drawing.Size(115, 19);
            this.btnStats.TabIndex = 5;
            this.btnStats.Text = "Statistics";
            this.btnStats.UseSelectable = true;
            this.btnStats.Click += new System.EventHandler(this.btnStats_Click);
            // 
            // btnProductlist
            // 
            this.btnProductlist.Location = new System.Drawing.Point(17, 54);
            this.btnProductlist.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnProductlist.Name = "btnProductlist";
            this.btnProductlist.Size = new System.Drawing.Size(115, 19);
            this.btnProductlist.TabIndex = 4;
            this.btnProductlist.Text = "Products";
            this.btnProductlist.UseSelectable = true;
            this.btnProductlist.Click += new System.EventHandler(this.btnProductlist_Click);
            // 
            // btnSalesEmp
            // 
            this.btnSalesEmp.Location = new System.Drawing.Point(17, 15);
            this.btnSalesEmp.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSalesEmp.Name = "btnSalesEmp";
            this.btnSalesEmp.Size = new System.Drawing.Size(115, 19);
            this.btnSalesEmp.TabIndex = 3;
            this.btnSalesEmp.Text = "Sales Employee";
            this.btnSalesEmp.UseSelectable = true;
            this.btnSalesEmp.Click += new System.EventHandler(this.btnSalesEmp_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(2, 385);
            this.metroLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(108, 19);
            this.metroLabel1.TabIndex = 2;
            this.metroLabel1.Text = "Version 0.1 [Beta]";
            // 
            // ManagerDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(831, 493);
            this.Controls.Add(this.metroPanel2);
            this.Controls.Add(this.managerPanel2);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.Name = "ManagerDashboard";
            this.Padding = new System.Windows.Forms.Padding(15, 60, 15, 16);
            this.Resizable = false;
            this.Text = "Manager Dashboard";
            this.Load += new System.EventHandler(this.ManagerDashboard_Load);
            this.metroPanel2.ResumeLayout(false);
            this.metroPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel managerPanel2;
        private MetroFramework.Controls.MetroPanel metroPanel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroButton btnSalesReport;
        private MetroFramework.Controls.MetroButton btnlogout;
        private MetroFramework.Controls.MetroButton btnStats;
        private MetroFramework.Controls.MetroButton btnProductlist;
        private MetroFramework.Controls.MetroButton btnSalesEmp;
    }
}