
namespace SuperShop.App.UI.MiniStatement
{
    partial class SalesSlip
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SalesSlip));
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.SlipPrint = new MetroFramework.Controls.MetroButton();
            this.txtSubtotal = new MetroFramework.Controls.MetroTextBox();
            this.txtDiscountBDT = new MetroFramework.Controls.MetroTextBox();
            this.txtTotalBDT = new MetroFramework.Controls.MetroTextBox();
            this.txtExchange = new MetroFramework.Controls.MetroTextBox();
            this.txtPaidAmount = new MetroFramework.Controls.MetroTextBox();
            this.txtInvoiceNo = new MetroFramework.Controls.MetroTextBox();
            this.txtSellerID = new MetroFramework.Controls.MetroTextBox();
            this.txtDate = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel16 = new MetroFramework.Controls.MetroLabel();
            this.dgvProducts = new MetroFramework.Controls.MetroGrid();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.metroLabel15 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel14 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel12 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel11 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel10 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.lblContactNo = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.metroPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).BeginInit();
            this.SuspendLayout();
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.SlipPrint);
            this.metroPanel1.Controls.Add(this.txtSubtotal);
            this.metroPanel1.Controls.Add(this.txtDiscountBDT);
            this.metroPanel1.Controls.Add(this.txtTotalBDT);
            this.metroPanel1.Controls.Add(this.txtExchange);
            this.metroPanel1.Controls.Add(this.txtPaidAmount);
            this.metroPanel1.Controls.Add(this.txtInvoiceNo);
            this.metroPanel1.Controls.Add(this.txtSellerID);
            this.metroPanel1.Controls.Add(this.txtDate);
            this.metroPanel1.Controls.Add(this.metroLabel16);
            this.metroPanel1.Controls.Add(this.dgvProducts);
            this.metroPanel1.Controls.Add(this.metroLabel15);
            this.metroPanel1.Controls.Add(this.metroLabel14);
            this.metroPanel1.Controls.Add(this.metroLabel12);
            this.metroPanel1.Controls.Add(this.metroLabel11);
            this.metroPanel1.Controls.Add(this.metroLabel10);
            this.metroPanel1.Controls.Add(this.metroLabel8);
            this.metroPanel1.Controls.Add(this.metroLabel7);
            this.metroPanel1.Controls.Add(this.metroLabel6);
            this.metroPanel1.Controls.Add(this.metroLabel5);
            this.metroPanel1.Controls.Add(this.lblContactNo);
            this.metroPanel1.Controls.Add(this.metroLabel3);
            this.metroPanel1.Controls.Add(this.metroLabel2);
            this.metroPanel1.Controls.Add(this.metroLabel1);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 8;
            this.metroPanel1.Location = new System.Drawing.Point(4, 51);
            this.metroPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(242, 574);
            this.metroPanel1.TabIndex = 0;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 8;
            // 
            // SlipPrint
            // 
            this.SlipPrint.BackColor = System.Drawing.Color.LightSeaGreen;
            this.SlipPrint.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.SlipPrint.Location = new System.Drawing.Point(86, 548);
            this.SlipPrint.Margin = new System.Windows.Forms.Padding(2);
            this.SlipPrint.Name = "SlipPrint";
            this.SlipPrint.Size = new System.Drawing.Size(56, 19);
            this.SlipPrint.TabIndex = 29;
            this.SlipPrint.Text = "Print";
            this.SlipPrint.UseCustomBackColor = true;
            this.SlipPrint.UseCustomForeColor = true;
            this.SlipPrint.UseSelectable = true;
            this.SlipPrint.Click += new System.EventHandler(this.SlipPrint_Click);
            // 
            // txtSubtotal
            // 
            // 
            // 
            // 
            this.txtSubtotal.CustomButton.Image = null;
            this.txtSubtotal.CustomButton.Location = new System.Drawing.Point(50, 2);
            this.txtSubtotal.CustomButton.Margin = new System.Windows.Forms.Padding(2);
            this.txtSubtotal.CustomButton.Name = "";
            this.txtSubtotal.CustomButton.Size = new System.Drawing.Size(11, 11);
            this.txtSubtotal.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtSubtotal.CustomButton.TabIndex = 1;
            this.txtSubtotal.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtSubtotal.CustomButton.UseSelectable = true;
            this.txtSubtotal.CustomButton.Visible = false;
            this.txtSubtotal.Lines = new string[0];
            this.txtSubtotal.Location = new System.Drawing.Point(176, 468);
            this.txtSubtotal.Margin = new System.Windows.Forms.Padding(2);
            this.txtSubtotal.MaxLength = 32767;
            this.txtSubtotal.Name = "txtSubtotal";
            this.txtSubtotal.PasswordChar = '\0';
            this.txtSubtotal.ReadOnly = true;
            this.txtSubtotal.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSubtotal.SelectedText = "";
            this.txtSubtotal.SelectionLength = 0;
            this.txtSubtotal.SelectionStart = 0;
            this.txtSubtotal.ShortcutsEnabled = true;
            this.txtSubtotal.Size = new System.Drawing.Size(64, 16);
            this.txtSubtotal.TabIndex = 27;
            this.txtSubtotal.UseSelectable = true;
            this.txtSubtotal.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtSubtotal.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtDiscountBDT
            // 
            // 
            // 
            // 
            this.txtDiscountBDT.CustomButton.Image = null;
            this.txtDiscountBDT.CustomButton.Location = new System.Drawing.Point(50, 2);
            this.txtDiscountBDT.CustomButton.Margin = new System.Windows.Forms.Padding(2);
            this.txtDiscountBDT.CustomButton.Name = "";
            this.txtDiscountBDT.CustomButton.Size = new System.Drawing.Size(11, 11);
            this.txtDiscountBDT.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtDiscountBDT.CustomButton.TabIndex = 1;
            this.txtDiscountBDT.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtDiscountBDT.CustomButton.UseSelectable = true;
            this.txtDiscountBDT.CustomButton.Visible = false;
            this.txtDiscountBDT.Lines = new string[0];
            this.txtDiscountBDT.Location = new System.Drawing.Point(176, 448);
            this.txtDiscountBDT.Margin = new System.Windows.Forms.Padding(2);
            this.txtDiscountBDT.MaxLength = 32767;
            this.txtDiscountBDT.Name = "txtDiscountBDT";
            this.txtDiscountBDT.PasswordChar = '\0';
            this.txtDiscountBDT.ReadOnly = true;
            this.txtDiscountBDT.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtDiscountBDT.SelectedText = "";
            this.txtDiscountBDT.SelectionLength = 0;
            this.txtDiscountBDT.SelectionStart = 0;
            this.txtDiscountBDT.ShortcutsEnabled = true;
            this.txtDiscountBDT.Size = new System.Drawing.Size(64, 16);
            this.txtDiscountBDT.TabIndex = 26;
            this.txtDiscountBDT.UseSelectable = true;
            this.txtDiscountBDT.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtDiscountBDT.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtTotalBDT
            // 
            // 
            // 
            // 
            this.txtTotalBDT.CustomButton.Image = null;
            this.txtTotalBDT.CustomButton.Location = new System.Drawing.Point(50, 2);
            this.txtTotalBDT.CustomButton.Margin = new System.Windows.Forms.Padding(2);
            this.txtTotalBDT.CustomButton.Name = "";
            this.txtTotalBDT.CustomButton.Size = new System.Drawing.Size(11, 11);
            this.txtTotalBDT.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtTotalBDT.CustomButton.TabIndex = 1;
            this.txtTotalBDT.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtTotalBDT.CustomButton.UseSelectable = true;
            this.txtTotalBDT.CustomButton.Visible = false;
            this.txtTotalBDT.Lines = new string[0];
            this.txtTotalBDT.Location = new System.Drawing.Point(176, 429);
            this.txtTotalBDT.Margin = new System.Windows.Forms.Padding(2);
            this.txtTotalBDT.MaxLength = 32767;
            this.txtTotalBDT.Name = "txtTotalBDT";
            this.txtTotalBDT.PasswordChar = '\0';
            this.txtTotalBDT.ReadOnly = true;
            this.txtTotalBDT.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtTotalBDT.SelectedText = "";
            this.txtTotalBDT.SelectionLength = 0;
            this.txtTotalBDT.SelectionStart = 0;
            this.txtTotalBDT.ShortcutsEnabled = true;
            this.txtTotalBDT.Size = new System.Drawing.Size(64, 16);
            this.txtTotalBDT.TabIndex = 25;
            this.txtTotalBDT.UseSelectable = true;
            this.txtTotalBDT.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtTotalBDT.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtExchange
            // 
            // 
            // 
            // 
            this.txtExchange.CustomButton.Image = null;
            this.txtExchange.CustomButton.Location = new System.Drawing.Point(50, 2);
            this.txtExchange.CustomButton.Margin = new System.Windows.Forms.Padding(2);
            this.txtExchange.CustomButton.Name = "";
            this.txtExchange.CustomButton.Size = new System.Drawing.Size(11, 11);
            this.txtExchange.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtExchange.CustomButton.TabIndex = 1;
            this.txtExchange.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtExchange.CustomButton.UseSelectable = true;
            this.txtExchange.CustomButton.Visible = false;
            this.txtExchange.Lines = new string[0];
            this.txtExchange.Location = new System.Drawing.Point(176, 505);
            this.txtExchange.Margin = new System.Windows.Forms.Padding(2);
            this.txtExchange.MaxLength = 32767;
            this.txtExchange.Name = "txtExchange";
            this.txtExchange.PasswordChar = '\0';
            this.txtExchange.ReadOnly = true;
            this.txtExchange.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtExchange.SelectedText = "";
            this.txtExchange.SelectionLength = 0;
            this.txtExchange.SelectionStart = 0;
            this.txtExchange.ShortcutsEnabled = true;
            this.txtExchange.Size = new System.Drawing.Size(64, 16);
            this.txtExchange.TabIndex = 23;
            this.txtExchange.UseSelectable = true;
            this.txtExchange.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtExchange.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtPaidAmount
            // 
            // 
            // 
            // 
            this.txtPaidAmount.CustomButton.Image = null;
            this.txtPaidAmount.CustomButton.Location = new System.Drawing.Point(50, 2);
            this.txtPaidAmount.CustomButton.Margin = new System.Windows.Forms.Padding(2);
            this.txtPaidAmount.CustomButton.Name = "";
            this.txtPaidAmount.CustomButton.Size = new System.Drawing.Size(11, 11);
            this.txtPaidAmount.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPaidAmount.CustomButton.TabIndex = 1;
            this.txtPaidAmount.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPaidAmount.CustomButton.UseSelectable = true;
            this.txtPaidAmount.CustomButton.Visible = false;
            this.txtPaidAmount.Lines = new string[0];
            this.txtPaidAmount.Location = new System.Drawing.Point(176, 488);
            this.txtPaidAmount.Margin = new System.Windows.Forms.Padding(2);
            this.txtPaidAmount.MaxLength = 32767;
            this.txtPaidAmount.Name = "txtPaidAmount";
            this.txtPaidAmount.PasswordChar = '\0';
            this.txtPaidAmount.ReadOnly = true;
            this.txtPaidAmount.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPaidAmount.SelectedText = "";
            this.txtPaidAmount.SelectionLength = 0;
            this.txtPaidAmount.SelectionStart = 0;
            this.txtPaidAmount.ShortcutsEnabled = true;
            this.txtPaidAmount.Size = new System.Drawing.Size(64, 16);
            this.txtPaidAmount.TabIndex = 22;
            this.txtPaidAmount.UseSelectable = true;
            this.txtPaidAmount.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPaidAmount.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtInvoiceNo
            // 
            // 
            // 
            // 
            this.txtInvoiceNo.CustomButton.Image = null;
            this.txtInvoiceNo.CustomButton.Location = new System.Drawing.Point(136, 1);
            this.txtInvoiceNo.CustomButton.Margin = new System.Windows.Forms.Padding(2);
            this.txtInvoiceNo.CustomButton.Name = "";
            this.txtInvoiceNo.CustomButton.Size = new System.Drawing.Size(17, 17);
            this.txtInvoiceNo.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtInvoiceNo.CustomButton.TabIndex = 1;
            this.txtInvoiceNo.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtInvoiceNo.CustomButton.UseSelectable = true;
            this.txtInvoiceNo.CustomButton.Visible = false;
            this.txtInvoiceNo.Lines = new string[0];
            this.txtInvoiceNo.Location = new System.Drawing.Point(76, 68);
            this.txtInvoiceNo.Margin = new System.Windows.Forms.Padding(2);
            this.txtInvoiceNo.MaxLength = 32767;
            this.txtInvoiceNo.Name = "txtInvoiceNo";
            this.txtInvoiceNo.PasswordChar = '\0';
            this.txtInvoiceNo.ReadOnly = true;
            this.txtInvoiceNo.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtInvoiceNo.SelectedText = "";
            this.txtInvoiceNo.SelectionLength = 0;
            this.txtInvoiceNo.SelectionStart = 0;
            this.txtInvoiceNo.ShortcutsEnabled = true;
            this.txtInvoiceNo.Size = new System.Drawing.Size(154, 19);
            this.txtInvoiceNo.TabIndex = 21;
            this.txtInvoiceNo.UseSelectable = true;
            this.txtInvoiceNo.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtInvoiceNo.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtSellerID
            // 
            // 
            // 
            // 
            this.txtSellerID.CustomButton.Image = null;
            this.txtSellerID.CustomButton.Location = new System.Drawing.Point(136, 1);
            this.txtSellerID.CustomButton.Margin = new System.Windows.Forms.Padding(2);
            this.txtSellerID.CustomButton.Name = "";
            this.txtSellerID.CustomButton.Size = new System.Drawing.Size(17, 17);
            this.txtSellerID.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtSellerID.CustomButton.TabIndex = 1;
            this.txtSellerID.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtSellerID.CustomButton.UseSelectable = true;
            this.txtSellerID.CustomButton.Visible = false;
            this.txtSellerID.Lines = new string[0];
            this.txtSellerID.Location = new System.Drawing.Point(76, 117);
            this.txtSellerID.Margin = new System.Windows.Forms.Padding(2);
            this.txtSellerID.MaxLength = 32767;
            this.txtSellerID.Name = "txtSellerID";
            this.txtSellerID.PasswordChar = '\0';
            this.txtSellerID.ReadOnly = true;
            this.txtSellerID.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSellerID.SelectedText = "";
            this.txtSellerID.SelectionLength = 0;
            this.txtSellerID.SelectionStart = 0;
            this.txtSellerID.ShortcutsEnabled = true;
            this.txtSellerID.Size = new System.Drawing.Size(154, 19);
            this.txtSellerID.TabIndex = 20;
            this.txtSellerID.UseSelectable = true;
            this.txtSellerID.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtSellerID.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtDate
            // 
            // 
            // 
            // 
            this.txtDate.CustomButton.Image = null;
            this.txtDate.CustomButton.Location = new System.Drawing.Point(136, 1);
            this.txtDate.CustomButton.Margin = new System.Windows.Forms.Padding(2);
            this.txtDate.CustomButton.Name = "";
            this.txtDate.CustomButton.Size = new System.Drawing.Size(17, 17);
            this.txtDate.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtDate.CustomButton.TabIndex = 1;
            this.txtDate.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtDate.CustomButton.UseSelectable = true;
            this.txtDate.CustomButton.Visible = false;
            this.txtDate.Lines = new string[0];
            this.txtDate.Location = new System.Drawing.Point(76, 94);
            this.txtDate.Margin = new System.Windows.Forms.Padding(2);
            this.txtDate.MaxLength = 32767;
            this.txtDate.Name = "txtDate";
            this.txtDate.PasswordChar = '\0';
            this.txtDate.ReadOnly = true;
            this.txtDate.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtDate.SelectedText = "";
            this.txtDate.SelectionLength = 0;
            this.txtDate.SelectionStart = 0;
            this.txtDate.ShortcutsEnabled = true;
            this.txtDate.Size = new System.Drawing.Size(154, 19);
            this.txtDate.TabIndex = 19;
            this.txtDate.UseSelectable = true;
            this.txtDate.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtDate.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel16
            // 
            this.metroLabel16.AutoSize = true;
            this.metroLabel16.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.metroLabel16.Location = new System.Drawing.Point(41, 527);
            this.metroLabel16.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.metroLabel16.Name = "metroLabel16";
            this.metroLabel16.Size = new System.Drawing.Size(196, 19);
            this.metroLabel16.TabIndex = 18;
            this.metroLabel16.Text = "--Thank You, Stay With us-- ";
            this.metroLabel16.UseCustomForeColor = true;
            // 
            // dgvProducts
            // 
            this.dgvProducts.AllowUserToAddRows = false;
            this.dgvProducts.AllowUserToDeleteRows = false;
            this.dgvProducts.AllowUserToResizeRows = false;
            this.dgvProducts.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvProducts.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvProducts.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvProducts.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProducts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProducts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column5,
            this.Column3});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvProducts.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvProducts.EnableHeadersVisualStyles = false;
            this.dgvProducts.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgvProducts.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvProducts.Location = new System.Drawing.Point(2, 170);
            this.dgvProducts.Margin = new System.Windows.Forms.Padding(2);
            this.dgvProducts.MultiSelect = false;
            this.dgvProducts.Name = "dgvProducts";
            this.dgvProducts.ReadOnly = true;
            this.dgvProducts.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProducts.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvProducts.RowHeadersWidth = 51;
            this.dgvProducts.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvProducts.RowTemplate.Height = 24;
            this.dgvProducts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProducts.Size = new System.Drawing.Size(237, 255);
            this.dgvProducts.TabIndex = 17;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.FillWeight = 39.21429F;
            this.Column1.HeaderText = "SL";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.FillWeight = 170.3894F;
            this.Column2.HeaderText = "Item";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column5.FillWeight = 106.9519F;
            this.Column5.HeaderText = "Price";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column3.FillWeight = 81.85983F;
            this.Column3.HeaderText = "Qty";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // metroLabel15
            // 
            this.metroLabel15.AutoSize = true;
            this.metroLabel15.Location = new System.Drawing.Point(2, 504);
            this.metroLabel15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.metroLabel15.Name = "metroLabel15";
            this.metroLabel15.Size = new System.Drawing.Size(91, 19);
            this.metroLabel15.TabIndex = 16;
            this.metroLabel15.Text = "Exchange BDT";
            // 
            // metroLabel14
            // 
            this.metroLabel14.AutoSize = true;
            this.metroLabel14.Location = new System.Drawing.Point(2, 486);
            this.metroLabel14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.metroLabel14.Name = "metroLabel14";
            this.metroLabel14.Size = new System.Drawing.Size(112, 19);
            this.metroLabel14.TabIndex = 15;
            this.metroLabel14.Text = "Paid Amount BDT";
            // 
            // metroLabel12
            // 
            this.metroLabel12.AutoSize = true;
            this.metroLabel12.Location = new System.Drawing.Point(2, 467);
            this.metroLabel12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.metroLabel12.Name = "metroLabel12";
            this.metroLabel12.Size = new System.Drawing.Size(89, 19);
            this.metroLabel12.TabIndex = 13;
            this.metroLabel12.Text = "Sub Total BDT";
            // 
            // metroLabel11
            // 
            this.metroLabel11.AutoSize = true;
            this.metroLabel11.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel11.Location = new System.Drawing.Point(2, 450);
            this.metroLabel11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.metroLabel11.Name = "metroLabel11";
            this.metroLabel11.Size = new System.Drawing.Size(97, 19);
            this.metroLabel11.TabIndex = 12;
            this.metroLabel11.Text = "Discount BDT";
            // 
            // metroLabel10
            // 
            this.metroLabel10.AutoSize = true;
            this.metroLabel10.Location = new System.Drawing.Point(4, 429);
            this.metroLabel10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.metroLabel10.Name = "metroLabel10";
            this.metroLabel10.Size = new System.Drawing.Size(63, 19);
            this.metroLabel10.TabIndex = 11;
            this.metroLabel10.Text = "Total BDT";
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.Location = new System.Drawing.Point(2, 149);
            this.metroLabel8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(47, 19);
            this.metroLabel8.TabIndex = 9;
            this.metroLabel8.Text = "Details";
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(2, 113);
            this.metroLabel7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(41, 19);
            this.metroLabel7.TabIndex = 8;
            this.metroLabel7.Text = "Seller";
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(2, 94);
            this.metroLabel6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(36, 19);
            this.metroLabel6.TabIndex = 7;
            this.metroLabel6.Text = "Date";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(2, 68);
            this.metroLabel5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(71, 19);
            this.metroLabel5.TabIndex = 6;
            this.metroLabel5.Text = "Invoice No";
            // 
            // lblContactNo
            // 
            this.lblContactNo.AutoSize = true;
            this.lblContactNo.Location = new System.Drawing.Point(76, 50);
            this.lblContactNo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblContactNo.Name = "lblContactNo";
            this.lblContactNo.Size = new System.Drawing.Size(105, 19);
            this.lblContactNo.TabIndex = 5;
            this.lblContactNo.Text = "+8801729771453";
            this.lblContactNo.Click += new System.EventHandler(this.metroLabel4_Click);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(2, 50);
            this.metroLabel3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(76, 19);
            this.metroLabel3.TabIndex = 4;
            this.metroLabel3.Text = "Contact No";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(70, 29);
            this.metroLabel2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(115, 19);
            this.metroLabel2.TabIndex = 3;
            this.metroLabel2.Text = "Hulululu Shopping";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(76, 7);
            this.metroLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(105, 19);
            this.metroLabel1.TabIndex = 2;
            this.metroLabel1.Text = "SMS123 Tech Ltd";
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // SalesSlip
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(251, 640);
            this.Controls.Add(this.metroPanel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SalesSlip";
            this.Padding = new System.Windows.Forms.Padding(15, 60, 15, 16);
            this.Resizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "SalesSlip";
            this.Load += new System.EventHandler(this.SalesSlip_Load);
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroGrid dgvProducts;
        private MetroFramework.Controls.MetroLabel metroLabel15;
        private MetroFramework.Controls.MetroLabel metroLabel14;
        private MetroFramework.Controls.MetroLabel metroLabel12;
        private MetroFramework.Controls.MetroLabel metroLabel11;
        private MetroFramework.Controls.MetroLabel metroLabel10;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel lblContactNo;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox txtSubtotal;
        private MetroFramework.Controls.MetroTextBox txtDiscountBDT;
        private MetroFramework.Controls.MetroTextBox txtTotalBDT;
        private MetroFramework.Controls.MetroTextBox txtExchange;
        private MetroFramework.Controls.MetroTextBox txtPaidAmount;
        private MetroFramework.Controls.MetroTextBox txtInvoiceNo;
        private MetroFramework.Controls.MetroTextBox txtSellerID;
        private MetroFramework.Controls.MetroTextBox txtDate;
        private MetroFramework.Controls.MetroLabel metroLabel16;
        private MetroFramework.Controls.MetroButton SlipPrint;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
    }
}