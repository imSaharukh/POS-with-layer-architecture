﻿
namespace SuperShop.App
{
    partial class AdminDashboard
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
            this.btnLogout = new MetroFramework.Controls.MetroPanel();
            this.btnUser = new MetroFramework.Controls.MetroButton();
            this.btnStats = new MetroFramework.Controls.MetroButton();
            this.metroButton5 = new MetroFramework.Controls.MetroButton();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.btnSalesReport = new MetroFramework.Controls.MetroButton();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.metroPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnLogout
            // 
            this.btnLogout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnLogout.HorizontalScrollbarBarColor = true;
            this.btnLogout.HorizontalScrollbarHighlightOnWheel = false;
            this.btnLogout.HorizontalScrollbarSize = 8;
            this.btnLogout.Location = new System.Drawing.Point(165, 60);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(651, 417);
            this.btnLogout.TabIndex = 1;
            this.btnLogout.VerticalScrollbarBarColor = true;
            this.btnLogout.VerticalScrollbarHighlightOnWheel = false;
            this.btnLogout.VerticalScrollbarSize = 8;
            this.btnLogout.Paint += new System.Windows.Forms.PaintEventHandler(this.metroPanel1_Paint);
            // 
            // btnUser
            // 
            this.btnUser.Location = new System.Drawing.Point(17, 15);
            this.btnUser.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnUser.Name = "btnUser";
            this.btnUser.Size = new System.Drawing.Size(115, 19);
            this.btnUser.TabIndex = 2;
            this.btnUser.Text = "Users";
            this.btnUser.UseSelectable = true;
            this.btnUser.Click += new System.EventHandler(this.btnUser_Click);
            // 
            // btnStats
            // 
            this.btnStats.Location = new System.Drawing.Point(17, 105);
            this.btnStats.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnStats.Name = "btnStats";
            this.btnStats.Size = new System.Drawing.Size(115, 19);
            this.btnStats.TabIndex = 5;
            this.btnStats.Text = "Statistics";
            this.btnStats.UseSelectable = true;
            this.btnStats.Click += new System.EventHandler(this.btnStats_Click);
            // 
            // metroButton5
            // 
            this.metroButton5.Location = new System.Drawing.Point(17, 57);
            this.metroButton5.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.metroButton5.Name = "metroButton5";
            this.metroButton5.Size = new System.Drawing.Size(115, 19);
            this.metroButton5.TabIndex = 6;
            this.metroButton5.Text = "Products";
            this.metroButton5.UseSelectable = true;
            this.metroButton5.Click += new System.EventHandler(this.btnProduct_Click);
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.btnSalesReport);
            this.metroPanel1.Controls.Add(this.metroLabel1);
            this.metroPanel1.Controls.Add(this.metroButton1);
            this.metroPanel1.Controls.Add(this.metroButton5);
            this.metroPanel1.Controls.Add(this.btnStats);
            this.metroPanel1.Controls.Add(this.btnUser);
            this.metroPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 8;
            this.metroPanel1.Location = new System.Drawing.Point(15, 60);
            this.metroPanel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(150, 417);
            this.metroPanel1.TabIndex = 0;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 8;
            this.metroPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.metroPanel1_Paint);
            // 
            // btnSalesReport
            // 
            this.btnSalesReport.Location = new System.Drawing.Point(17, 150);
            this.btnSalesReport.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSalesReport.Name = "btnSalesReport";
            this.btnSalesReport.Size = new System.Drawing.Size(115, 19);
            this.btnSalesReport.TabIndex = 9;
            this.btnSalesReport.Text = "Sales Report";
            this.btnSalesReport.UseSelectable = true;
            this.btnSalesReport.Click += new System.EventHandler(this.btnSalesReport_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(2, 383);
            this.metroLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(108, 19);
            this.metroLabel1.TabIndex = 8;
            this.metroLabel1.Text = "Version 0.1 [Beta]";
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(17, 355);
            this.metroButton1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(115, 19);
            this.metroButton1.TabIndex = 7;
            this.metroButton1.Text = "Log Out";
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.btnLogut_Click);
            // 
            // AdminDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(831, 493);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.metroPanel1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.Name = "AdminDashboard";
            this.Padding = new System.Windows.Forms.Padding(15, 60, 15, 16);
            this.Resizable = false;
            this.Text = "AdminDashboard";
            this.Load += new System.EventHandler(this.AdminDashboard_Load);
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private MetroFramework.Controls.MetroPanel btnLogout;
        private MetroFramework.Controls.MetroButton btnUser;
        private MetroFramework.Controls.MetroButton btnStats;
        private MetroFramework.Controls.MetroButton metroButton5;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroButton btnSalesReport;
    }
}