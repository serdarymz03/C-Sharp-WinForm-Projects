namespace DesignProject
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.label1 = new System.Windows.Forms.Label();
            this.TxtUserName = new System.Windows.Forms.TextBox();
            this.TxtPassword = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnLogin = new System.Windows.Forms.Button();
            this.DatePicker = new System.Windows.Forms.DateTimePicker();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dosyaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newProjectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newClassToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newInterfaceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.MskTc = new System.Windows.Forms.MaskedTextBox();
            this.BtnLogin2 = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(30, 200);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kullanıcı Adı : ";
            // 
            // TxtUserName
            // 
            this.TxtUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtUserName.Location = new System.Drawing.Point(158, 197);
            this.TxtUserName.Name = "TxtUserName";
            this.TxtUserName.Size = new System.Drawing.Size(205, 26);
            this.TxtUserName.TabIndex = 1;
            // 
            // TxtPassword
            // 
            this.TxtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtPassword.Location = new System.Drawing.Point(158, 235);
            this.TxtPassword.Name = "TxtPassword";
            this.TxtPassword.Size = new System.Drawing.Size(205, 26);
            this.TxtPassword.TabIndex = 3;
            this.TxtPassword.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(81, 238);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Şifre : ";
            // 
            // BtnLogin
            // 
            this.BtnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnLogin.Location = new System.Drawing.Point(186, 278);
            this.BtnLogin.Name = "BtnLogin";
            this.BtnLogin.Size = new System.Drawing.Size(125, 43);
            this.BtnLogin.TabIndex = 4;
            this.BtnLogin.Text = "Giriş Yap";
            this.BtnLogin.UseVisualStyleBackColor = true;
            this.BtnLogin.Click += new System.EventHandler(this.BtnLogin_Click);
            // 
            // DatePicker
            // 
            this.DatePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.DatePicker.Location = new System.Drawing.Point(512, 34);
            this.DatePicker.Name = "DatePicker";
            this.DatePicker.Size = new System.Drawing.Size(265, 24);
            this.DatePicker.TabIndex = 5;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dosyaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dosyaToolStripMenuItem
            // 
            this.dosyaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newProjectToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.dosyaToolStripMenuItem.Name = "dosyaToolStripMenuItem";
            this.dosyaToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.dosyaToolStripMenuItem.Text = "File";
            // 
            // newProjectToolStripMenuItem
            // 
            this.newProjectToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newClassToolStripMenuItem,
            this.newInterfaceToolStripMenuItem});
            this.newProjectToolStripMenuItem.Name = "newProjectToolStripMenuItem";
            this.newProjectToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.newProjectToolStripMenuItem.Text = "New Project";
            // 
            // newClassToolStripMenuItem
            // 
            this.newClassToolStripMenuItem.Name = "newClassToolStripMenuItem";
            this.newClassToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.newClassToolStripMenuItem.Text = "New Class";
            // 
            // newInterfaceToolStripMenuItem
            // 
            this.newInterfaceToolStripMenuItem.Name = "newInterfaceToolStripMenuItem";
            this.newInterfaceToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.newInterfaceToolStripMenuItem.Text = "New Interface";
            this.newInterfaceToolStripMenuItem.Click += new System.EventHandler(this.newInterfaceToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.saveToolStripMenuItem.Text = "Save";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(52, 34);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(259, 131);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.maskedTextBox1.Location = new System.Drawing.Point(459, 194);
            this.maskedTextBox1.Mask = "(999) 000-0000";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(229, 26);
            this.maskedTextBox1.TabIndex = 8;
            // 
            // MskTc
            // 
            this.MskTc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MskTc.Location = new System.Drawing.Point(512, 256);
            this.MskTc.Mask = "00000000000";
            this.MskTc.Name = "MskTc";
            this.MskTc.Size = new System.Drawing.Size(134, 26);
            this.MskTc.TabIndex = 9;
            this.MskTc.ValidatingType = typeof(int);
            // 
            // BtnLogin2
            // 
            this.BtnLogin2.Location = new System.Drawing.Point(565, 314);
            this.BtnLogin2.Name = "BtnLogin2";
            this.BtnLogin2.Size = new System.Drawing.Size(75, 23);
            this.BtnLogin2.TabIndex = 10;
            this.BtnLogin2.Text = "button1";
            this.BtnLogin2.UseVisualStyleBackColor = true;
            this.BtnLogin2.Click += new System.EventHandler(this.BtnLogin2_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(314, 377);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 43);
            this.button1.TabIndex = 11;
            this.button1.Text = "Giriş Yap";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BtnLogin2);
            this.Controls.Add(this.MskTc);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.DatePicker);
            this.Controls.Add(this.BtnLogin);
            this.Controls.Add(this.TxtPassword);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtUserName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtUserName;
        private System.Windows.Forms.TextBox TxtPassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnLogin;
        private System.Windows.Forms.DateTimePicker DatePicker;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dosyaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newProjectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newClassToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newInterfaceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.MaskedTextBox MskTc;
        private System.Windows.Forms.Button BtnLogin2;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button button1;
    }
}