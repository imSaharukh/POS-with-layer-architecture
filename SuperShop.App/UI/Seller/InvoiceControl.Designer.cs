
namespace SuperShop.App.UI.Seller
{
    partial class InvoiceControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.txtProductQty = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.txtSearch = new MetroFramework.Controls.MetroTextBox();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.metroPanel2 = new MetroFramework.Controls.MetroPanel();
            this.txtGivenAmount = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.btnCartItemRemove = new MetroFramework.Controls.MetroButton();
            this.txtBoxDiscount = new MetroFramework.Controls.MetroTextBox();
            this.btnClearAll = new MetroFramework.Controls.MetroButton();
            this.lblSubTotal = new MetroFramework.Controls.MetroLabel();
            this.lblTotal = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.dgvInvoiceProduct = new MetroFramework.Controls.MetroGrid();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnConfirm = new MetroFramework.Controls.MetroButton();
            this.dgvAllProduct = new MetroFramework.Controls.MetroGrid();
            this.productID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productCategoryID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productCategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.purchasePrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.expireDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductUnit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.metroPanel1.SuspendLayout();
            this.metroPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInvoiceProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllProduct)).BeginInit();
            this.SuspendLayout();
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.metroLabel5);
            this.metroPanel1.Controls.Add(this.txtProductQty);
            this.metroPanel1.Controls.Add(this.metroLabel1);
            this.metroPanel1.Controls.Add(this.txtSearch);
            this.metroPanel1.Controls.Add(this.metroButton1);
            this.metroPanel1.Controls.Add(this.metroPanel2);
            this.metroPanel1.Controls.Add(this.dgvAllProduct);
            this.metroPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(0, 0);
            this.metroPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(877, 527);
            this.metroPanel1.TabIndex = 0;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 11;
            this.metroPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.metroPanel1_Paint);
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(43, 14);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(31, 20);
            this.metroLabel5.TabIndex = 16;
            this.metroLabel5.Text = "Qty";
            // 
            // txtProductQty
            // 
            // 
            // 
            // 
            this.txtProductQty.CustomButton.Image = null;
            this.txtProductQty.CustomButton.Location = new System.Drawing.Point(67, 1);
            this.txtProductQty.CustomButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtProductQty.CustomButton.Name = "";
            this.txtProductQty.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtProductQty.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtProductQty.CustomButton.TabIndex = 1;
            this.txtProductQty.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtProductQty.CustomButton.UseSelectable = true;
            this.txtProductQty.CustomButton.Visible = false;
            this.txtProductQty.Lines = new string[0];
            this.txtProductQty.Location = new System.Drawing.Point(43, 37);
            this.txtProductQty.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtProductQty.MaxLength = 32767;
            this.txtProductQty.Name = "txtProductQty";
            this.txtProductQty.PasswordChar = '\0';
            this.txtProductQty.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtProductQty.SelectedText = "";
            this.txtProductQty.SelectionLength = 0;
            this.txtProductQty.SelectionStart = 0;
            this.txtProductQty.ShortcutsEnabled = true;
            this.txtProductQty.Size = new System.Drawing.Size(89, 23);
            this.txtProductQty.TabIndex = 15;
            this.txtProductQty.UseSelectable = true;
            this.txtProductQty.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtProductQty.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtProductQty.Click += new System.EventHandler(this.txtProductQty_Click);
            this.txtProductQty.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.QtyKeyPress);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(43, 80);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(51, 20);
            this.metroLabel1.TabIndex = 9;
            this.metroLabel1.Text = "Search";
            this.metroLabel1.Click += new System.EventHandler(this.metroLabel1_Click);
            // 
            // txtSearch
            // 
            // 
            // 
            // 
            this.txtSearch.CustomButton.Image = null;
            this.txtSearch.CustomButton.Location = new System.Drawing.Point(367, 1);
            this.txtSearch.CustomButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSearch.CustomButton.Name = "";
            this.txtSearch.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtSearch.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtSearch.CustomButton.TabIndex = 1;
            this.txtSearch.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtSearch.CustomButton.UseSelectable = true;
            this.txtSearch.CustomButton.Visible = false;
            this.txtSearch.Lines = new string[0];
            this.txtSearch.Location = new System.Drawing.Point(43, 103);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSearch.MaxLength = 32767;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PasswordChar = '\0';
            this.txtSearch.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSearch.SelectedText = "";
            this.txtSearch.SelectionLength = 0;
            this.txtSearch.SelectionStart = 0;
            this.txtSearch.ShortcutsEnabled = true;
            this.txtSearch.Size = new System.Drawing.Size(389, 23);
            this.txtSearch.TabIndex = 8;
            this.txtSearch.UseSelectable = true;
            this.txtSearch.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtSearch.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtSearch.TextChanged += new System.EventHandler(this.search_changed);
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(212, 37);
            this.metroButton1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(101, 23);
            this.metroButton1.TabIndex = 6;
            this.metroButton1.Text = "Add to Cart";
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.btnAddToCart_Click);
            // 
            // metroPanel2
            // 
            this.metroPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.metroPanel2.Controls.Add(this.metroLabel7);
            this.metroPanel2.Controls.Add(this.txtGivenAmount);
            this.metroPanel2.Controls.Add(this.metroLabel6);
            this.metroPanel2.Controls.Add(this.btnCartItemRemove);
            this.metroPanel2.Controls.Add(this.txtBoxDiscount);
            this.metroPanel2.Controls.Add(this.btnClearAll);
            this.metroPanel2.Controls.Add(this.lblSubTotal);
            this.metroPanel2.Controls.Add(this.lblTotal);
            this.metroPanel2.Controls.Add(this.metroLabel4);
            this.metroPanel2.Controls.Add(this.metroLabel3);
            this.metroPanel2.Controls.Add(this.metroLabel2);
            this.metroPanel2.Controls.Add(this.dgvInvoiceProduct);
            this.metroPanel2.Controls.Add(this.btnConfirm);
            this.metroPanel2.HorizontalScrollbarBarColor = true;
            this.metroPanel2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel2.HorizontalScrollbarSize = 10;
            this.metroPanel2.Location = new System.Drawing.Point(573, 0);
            this.metroPanel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.metroPanel2.Name = "metroPanel2";
            this.metroPanel2.Size = new System.Drawing.Size(301, 524);
            this.metroPanel2.TabIndex = 5;
            this.metroPanel2.UseCustomBackColor = true;
            this.metroPanel2.VerticalScrollbarBarColor = true;
            this.metroPanel2.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel2.VerticalScrollbarSize = 11;
            // 
            // txtGivenAmount
            // 
            // 
            // 
            // 
            this.txtGivenAmount.CustomButton.Image = null;
            this.txtGivenAmount.CustomButton.Location = new System.Drawing.Point(121, 1);
            this.txtGivenAmount.CustomButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtGivenAmount.CustomButton.Name = "";
            this.txtGivenAmount.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtGivenAmount.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtGivenAmount.CustomButton.TabIndex = 1;
            this.txtGivenAmount.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtGivenAmount.CustomButton.UseSelectable = true;
            this.txtGivenAmount.CustomButton.Visible = false;
            this.txtGivenAmount.Lines = new string[0];
            this.txtGivenAmount.Location = new System.Drawing.Point(125, 409);
            this.txtGivenAmount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtGivenAmount.MaxLength = 32767;
            this.txtGivenAmount.Name = "txtGivenAmount";
            this.txtGivenAmount.PasswordChar = '\0';
            this.txtGivenAmount.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtGivenAmount.SelectedText = "";
            this.txtGivenAmount.SelectionLength = 0;
            this.txtGivenAmount.SelectionStart = 0;
            this.txtGivenAmount.ShortcutsEnabled = true;
            this.txtGivenAmount.Size = new System.Drawing.Size(143, 23);
            this.txtGivenAmount.TabIndex = 16;
            this.txtGivenAmount.UseSelectable = true;
            this.txtGivenAmount.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtGivenAmount.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtGivenAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.discountKeypress);
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.metroLabel6.Location = new System.Drawing.Point(3, 414);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(106, 20);
            this.metroLabel6.TabIndex = 15;
            this.metroLabel6.Text = "Given Amount  ";
            this.metroLabel6.UseCustomBackColor = true;
            // 
            // btnCartItemRemove
            // 
            this.btnCartItemRemove.BackColor = System.Drawing.Color.Aqua;
            this.btnCartItemRemove.Location = new System.Drawing.Point(167, 33);
            this.btnCartItemRemove.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCartItemRemove.Name = "btnCartItemRemove";
            this.btnCartItemRemove.Size = new System.Drawing.Size(101, 23);
            this.btnCartItemRemove.TabIndex = 10;
            this.btnCartItemRemove.Text = "Remove";
            this.btnCartItemRemove.UseCustomBackColor = true;
            this.btnCartItemRemove.UseSelectable = true;
            this.btnCartItemRemove.Click += new System.EventHandler(this.btnCartItemRemove_Click);
            // 
            // txtBoxDiscount
            // 
            // 
            // 
            // 
            this.txtBoxDiscount.CustomButton.Image = null;
            this.txtBoxDiscount.CustomButton.Location = new System.Drawing.Point(121, 1);
            this.txtBoxDiscount.CustomButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBoxDiscount.CustomButton.Name = "";
            this.txtBoxDiscount.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtBoxDiscount.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtBoxDiscount.CustomButton.TabIndex = 1;
            this.txtBoxDiscount.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtBoxDiscount.CustomButton.UseSelectable = true;
            this.txtBoxDiscount.CustomButton.Visible = false;
            this.txtBoxDiscount.Lines = new string[0];
            this.txtBoxDiscount.Location = new System.Drawing.Point(125, 350);
            this.txtBoxDiscount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBoxDiscount.MaxLength = 32767;
            this.txtBoxDiscount.Name = "txtBoxDiscount";
            this.txtBoxDiscount.PasswordChar = '\0';
            this.txtBoxDiscount.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtBoxDiscount.SelectedText = "";
            this.txtBoxDiscount.SelectionLength = 0;
            this.txtBoxDiscount.SelectionStart = 0;
            this.txtBoxDiscount.ShortcutsEnabled = true;
            this.txtBoxDiscount.Size = new System.Drawing.Size(143, 23);
            this.txtBoxDiscount.TabIndex = 14;
            this.txtBoxDiscount.UseSelectable = true;
            this.txtBoxDiscount.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtBoxDiscount.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtBoxDiscount.TextChanged += new System.EventHandler(this.DiscountChanged);
            this.txtBoxDiscount.Click += new System.EventHandler(this.txtBoxDiscount_Click);
            this.txtBoxDiscount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.discountKeypress);
            // 
            // btnClearAll
            // 
            this.btnClearAll.BackColor = System.Drawing.Color.Aqua;
            this.btnClearAll.Location = new System.Drawing.Point(29, 33);
            this.btnClearAll.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnClearAll.Name = "btnClearAll";
            this.btnClearAll.Size = new System.Drawing.Size(112, 23);
            this.btnClearAll.TabIndex = 7;
            this.btnClearAll.Text = "Clear All";
            this.btnClearAll.UseCustomBackColor = true;
            this.btnClearAll.UseSelectable = true;
            this.btnClearAll.Click += new System.EventHandler(this.btnClearAll_Click);
            // 
            // lblSubTotal
            // 
            this.lblSubTotal.AutoSize = true;
            this.lblSubTotal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblSubTotal.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblSubTotal.Location = new System.Drawing.Point(125, 386);
            this.lblSubTotal.Name = "lblSubTotal";
            this.lblSubTotal.Size = new System.Drawing.Size(18, 20);
            this.lblSubTotal.TabIndex = 13;
            this.lblSubTotal.Text = "0";
            this.lblSubTotal.UseCustomBackColor = true;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblTotal.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblTotal.Location = new System.Drawing.Point(125, 320);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(18, 20);
            this.lblTotal.TabIndex = 12;
            this.lblTotal.Text = "0";
            this.lblTotal.UseCustomBackColor = true;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.metroLabel4.Location = new System.Drawing.Point(3, 354);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(71, 20);
            this.metroLabel4.TabIndex = 11;
            this.metroLabel4.Text = "Discount  ";
            this.metroLabel4.UseCustomBackColor = true;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.metroLabel3.Location = new System.Drawing.Point(3, 386);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(72, 20);
            this.metroLabel3.TabIndex = 10;
            this.metroLabel3.Text = "Sub Total  ";
            this.metroLabel3.UseCustomBackColor = true;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.metroLabel2.Location = new System.Drawing.Point(3, 320);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(73, 20);
            this.metroLabel2.TabIndex = 9;
            this.metroLabel2.Text = "Total         ";
            this.metroLabel2.UseCustomBackColor = true;
            // 
            // dgvInvoiceProduct
            // 
            this.dgvInvoiceProduct.AllowUserToAddRows = false;
            this.dgvInvoiceProduct.AllowUserToResizeRows = false;
            this.dgvInvoiceProduct.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvInvoiceProduct.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvInvoiceProduct.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvInvoiceProduct.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvInvoiceProduct.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvInvoiceProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInvoiceProduct.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.PName,
            this.Qty,
            this.Price});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvInvoiceProduct.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgvInvoiceProduct.EnableHeadersVisualStyles = false;
            this.dgvInvoiceProduct.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgvInvoiceProduct.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvInvoiceProduct.Location = new System.Drawing.Point(3, 98);
            this.dgvInvoiceProduct.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvInvoiceProduct.MultiSelect = false;
            this.dgvInvoiceProduct.Name = "dgvInvoiceProduct";
            this.dgvInvoiceProduct.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvInvoiceProduct.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvInvoiceProduct.RowHeadersWidth = 51;
            this.dgvInvoiceProduct.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvInvoiceProduct.RowTemplate.Height = 24;
            this.dgvInvoiceProduct.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvInvoiceProduct.Size = new System.Drawing.Size(301, 214);
            this.dgvInvoiceProduct.TabIndex = 8;
            this.dgvInvoiceProduct.UseCustomBackColor = true;
            this.dgvInvoiceProduct.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.metroGrid1_CellContentClick);
            this.dgvInvoiceProduct.CellValidated += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvInvoiceProduct_CellValidated);
            this.dgvInvoiceProduct.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvInvoiceProduct_CellValueChanged);
            this.dgvInvoiceProduct.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dgvInvoiceProduct_EditingControlShowing);
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            this.ID.Visible = false;
            this.ID.Width = 125;
            // 
            // PName
            // 
            this.PName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.PName.HeaderText = "Name";
            this.PName.MinimumWidth = 6;
            this.PName.Name = "PName";
            this.PName.ReadOnly = true;
            // 
            // Qty
            // 
            this.Qty.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Qty.HeaderText = "Qty";
            this.Qty.MinimumWidth = 6;
            this.Qty.Name = "Qty";
            // 
            // Price
            // 
            this.Price.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Price.DataPropertyName = "Price";
            this.Price.HeaderText = "Price";
            this.Price.MinimumWidth = 6;
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(79, 455);
            this.btnConfirm.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(189, 23);
            this.btnConfirm.TabIndex = 7;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseSelectable = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // dgvAllProduct
            // 
            this.dgvAllProduct.AllowUserToResizeRows = false;
            this.dgvAllProduct.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvAllProduct.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvAllProduct.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvAllProduct.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAllProduct.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dgvAllProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAllProduct.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.productID,
            this.categoryID,
            this.productCategoryID,
            this.productName,
            this.unitPrice,
            this.productCategory,
            this.stock,
            this.purchasePrice,
            this.expireDate,
            this.ProductUnit});
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAllProduct.DefaultCellStyle = dataGridViewCellStyle11;
            this.dgvAllProduct.EnableHeadersVisualStyles = false;
            this.dgvAllProduct.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgvAllProduct.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvAllProduct.Location = new System.Drawing.Point(4, 140);
            this.dgvAllProduct.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvAllProduct.MultiSelect = false;
            this.dgvAllProduct.Name = "dgvAllProduct";
            this.dgvAllProduct.ReadOnly = true;
            this.dgvAllProduct.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAllProduct.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.dgvAllProduct.RowHeadersWidth = 51;
            this.dgvAllProduct.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvAllProduct.RowTemplate.Height = 24;
            this.dgvAllProduct.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAllProduct.Size = new System.Drawing.Size(565, 384);
            this.dgvAllProduct.TabIndex = 3;
            // 
            // productID
            // 
            this.productID.DataPropertyName = "productID";
            this.productID.HeaderText = "productID";
            this.productID.MinimumWidth = 6;
            this.productID.Name = "productID";
            this.productID.ReadOnly = true;
            this.productID.Visible = false;
            this.productID.Width = 125;
            // 
            // categoryID
            // 
            this.categoryID.DataPropertyName = "categoryID";
            this.categoryID.HeaderText = "Category ID";
            this.categoryID.MinimumWidth = 6;
            this.categoryID.Name = "categoryID";
            this.categoryID.ReadOnly = true;
            this.categoryID.Visible = false;
            this.categoryID.Width = 125;
            // 
            // productCategoryID
            // 
            this.productCategoryID.DataPropertyName = "productCategoryID";
            this.productCategoryID.HeaderText = "Product Category ID";
            this.productCategoryID.MinimumWidth = 6;
            this.productCategoryID.Name = "productCategoryID";
            this.productCategoryID.ReadOnly = true;
            this.productCategoryID.Visible = false;
            this.productCategoryID.Width = 125;
            // 
            // productName
            // 
            this.productName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.productName.DataPropertyName = "productName";
            this.productName.HeaderText = "Product Name";
            this.productName.MinimumWidth = 6;
            this.productName.Name = "productName";
            this.productName.ReadOnly = true;
            // 
            // unitPrice
            // 
            this.unitPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.unitPrice.DataPropertyName = "unitPrice";
            this.unitPrice.HeaderText = "Unit Price";
            this.unitPrice.MinimumWidth = 6;
            this.unitPrice.Name = "unitPrice";
            this.unitPrice.ReadOnly = true;
            // 
            // productCategory
            // 
            this.productCategory.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.productCategory.DataPropertyName = "productCategory";
            this.productCategory.HeaderText = "Product Category";
            this.productCategory.MinimumWidth = 6;
            this.productCategory.Name = "productCategory";
            this.productCategory.ReadOnly = true;
            // 
            // stock
            // 
            this.stock.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.stock.DataPropertyName = "stock";
            this.stock.HeaderText = "Stock";
            this.stock.MinimumWidth = 6;
            this.stock.Name = "stock";
            this.stock.ReadOnly = true;
            // 
            // purchasePrice
            // 
            this.purchasePrice.DataPropertyName = "purchasePrice";
            this.purchasePrice.HeaderText = "Purchase Price";
            this.purchasePrice.MinimumWidth = 6;
            this.purchasePrice.Name = "purchasePrice";
            this.purchasePrice.ReadOnly = true;
            this.purchasePrice.Visible = false;
            this.purchasePrice.Width = 125;
            // 
            // expireDate
            // 
            this.expireDate.DataPropertyName = "expireDate";
            this.expireDate.HeaderText = "Expire Date";
            this.expireDate.MinimumWidth = 6;
            this.expireDate.Name = "expireDate";
            this.expireDate.ReadOnly = true;
            this.expireDate.Visible = false;
            this.expireDate.Width = 125;
            // 
            // ProductUnit
            // 
            this.ProductUnit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ProductUnit.DataPropertyName = "ProductUnit";
            this.ProductUnit.HeaderText = "Product Unit";
            this.ProductUnit.MinimumWidth = 6;
            this.ProductUnit.Name = "ProductUnit";
            this.ProductUnit.ReadOnly = true;
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.metroLabel7.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel7.Location = new System.Drawing.Point(3, 76);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(188, 17);
            this.metroLabel7.TabIndex = 17;
            this.metroLabel7.Text = "* Qty can be changed from here";
            this.metroLabel7.UseCustomBackColor = true;
            // 
            // InvoiceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.metroPanel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "InvoiceForm";
            this.Size = new System.Drawing.Size(877, 527);
            this.Load += new System.EventHandler(this.InvoiceForm_Load);
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            this.metroPanel2.ResumeLayout(false);
            this.metroPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInvoiceProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllProduct)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroPanel metroPanel2;
        private MetroFramework.Controls.MetroGrid dgvAllProduct;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox txtSearch;
        private MetroFramework.Controls.MetroButton btnClearAll;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroButton btnConfirm;
        private MetroFramework.Controls.MetroTextBox txtBoxDiscount;
        private MetroFramework.Controls.MetroLabel lblSubTotal;
        private MetroFramework.Controls.MetroLabel lblTotal;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroGrid dgvInvoiceProduct;
        private MetroFramework.Controls.MetroButton btnCartItemRemove;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroTextBox txtProductQty;
        private MetroFramework.Controls.MetroTextBox txtGivenAmount;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn PName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Qty;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn productID;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryID;
        private System.Windows.Forms.DataGridViewTextBoxColumn productCategoryID;
        private System.Windows.Forms.DataGridViewTextBoxColumn productName;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn productCategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn stock;
        private System.Windows.Forms.DataGridViewTextBoxColumn purchasePrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn expireDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductUnit;
        private MetroFramework.Controls.MetroLabel metroLabel7;
    }
}
