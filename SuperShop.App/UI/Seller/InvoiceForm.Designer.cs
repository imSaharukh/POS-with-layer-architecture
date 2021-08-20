
namespace SuperShop.App.UI.Seller
{
    partial class InvoiceForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.txtProductQty = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroTextBox1 = new MetroFramework.Controls.MetroTextBox();
            this.metroButton3 = new MetroFramework.Controls.MetroButton();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.metroPanel2 = new MetroFramework.Controls.MetroPanel();
            this.metroTextBox3 = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.btnCartItemRemove = new MetroFramework.Controls.MetroButton();
            this.txtBoxDiscount = new MetroFramework.Controls.MetroTextBox();
            this.lblSubTotal = new MetroFramework.Controls.MetroLabel();
            this.lblTotal = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.dgvInvoiceProduct = new MetroFramework.Controls.MetroGrid();
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            this.dgvAllProduct = new MetroFramework.Controls.MetroGrid();
            this.productID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productCategoryID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productCategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.purchasePrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.expireDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductUnit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.metroPanel1.Controls.Add(this.metroTextBox1);
            this.metroPanel1.Controls.Add(this.metroButton3);
            this.metroPanel1.Controls.Add(this.metroButton1);
            this.metroPanel1.Controls.Add(this.metroPanel2);
            this.metroPanel1.Controls.Add(this.dgvAllProduct);
            this.metroPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(0, 0);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(877, 527);
            this.metroPanel1.TabIndex = 0;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(42, 14);
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
            this.txtProductQty.CustomButton.Name = "";
            this.txtProductQty.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtProductQty.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtProductQty.CustomButton.TabIndex = 1;
            this.txtProductQty.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtProductQty.CustomButton.UseSelectable = true;
            this.txtProductQty.CustomButton.Visible = false;
            this.txtProductQty.Lines = new string[0];
            this.txtProductQty.Location = new System.Drawing.Point(42, 37);
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
            this.metroLabel1.Location = new System.Drawing.Point(42, 80);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(51, 20);
            this.metroLabel1.TabIndex = 9;
            this.metroLabel1.Text = "Search";
            this.metroLabel1.Click += new System.EventHandler(this.metroLabel1_Click);
            // 
            // metroTextBox1
            // 
            // 
            // 
            // 
            this.metroTextBox1.CustomButton.Image = null;
            this.metroTextBox1.CustomButton.Location = new System.Drawing.Point(368, 1);
            this.metroTextBox1.CustomButton.Name = "";
            this.metroTextBox1.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTextBox1.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBox1.CustomButton.TabIndex = 1;
            this.metroTextBox1.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBox1.CustomButton.UseSelectable = true;
            this.metroTextBox1.CustomButton.Visible = false;
            this.metroTextBox1.Lines = new string[] {
        "metroTextBox1"};
            this.metroTextBox1.Location = new System.Drawing.Point(42, 103);
            this.metroTextBox1.MaxLength = 32767;
            this.metroTextBox1.Name = "metroTextBox1";
            this.metroTextBox1.PasswordChar = '\0';
            this.metroTextBox1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox1.SelectedText = "";
            this.metroTextBox1.SelectionLength = 0;
            this.metroTextBox1.SelectionStart = 0;
            this.metroTextBox1.ShortcutsEnabled = true;
            this.metroTextBox1.Size = new System.Drawing.Size(390, 23);
            this.metroTextBox1.TabIndex = 8;
            this.metroTextBox1.Text = "metroTextBox1";
            this.metroTextBox1.UseSelectable = true;
            this.metroTextBox1.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBox1.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroButton3
            // 
            this.metroButton3.Location = new System.Drawing.Point(320, 37);
            this.metroButton3.Name = "metroButton3";
            this.metroButton3.Size = new System.Drawing.Size(112, 23);
            this.metroButton3.TabIndex = 7;
            this.metroButton3.Text = "Clear All";
            this.metroButton3.UseSelectable = true;
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(212, 37);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(102, 23);
            this.metroButton1.TabIndex = 6;
            this.metroButton1.Text = "Add to Cart";
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.btnAddToCart_Click);
            // 
            // metroPanel2
            // 
            this.metroPanel2.Controls.Add(this.metroTextBox3);
            this.metroPanel2.Controls.Add(this.metroLabel6);
            this.metroPanel2.Controls.Add(this.btnCartItemRemove);
            this.metroPanel2.Controls.Add(this.txtBoxDiscount);
            this.metroPanel2.Controls.Add(this.lblSubTotal);
            this.metroPanel2.Controls.Add(this.lblTotal);
            this.metroPanel2.Controls.Add(this.metroLabel4);
            this.metroPanel2.Controls.Add(this.metroLabel3);
            this.metroPanel2.Controls.Add(this.metroLabel2);
            this.metroPanel2.Controls.Add(this.dgvInvoiceProduct);
            this.metroPanel2.Controls.Add(this.metroButton2);
            this.metroPanel2.HorizontalScrollbarBarColor = true;
            this.metroPanel2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel2.HorizontalScrollbarSize = 10;
            this.metroPanel2.Location = new System.Drawing.Point(573, 4);
            this.metroPanel2.Name = "metroPanel2";
            this.metroPanel2.Size = new System.Drawing.Size(301, 520);
            this.metroPanel2.TabIndex = 5;
            this.metroPanel2.VerticalScrollbarBarColor = true;
            this.metroPanel2.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel2.VerticalScrollbarSize = 10;
            // 
            // metroTextBox3
            // 
            // 
            // 
            // 
            this.metroTextBox3.CustomButton.Image = null;
            this.metroTextBox3.CustomButton.Location = new System.Drawing.Point(151, 1);
            this.metroTextBox3.CustomButton.Name = "";
            this.metroTextBox3.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTextBox3.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBox3.CustomButton.TabIndex = 1;
            this.metroTextBox3.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBox3.CustomButton.UseSelectable = true;
            this.metroTextBox3.CustomButton.Visible = false;
            this.metroTextBox3.Lines = new string[0];
            this.metroTextBox3.Location = new System.Drawing.Point(125, 409);
            this.metroTextBox3.MaxLength = 32767;
            this.metroTextBox3.Name = "metroTextBox3";
            this.metroTextBox3.PasswordChar = '\0';
            this.metroTextBox3.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox3.SelectedText = "";
            this.metroTextBox3.SelectionLength = 0;
            this.metroTextBox3.SelectionStart = 0;
            this.metroTextBox3.ShortcutsEnabled = true;
            this.metroTextBox3.Size = new System.Drawing.Size(173, 23);
            this.metroTextBox3.TabIndex = 16;
            this.metroTextBox3.UseSelectable = true;
            this.metroTextBox3.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBox3.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.metroTextBox3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.QtyKeyPress);
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(3, 413);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(106, 20);
            this.metroLabel6.TabIndex = 15;
            this.metroLabel6.Text = "Given Amount  ";
            // 
            // btnCartItemRemove
            // 
            this.btnCartItemRemove.Location = new System.Drawing.Point(196, 33);
            this.btnCartItemRemove.Name = "btnCartItemRemove";
            this.btnCartItemRemove.Size = new System.Drawing.Size(102, 23);
            this.btnCartItemRemove.TabIndex = 10;
            this.btnCartItemRemove.Text = "Remove";
            this.btnCartItemRemove.UseSelectable = true;
            this.btnCartItemRemove.Click += new System.EventHandler(this.btnCartItemRemove_Click);
            // 
            // txtBoxDiscount
            // 
            // 
            // 
            // 
            this.txtBoxDiscount.CustomButton.Image = null;
            this.txtBoxDiscount.CustomButton.Location = new System.Drawing.Point(151, 1);
            this.txtBoxDiscount.CustomButton.Name = "";
            this.txtBoxDiscount.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtBoxDiscount.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtBoxDiscount.CustomButton.TabIndex = 1;
            this.txtBoxDiscount.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtBoxDiscount.CustomButton.UseSelectable = true;
            this.txtBoxDiscount.CustomButton.Visible = false;
            this.txtBoxDiscount.Lines = new string[0];
            this.txtBoxDiscount.Location = new System.Drawing.Point(125, 350);
            this.txtBoxDiscount.MaxLength = 32767;
            this.txtBoxDiscount.Name = "txtBoxDiscount";
            this.txtBoxDiscount.PasswordChar = '\0';
            this.txtBoxDiscount.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtBoxDiscount.SelectedText = "";
            this.txtBoxDiscount.SelectionLength = 0;
            this.txtBoxDiscount.SelectionStart = 0;
            this.txtBoxDiscount.ShortcutsEnabled = true;
            this.txtBoxDiscount.Size = new System.Drawing.Size(173, 23);
            this.txtBoxDiscount.TabIndex = 14;
            this.txtBoxDiscount.UseSelectable = true;
            this.txtBoxDiscount.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtBoxDiscount.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtBoxDiscount.TextChanged += new System.EventHandler(this.DiscountChanged);
            this.txtBoxDiscount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.QtyKeyPress);
            // 
            // lblSubTotal
            // 
            this.lblSubTotal.AutoSize = true;
            this.lblSubTotal.Location = new System.Drawing.Point(125, 386);
            this.lblSubTotal.Name = "lblSubTotal";
            this.lblSubTotal.Size = new System.Drawing.Size(17, 20);
            this.lblSubTotal.TabIndex = 13;
            this.lblSubTotal.Text = "0";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(125, 320);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(17, 20);
            this.lblTotal.TabIndex = 12;
            this.lblTotal.Text = "0";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(3, 354);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(71, 20);
            this.metroLabel4.TabIndex = 11;
            this.metroLabel4.Text = "Discount  ";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(3, 386);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(72, 20);
            this.metroLabel3.TabIndex = 10;
            this.metroLabel3.Text = "Sub Total  ";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(3, 320);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(73, 20);
            this.metroLabel2.TabIndex = 9;
            this.metroLabel2.Text = "Total         ";
            // 
            // dgvInvoiceProduct
            // 
            this.dgvInvoiceProduct.AllowUserToAddRows = false;
            this.dgvInvoiceProduct.AllowUserToResizeRows = false;
            this.dgvInvoiceProduct.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvInvoiceProduct.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvInvoiceProduct.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvInvoiceProduct.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvInvoiceProduct.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle13;
            this.dgvInvoiceProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInvoiceProduct.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.PName,
            this.Qty,
            this.Price});
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvInvoiceProduct.DefaultCellStyle = dataGridViewCellStyle14;
            this.dgvInvoiceProduct.EnableHeadersVisualStyles = false;
            this.dgvInvoiceProduct.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgvInvoiceProduct.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvInvoiceProduct.Location = new System.Drawing.Point(3, 99);
            this.dgvInvoiceProduct.Name = "dgvInvoiceProduct";
            this.dgvInvoiceProduct.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvInvoiceProduct.RowHeadersDefaultCellStyle = dataGridViewCellStyle15;
            this.dgvInvoiceProduct.RowHeadersWidth = 51;
            this.dgvInvoiceProduct.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvInvoiceProduct.RowTemplate.Height = 24;
            this.dgvInvoiceProduct.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvInvoiceProduct.Size = new System.Drawing.Size(301, 214);
            this.dgvInvoiceProduct.TabIndex = 8;
            this.dgvInvoiceProduct.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.metroGrid1_CellContentClick);
            // 
            // metroButton2
            // 
            this.metroButton2.Location = new System.Drawing.Point(3, 456);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(295, 23);
            this.metroButton2.TabIndex = 7;
            this.metroButton2.Text = "Confirm";
            this.metroButton2.UseSelectable = true;
            this.metroButton2.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // dgvAllProduct
            // 
            this.dgvAllProduct.AllowUserToResizeRows = false;
            this.dgvAllProduct.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvAllProduct.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvAllProduct.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvAllProduct.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAllProduct.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle16;
            this.dgvAllProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAllProduct.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.productID,
            this.categoryID,
            this.productCategoryID,
            this.productName,
            this.unitPrice,
            this.stock,
            this.productCategory,
            this.purchasePrice,
            this.expireDate,
            this.ProductUnit});
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle17.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAllProduct.DefaultCellStyle = dataGridViewCellStyle17;
            this.dgvAllProduct.EnableHeadersVisualStyles = false;
            this.dgvAllProduct.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgvAllProduct.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvAllProduct.Location = new System.Drawing.Point(4, 140);
            this.dgvAllProduct.Name = "dgvAllProduct";
            this.dgvAllProduct.ReadOnly = true;
            this.dgvAllProduct.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle18.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAllProduct.RowHeadersDefaultCellStyle = dataGridViewCellStyle18;
            this.dgvAllProduct.RowHeadersWidth = 51;
            this.dgvAllProduct.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvAllProduct.RowTemplate.Height = 24;
            this.dgvAllProduct.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAllProduct.Size = new System.Drawing.Size(566, 384);
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
            // stock
            // 
            this.stock.DataPropertyName = "stock";
            this.stock.HeaderText = "Stock";
            this.stock.MinimumWidth = 6;
            this.stock.Name = "stock";
            this.stock.ReadOnly = true;
            this.stock.Visible = false;
            this.stock.Width = 125;
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
            this.ProductUnit.DataPropertyName = "ProductUnit";
            this.ProductUnit.HeaderText = "Product Unit";
            this.ProductUnit.MinimumWidth = 6;
            this.ProductUnit.Name = "ProductUnit";
            this.ProductUnit.ReadOnly = true;
            this.ProductUnit.Visible = false;
            this.ProductUnit.Width = 125;
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
            // Invoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.metroPanel1);
            this.Name = "Invoice";
            this.Size = new System.Drawing.Size(877, 527);
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
        private MetroFramework.Controls.MetroTextBox metroTextBox1;
        private MetroFramework.Controls.MetroButton metroButton3;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroButton metroButton2;
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
        private MetroFramework.Controls.MetroTextBox metroTextBox3;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private System.Windows.Forms.DataGridViewTextBoxColumn productID;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryID;
        private System.Windows.Forms.DataGridViewTextBoxColumn productCategoryID;
        private System.Windows.Forms.DataGridViewTextBoxColumn productName;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn stock;
        private System.Windows.Forms.DataGridViewTextBoxColumn productCategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn purchasePrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn expireDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductUnit;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn PName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Qty;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
    }
}
