
namespace SuperShop.App
{
    partial class AddProductForm
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
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.lblErrProductName = new System.Windows.Forms.Label();
            this.txtProductName = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.cmbCategory = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.lblErrPrice = new System.Windows.Forms.Label();
            this.txtPurchasePrice = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.cmbUnit = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.lblErrStock = new System.Windows.Forms.Label();
            this.txtStock = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.lblErrUnitPrice = new System.Windows.Forms.Label();
            this.txtUnitPrice = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.dtExpireDate = new MetroFramework.Controls.MetroDateTime();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.metroLabel1);
            this.flowLayoutPanel1.Controls.Add(this.lblErrProductName);
            this.flowLayoutPanel1.Controls.Add(this.txtProductName);
            this.flowLayoutPanel1.Controls.Add(this.metroLabel4);
            this.flowLayoutPanel1.Controls.Add(this.cmbCategory);
            this.flowLayoutPanel1.Controls.Add(this.metroLabel5);
            this.flowLayoutPanel1.Controls.Add(this.lblErrPrice);
            this.flowLayoutPanel1.Controls.Add(this.txtPurchasePrice);
            this.flowLayoutPanel1.Controls.Add(this.metroLabel7);
            this.flowLayoutPanel1.Controls.Add(this.cmbUnit);
            this.flowLayoutPanel1.Controls.Add(this.metroLabel3);
            this.flowLayoutPanel1.Controls.Add(this.lblErrStock);
            this.flowLayoutPanel1.Controls.Add(this.txtStock);
            this.flowLayoutPanel1.Controls.Add(this.metroLabel2);
            this.flowLayoutPanel1.Controls.Add(this.lblErrUnitPrice);
            this.flowLayoutPanel1.Controls.Add(this.txtUnitPrice);
            this.flowLayoutPanel1.Controls.Add(this.metroLabel6);
            this.flowLayoutPanel1.Controls.Add(this.dtExpireDate);
            this.flowLayoutPanel1.Controls.Add(this.metroButton1);
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.ForeColor = System.Drawing.Color.Red;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(108, 51);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(263, 420);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(2, 0);
            this.metroLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(95, 19);
            this.metroLabel1.TabIndex = 19;
            this.metroLabel1.Text = "Product Name";
            // 
            // lblErrProductName
            // 
            this.lblErrProductName.AutoSize = true;
            this.lblErrProductName.ForeColor = System.Drawing.Color.Red;
            this.lblErrProductName.Location = new System.Drawing.Point(2, 19);
            this.lblErrProductName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblErrProductName.Name = "lblErrProductName";
            this.lblErrProductName.Size = new System.Drawing.Size(35, 13);
            this.lblErrProductName.TabIndex = 34;
            this.lblErrProductName.Text = "label1";
            this.lblErrProductName.Click += new System.EventHandler(this.lblErrName_Click);
            // 
            // txtProductName
            // 
            // 
            // 
            // 
            this.txtProductName.CustomButton.Image = null;
            this.txtProductName.CustomButton.Location = new System.Drawing.Point(92, 2);
            this.txtProductName.CustomButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtProductName.CustomButton.Name = "";
            this.txtProductName.CustomButton.Size = new System.Drawing.Size(14, 15);
            this.txtProductName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtProductName.CustomButton.TabIndex = 1;
            this.txtProductName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtProductName.CustomButton.UseSelectable = true;
            this.txtProductName.CustomButton.Visible = false;
            this.txtProductName.Lines = new string[0];
            this.txtProductName.Location = new System.Drawing.Point(2, 34);
            this.txtProductName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtProductName.MaxLength = 32767;
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.PasswordChar = '\0';
            this.txtProductName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtProductName.SelectedText = "";
            this.txtProductName.SelectionLength = 0;
            this.txtProductName.SelectionStart = 0;
            this.txtProductName.ShortcutsEnabled = true;
            this.txtProductName.Size = new System.Drawing.Size(144, 24);
            this.txtProductName.TabIndex = 27;
            this.txtProductName.UseSelectable = true;
            this.txtProductName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtProductName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(2, 60);
            this.metroLabel4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(64, 19);
            this.metroLabel4.TabIndex = 22;
            this.metroLabel4.Text = "Category";
            // 
            // cmbCategory
            // 
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.IntegralHeight = false;
            this.cmbCategory.ItemHeight = 23;
            this.cmbCategory.Location = new System.Drawing.Point(2, 81);
            this.cmbCategory.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(145, 29);
            this.cmbCategory.TabIndex = 31;
            this.cmbCategory.UseSelectable = true;
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(2, 113);
            this.metroLabel5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(94, 19);
            this.metroLabel5.TabIndex = 23;
            this.metroLabel5.Text = "Purchase Price";
            // 
            // lblErrPrice
            // 
            this.lblErrPrice.AutoSize = true;
            this.lblErrPrice.ForeColor = System.Drawing.Color.Red;
            this.lblErrPrice.Location = new System.Drawing.Point(2, 132);
            this.lblErrPrice.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblErrPrice.Name = "lblErrPrice";
            this.lblErrPrice.Size = new System.Drawing.Size(35, 13);
            this.lblErrPrice.TabIndex = 35;
            this.lblErrPrice.Text = "label2";
            // 
            // txtPurchasePrice
            // 
            // 
            // 
            // 
            this.txtPurchasePrice.CustomButton.Image = null;
            this.txtPurchasePrice.CustomButton.Location = new System.Drawing.Point(92, 2);
            this.txtPurchasePrice.CustomButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtPurchasePrice.CustomButton.Name = "";
            this.txtPurchasePrice.CustomButton.Size = new System.Drawing.Size(14, 15);
            this.txtPurchasePrice.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPurchasePrice.CustomButton.TabIndex = 1;
            this.txtPurchasePrice.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPurchasePrice.CustomButton.UseSelectable = true;
            this.txtPurchasePrice.CustomButton.Visible = false;
            this.txtPurchasePrice.Lines = new string[0];
            this.txtPurchasePrice.Location = new System.Drawing.Point(2, 147);
            this.txtPurchasePrice.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtPurchasePrice.MaxLength = 32767;
            this.txtPurchasePrice.Name = "txtPurchasePrice";
            this.txtPurchasePrice.PasswordChar = '\0';
            this.txtPurchasePrice.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPurchasePrice.SelectedText = "";
            this.txtPurchasePrice.SelectionLength = 0;
            this.txtPurchasePrice.SelectionStart = 0;
            this.txtPurchasePrice.ShortcutsEnabled = true;
            this.txtPurchasePrice.Size = new System.Drawing.Size(144, 24);
            this.txtPurchasePrice.TabIndex = 26;
            this.txtPurchasePrice.UseSelectable = true;
            this.txtPurchasePrice.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPurchasePrice.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(2, 173);
            this.metroLabel7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(38, 19);
            this.metroLabel7.TabIndex = 32;
            this.metroLabel7.Text = "UNIT";
            // 
            // cmbUnit
            // 
            this.cmbUnit.FormattingEnabled = true;
            this.cmbUnit.IntegralHeight = false;
            this.cmbUnit.ItemHeight = 23;
            this.cmbUnit.Location = new System.Drawing.Point(2, 194);
            this.cmbUnit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbUnit.Name = "cmbUnit";
            this.cmbUnit.Size = new System.Drawing.Size(145, 29);
            this.cmbUnit.TabIndex = 39;
            this.cmbUnit.UseSelectable = true;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(2, 226);
            this.metroLabel3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(40, 19);
            this.metroLabel3.TabIndex = 21;
            this.metroLabel3.Text = "Stock";
            // 
            // lblErrStock
            // 
            this.lblErrStock.AutoSize = true;
            this.lblErrStock.ForeColor = System.Drawing.Color.Red;
            this.lblErrStock.Location = new System.Drawing.Point(2, 245);
            this.lblErrStock.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblErrStock.Name = "lblErrStock";
            this.lblErrStock.Size = new System.Drawing.Size(35, 13);
            this.lblErrStock.TabIndex = 37;
            this.lblErrStock.Text = "label4";
            // 
            // txtStock
            // 
            // 
            // 
            // 
            this.txtStock.CustomButton.Image = null;
            this.txtStock.CustomButton.Location = new System.Drawing.Point(92, 2);
            this.txtStock.CustomButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtStock.CustomButton.Name = "";
            this.txtStock.CustomButton.Size = new System.Drawing.Size(14, 15);
            this.txtStock.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtStock.CustomButton.TabIndex = 1;
            this.txtStock.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtStock.CustomButton.UseSelectable = true;
            this.txtStock.CustomButton.Visible = false;
            this.txtStock.Lines = new string[0];
            this.txtStock.Location = new System.Drawing.Point(2, 260);
            this.txtStock.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtStock.MaxLength = 32767;
            this.txtStock.Name = "txtStock";
            this.txtStock.PasswordChar = '\0';
            this.txtStock.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtStock.SelectedText = "";
            this.txtStock.SelectionLength = 0;
            this.txtStock.SelectionStart = 0;
            this.txtStock.ShortcutsEnabled = true;
            this.txtStock.Size = new System.Drawing.Size(144, 24);
            this.txtStock.TabIndex = 25;
            this.txtStock.UseSelectable = true;
            this.txtStock.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtStock.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(2, 286);
            this.metroLabel2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(65, 19);
            this.metroLabel2.TabIndex = 20;
            this.metroLabel2.Text = "Unit Price";
            // 
            // lblErrUnitPrice
            // 
            this.lblErrUnitPrice.AutoSize = true;
            this.lblErrUnitPrice.ForeColor = System.Drawing.Color.Red;
            this.lblErrUnitPrice.Location = new System.Drawing.Point(2, 305);
            this.lblErrUnitPrice.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblErrUnitPrice.Name = "lblErrUnitPrice";
            this.lblErrUnitPrice.Size = new System.Drawing.Size(35, 13);
            this.lblErrUnitPrice.TabIndex = 38;
            this.lblErrUnitPrice.Text = "label5";
            // 
            // txtUnitPrice
            // 
            // 
            // 
            // 
            this.txtUnitPrice.CustomButton.Image = null;
            this.txtUnitPrice.CustomButton.Location = new System.Drawing.Point(92, 2);
            this.txtUnitPrice.CustomButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtUnitPrice.CustomButton.Name = "";
            this.txtUnitPrice.CustomButton.Size = new System.Drawing.Size(14, 15);
            this.txtUnitPrice.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtUnitPrice.CustomButton.TabIndex = 1;
            this.txtUnitPrice.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtUnitPrice.CustomButton.UseSelectable = true;
            this.txtUnitPrice.CustomButton.Visible = false;
            this.txtUnitPrice.Lines = new string[0];
            this.txtUnitPrice.Location = new System.Drawing.Point(2, 320);
            this.txtUnitPrice.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtUnitPrice.MaxLength = 32767;
            this.txtUnitPrice.Name = "txtUnitPrice";
            this.txtUnitPrice.PasswordChar = '\0';
            this.txtUnitPrice.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtUnitPrice.SelectedText = "";
            this.txtUnitPrice.SelectionLength = 0;
            this.txtUnitPrice.SelectionStart = 0;
            this.txtUnitPrice.ShortcutsEnabled = true;
            this.txtUnitPrice.Size = new System.Drawing.Size(144, 24);
            this.txtUnitPrice.TabIndex = 24;
            this.txtUnitPrice.UseSelectable = true;
            this.txtUnitPrice.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtUnitPrice.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtUnitPrice.Click += new System.EventHandler(this.txtUnitPrice_Click);
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(2, 346);
            this.metroLabel6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(76, 19);
            this.metroLabel6.TabIndex = 29;
            this.metroLabel6.Text = "Expire Date";
            // 
            // dtExpireDate
            // 
            this.dtExpireDate.Location = new System.Drawing.Point(2, 367);
            this.dtExpireDate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtExpireDate.MinimumSize = new System.Drawing.Size(4, 30);
            this.dtExpireDate.Name = "dtExpireDate";
            this.dtExpireDate.Size = new System.Drawing.Size(145, 30);
            this.dtExpireDate.TabIndex = 30;
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(151, 2);
            this.metroButton1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(144, 24);
            this.metroButton1.TabIndex = 28;
            this.metroButton1.Text = "Confirm";
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // AddProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 485);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.Name = "AddProductForm";
            this.Padding = new System.Windows.Forms.Padding(15, 60, 15, 16);
            this.Text = "Add Product Details";
            this.Load += new System.EventHandler(this.AddProductForm_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.Label lblErrProductName;
        private MetroFramework.Controls.MetroTextBox txtProductName;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroComboBox cmbCategory;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private System.Windows.Forms.Label lblErrPrice;
        private MetroFramework.Controls.MetroTextBox txtPurchasePrice;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private System.Windows.Forms.Label lblErrStock;
        private MetroFramework.Controls.MetroTextBox txtStock;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private System.Windows.Forms.Label lblErrUnitPrice;
        private MetroFramework.Controls.MetroTextBox txtUnitPrice;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroDateTime dtExpireDate;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroComboBox cmbUnit;
    }
}