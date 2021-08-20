
namespace SuperShop.App
{
    partial class ProductControl
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
            this.dgvProduct = new MetroFramework.Controls.MetroGrid();
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
            this.metroGrid1 = new MetroFramework.Controls.MetroGrid();
            this.metroPanel2 = new MetroFramework.Controls.MetroPanel();
            this.btnAddCatagory = new MetroFramework.Controls.MetroButton();
            this.btnAddUnit = new MetroFramework.Controls.MetroButton();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.txtSearchProduct = new MetroFramework.Controls.MetroTextBox();
            this.btnProductUpdate = new MetroFramework.Controls.MetroButton();
            this.metroButton4 = new MetroFramework.Controls.MetroButton();
            this.btnAddProductform = new MetroFramework.Controls.MetroButton();
            this.metroPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).BeginInit();
            this.metroPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.dgvProduct);
            this.metroPanel1.Controls.Add(this.metroGrid1);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(3, 141);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(861, 383);
            this.metroPanel1.TabIndex = 0;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // dgvProduct
            // 
            this.dgvProduct.AllowUserToResizeRows = false;
            this.dgvProduct.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvProduct.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvProduct.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvProduct.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProduct.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProduct.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
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
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvProduct.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgvProduct.EnableHeadersVisualStyles = false;
            this.dgvProduct.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgvProduct.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvProduct.Location = new System.Drawing.Point(3, 25);
            this.dgvProduct.Name = "dgvProduct";
            this.dgvProduct.ReadOnly = true;
            this.dgvProduct.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProduct.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvProduct.RowHeadersWidth = 51;
            this.dgvProduct.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvProduct.RowTemplate.Height = 24;
            this.dgvProduct.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProduct.Size = new System.Drawing.Size(858, 355);
            this.dgvProduct.TabIndex = 3;
            // 
            // productID
            // 
            this.productID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.productID.DataPropertyName = "productID";
            this.productID.HeaderText = "ID";
            this.productID.MinimumWidth = 6;
            this.productID.Name = "productID";
            this.productID.ReadOnly = true;
            this.productID.Visible = false;
            // 
            // categoryID
            // 
            this.categoryID.DataPropertyName = "categoryID";
            this.categoryID.HeaderText = "categoryID";
            this.categoryID.MinimumWidth = 6;
            this.categoryID.Name = "categoryID";
            this.categoryID.ReadOnly = true;
            this.categoryID.Visible = false;
            this.categoryID.Width = 125;
            // 
            // productCategoryID
            // 
            this.productCategoryID.DataPropertyName = "productCategoryID";
            this.productCategoryID.HeaderText = "productCategoryID";
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
            this.productName.HeaderText = "Name";
            this.productName.MinimumWidth = 3;
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
            this.stock.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.stock.DataPropertyName = "stock";
            this.stock.HeaderText = "Stock";
            this.stock.MinimumWidth = 6;
            this.stock.Name = "stock";
            this.stock.ReadOnly = true;
            // 
            // productCategory
            // 
            this.productCategory.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.productCategory.DataPropertyName = "productCategory";
            this.productCategory.HeaderText = "Category";
            this.productCategory.MinimumWidth = 6;
            this.productCategory.Name = "productCategory";
            this.productCategory.ReadOnly = true;
            // 
            // purchasePrice
            // 
            this.purchasePrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.purchasePrice.DataPropertyName = "purchasePrice";
            this.purchasePrice.HeaderText = "Purchase Price";
            this.purchasePrice.MinimumWidth = 6;
            this.purchasePrice.Name = "purchasePrice";
            this.purchasePrice.ReadOnly = true;
            // 
            // expireDate
            // 
            this.expireDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.expireDate.DataPropertyName = "expireDate";
            this.expireDate.HeaderText = "Expire Date";
            this.expireDate.MinimumWidth = 6;
            this.expireDate.Name = "expireDate";
            this.expireDate.ReadOnly = true;
            // 
            // ProductUnit
            // 
            this.ProductUnit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ProductUnit.DataPropertyName = "ProductUnit";
            this.ProductUnit.HeaderText = "UNIT";
            this.ProductUnit.MinimumWidth = 6;
            this.ProductUnit.Name = "ProductUnit";
            this.ProductUnit.ReadOnly = true;
            // 
            // metroGrid1
            // 
            this.metroGrid1.AllowUserToResizeRows = false;
            this.metroGrid1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGrid1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.metroGrid1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.metroGrid1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.metroGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.metroGrid1.DefaultCellStyle = dataGridViewCellStyle11;
            this.metroGrid1.EnableHeadersVisualStyles = false;
            this.metroGrid1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.metroGrid1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGrid1.Location = new System.Drawing.Point(23, 25);
            this.metroGrid1.Name = "metroGrid1";
            this.metroGrid1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid1.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.metroGrid1.RowHeadersWidth = 51;
            this.metroGrid1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.metroGrid1.RowTemplate.Height = 24;
            this.metroGrid1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.metroGrid1.Size = new System.Drawing.Size(877, 437);
            this.metroGrid1.TabIndex = 2;
            // 
            // metroPanel2
            // 
            this.metroPanel2.Controls.Add(this.btnAddCatagory);
            this.metroPanel2.Controls.Add(this.btnAddUnit);
            this.metroPanel2.Controls.Add(this.metroLabel1);
            this.metroPanel2.Controls.Add(this.txtSearchProduct);
            this.metroPanel2.Controls.Add(this.btnProductUpdate);
            this.metroPanel2.Controls.Add(this.metroButton4);
            this.metroPanel2.Controls.Add(this.btnAddProductform);
            this.metroPanel2.HorizontalScrollbarBarColor = true;
            this.metroPanel2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel2.HorizontalScrollbarSize = 10;
            this.metroPanel2.Location = new System.Drawing.Point(3, 29);
            this.metroPanel2.Name = "metroPanel2";
            this.metroPanel2.Size = new System.Drawing.Size(861, 106);
            this.metroPanel2.TabIndex = 1;
            this.metroPanel2.VerticalScrollbarBarColor = true;
            this.metroPanel2.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel2.VerticalScrollbarSize = 10;
            // 
            // btnAddCatagory
            // 
            this.btnAddCatagory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnAddCatagory.Location = new System.Drawing.Point(524, 64);
            this.btnAddCatagory.Name = "btnAddCatagory";
            this.btnAddCatagory.Size = new System.Drawing.Size(163, 30);
            this.btnAddCatagory.TabIndex = 9;
            this.btnAddCatagory.Text = "Add New Catagory";
            this.btnAddCatagory.UseCustomBackColor = true;
            this.btnAddCatagory.UseSelectable = true;
            // 
            // btnAddUnit
            // 
            this.btnAddUnit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnAddUnit.Location = new System.Drawing.Point(693, 64);
            this.btnAddUnit.Name = "btnAddUnit";
            this.btnAddUnit.Size = new System.Drawing.Size(156, 30);
            this.btnAddUnit.TabIndex = 8;
            this.btnAddUnit.Text = "Add New UNIT";
            this.btnAddUnit.UseCustomBackColor = true;
            this.btnAddUnit.UseSelectable = true;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(35, 5);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(164, 20);
            this.metroLabel1.TabIndex = 7;
            this.metroLabel1.Text = "Search by Product Name";
            // 
            // txtSearchProduct
            // 
            // 
            // 
            // 
            this.txtSearchProduct.CustomButton.Image = null;
            this.txtSearchProduct.CustomButton.Location = new System.Drawing.Point(242, 1);
            this.txtSearchProduct.CustomButton.Name = "";
            this.txtSearchProduct.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtSearchProduct.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtSearchProduct.CustomButton.TabIndex = 1;
            this.txtSearchProduct.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtSearchProduct.CustomButton.UseSelectable = true;
            this.txtSearchProduct.CustomButton.Visible = false;
            this.txtSearchProduct.Lines = new string[0];
            this.txtSearchProduct.Location = new System.Drawing.Point(35, 28);
            this.txtSearchProduct.MaxLength = 32767;
            this.txtSearchProduct.Name = "txtSearchProduct";
            this.txtSearchProduct.PasswordChar = '\0';
            this.txtSearchProduct.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSearchProduct.SelectedText = "";
            this.txtSearchProduct.SelectionLength = 0;
            this.txtSearchProduct.SelectionStart = 0;
            this.txtSearchProduct.ShortcutsEnabled = true;
            this.txtSearchProduct.Size = new System.Drawing.Size(264, 23);
            this.txtSearchProduct.TabIndex = 6;
            this.txtSearchProduct.UseSelectable = true;
            this.txtSearchProduct.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtSearchProduct.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtSearchProduct.TextChanged += new System.EventHandler(this.search_TextChanged);
            // 
            // btnProductUpdate
            // 
            this.btnProductUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnProductUpdate.Location = new System.Drawing.Point(642, 28);
            this.btnProductUpdate.Name = "btnProductUpdate";
            this.btnProductUpdate.Size = new System.Drawing.Size(89, 30);
            this.btnProductUpdate.TabIndex = 4;
            this.btnProductUpdate.Text = "Update";
            this.btnProductUpdate.UseCustomBackColor = true;
            this.btnProductUpdate.UseSelectable = true;
            this.btnProductUpdate.Click += new System.EventHandler(this.btnProductUpdate_Click);
            // 
            // metroButton4
            // 
            this.metroButton4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroButton4.Location = new System.Drawing.Point(760, 28);
            this.metroButton4.Name = "metroButton4";
            this.metroButton4.Size = new System.Drawing.Size(89, 30);
            this.metroButton4.TabIndex = 5;
            this.metroButton4.Text = "Delete";
            this.metroButton4.UseCustomBackColor = true;
            this.metroButton4.UseSelectable = true;
            // 
            // btnAddProductform
            // 
            this.btnAddProductform.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnAddProductform.Location = new System.Drawing.Point(524, 28);
            this.btnAddProductform.Name = "btnAddProductform";
            this.btnAddProductform.Size = new System.Drawing.Size(89, 30);
            this.btnAddProductform.TabIndex = 3;
            this.btnAddProductform.Text = "Add";
            this.btnAddProductform.UseCustomBackColor = true;
            this.btnAddProductform.UseSelectable = true;
            this.btnAddProductform.Click += new System.EventHandler(this.btnAddProductform_Click);
            // 
            // ProductControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.metroPanel2);
            this.Controls.Add(this.metroPanel1);
            this.Name = "ProductControl";
            this.Size = new System.Drawing.Size(867, 527);
            this.Load += new System.EventHandler(this.ProductControl_Load);
            this.metroPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).EndInit();
            this.metroPanel2.ResumeLayout(false);
            this.metroPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroPanel metroPanel2;
        private MetroFramework.Controls.MetroGrid dgvProduct;
        private MetroFramework.Controls.MetroGrid metroGrid1;
        private MetroFramework.Controls.MetroButton btnProductUpdate;
        private MetroFramework.Controls.MetroButton metroButton4;
        private MetroFramework.Controls.MetroButton btnAddProductform;
        private MetroFramework.Controls.MetroTextBox txtSearchProduct;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroButton btnAddCatagory;
        private MetroFramework.Controls.MetroButton btnAddUnit;
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
    }
}
