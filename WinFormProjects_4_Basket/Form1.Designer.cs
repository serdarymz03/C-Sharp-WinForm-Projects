namespace WinFormProjects_4_Basket
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.CmbCategory = new System.Windows.Forms.ComboBox();
            this.TxtPrice = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.DtgBasket = new System.Windows.Forms.DataGridView();
            this.Product_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Product_Category = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Product_Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total_ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DtgBasket)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BtnAdd);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.CmbCategory);
            this.groupBox1.Controls.Add(this.TxtPrice);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.TxtName);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(757, 146);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ürün Bilgileri    ";
            // 
            // BtnAdd
            // 
            this.BtnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnAdd.Location = new System.Drawing.Point(512, 77);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(167, 36);
            this.BtnAdd.TabIndex = 6;
            this.BtnAdd.Text = "EKLE";
            this.BtnAdd.UseVisualStyleBackColor = true;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(419, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 18);
            this.label3.TabIndex = 5;
            this.label3.Text = "Kategori : ";
            // 
            // CmbCategory
            // 
            this.CmbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbCategory.FormattingEnabled = true;
            this.CmbCategory.Items.AddRange(new object[] {
            "Elektronik",
            "Kırtasiye",
            "Gıda"});
            this.CmbCategory.Location = new System.Drawing.Point(500, 29);
            this.CmbCategory.Name = "CmbCategory";
            this.CmbCategory.Size = new System.Drawing.Size(191, 26);
            this.CmbCategory.TabIndex = 4;
            // 
            // TxtPrice
            // 
            this.TxtPrice.Location = new System.Drawing.Point(142, 74);
            this.TxtPrice.Name = "TxtPrice";
            this.TxtPrice.Size = new System.Drawing.Size(132, 24);
            this.TxtPrice.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(64, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Fiyat : ";
            // 
            // TxtName
            // 
            this.TxtName.Location = new System.Drawing.Point(142, 32);
            this.TxtName.Name = "TxtName";
            this.TxtName.Size = new System.Drawing.Size(228, 24);
            this.TxtName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ürün Adı : ";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.DtgBasket);
            this.groupBox2.Location = new System.Drawing.Point(12, 177);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(757, 259);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Sepet   ";
            // 
            // DtgBasket
            // 
            this.DtgBasket.AllowUserToAddRows = false;
            this.DtgBasket.AllowUserToDeleteRows = false;
            this.DtgBasket.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DtgBasket.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DtgBasket.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Product_Name,
            this.Product_Category,
            this.Product_Price,
            this.Total_});
            this.DtgBasket.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DtgBasket.Location = new System.Drawing.Point(3, 20);
            this.DtgBasket.Name = "DtgBasket";
            this.DtgBasket.ReadOnly = true;
            this.DtgBasket.RowHeadersVisible = false;
            this.DtgBasket.Size = new System.Drawing.Size(751, 236);
            this.DtgBasket.TabIndex = 0;
            // 
            // Product_Name
            // 
            this.Product_Name.HeaderText = "Ürün Adı";
            this.Product_Name.Name = "Product_Name";
            this.Product_Name.ReadOnly = true;
            // 
            // Product_Category
            // 
            this.Product_Category.HeaderText = "Kategori";
            this.Product_Category.Name = "Product_Category";
            this.Product_Category.ReadOnly = true;
            this.Product_Category.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Product_Category.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Product_Price
            // 
            this.Product_Price.HeaderText = "Fiyat";
            this.Product_Price.Name = "Product_Price";
            this.Product_Price.ReadOnly = true;
            // 
            // Total_
            // 
            this.Total_.HeaderText = "Bakiye";
            this.Total_.Name = "Total_";
            this.Total_.ReadOnly = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 461);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alışveriş Sepeti";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DtgBasket)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox CmbCategory;
        private System.Windows.Forms.TextBox TxtPrice;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView DtgBasket;
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.DataGridViewTextBoxColumn Product_Name;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Product_Category;
        private System.Windows.Forms.DataGridViewTextBoxColumn Product_Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total_;
    }
}

