
namespace SuperShop.App.UI.Product
{
    partial class AddCatagory
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.lblErrAddCategory = new MetroFramework.Controls.MetroLabel();
            this.txtCatagory = new MetroFramework.Controls.MetroTextBox();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.metroLabel2);
            this.flowLayoutPanel1.Controls.Add(this.lblErrAddCategory);
            this.flowLayoutPanel1.Controls.Add(this.txtCatagory);
            this.flowLayoutPanel1.Controls.Add(this.metroButton1);
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(44, 56);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(150, 120);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(2, 0);
            this.metroLabel2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(64, 19);
            this.metroLabel2.TabIndex = 4;
            this.metroLabel2.Text = "Catagory";
            // 
            // lblErrAddCategory
            // 
            this.lblErrAddCategory.AutoSize = true;
            this.lblErrAddCategory.ForeColor = System.Drawing.Color.Red;
            this.lblErrAddCategory.Location = new System.Drawing.Point(2, 19);
            this.lblErrAddCategory.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblErrAddCategory.Name = "lblErrAddCategory";
            this.lblErrAddCategory.Size = new System.Drawing.Size(39, 19);
            this.lblErrAddCategory.TabIndex = 2;
            this.lblErrAddCategory.Text = "error";
            this.lblErrAddCategory.UseCustomForeColor = true;
            this.lblErrAddCategory.Click += new System.EventHandler(this.metroLabel1_Click);
            // 
            // txtCatagory
            // 
            // 
            // 
            // 
            this.txtCatagory.CustomButton.Image = null;
            this.txtCatagory.CustomButton.Location = new System.Drawing.Point(100, 1);
            this.txtCatagory.CustomButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtCatagory.CustomButton.Name = "";
            this.txtCatagory.CustomButton.Size = new System.Drawing.Size(13, 14);
            this.txtCatagory.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtCatagory.CustomButton.TabIndex = 1;
            this.txtCatagory.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtCatagory.CustomButton.UseSelectable = true;
            this.txtCatagory.CustomButton.Visible = false;
            this.txtCatagory.Lines = new string[0];
            this.txtCatagory.Location = new System.Drawing.Point(2, 40);
            this.txtCatagory.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtCatagory.MaxLength = 32767;
            this.txtCatagory.Name = "txtCatagory";
            this.txtCatagory.PasswordChar = '\0';
            this.txtCatagory.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCatagory.SelectedText = "";
            this.txtCatagory.SelectionLength = 0;
            this.txtCatagory.SelectionStart = 0;
            this.txtCatagory.ShortcutsEnabled = true;
            this.txtCatagory.Size = new System.Drawing.Size(151, 19);
            this.txtCatagory.TabIndex = 3;
            this.txtCatagory.UseSelectable = true;
            this.txtCatagory.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtCatagory.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(2, 63);
            this.metroButton1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(151, 19);
            this.metroButton1.TabIndex = 5;
            this.metroButton1.Text = "Add";
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // AddCatagory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(236, 214);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.Name = "AddCatagory";
            this.Padding = new System.Windows.Forms.Padding(15, 60, 15, 16);
            this.Resizable = false;
            this.Text = "Add Catagory";
            this.Load += new System.EventHandler(this.AddCatagory_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel lblErrAddCategory;
        private MetroFramework.Controls.MetroTextBox txtCatagory;
        private MetroFramework.Controls.MetroButton metroButton1;
    }
}