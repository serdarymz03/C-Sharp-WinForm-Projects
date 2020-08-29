namespace WinFormProjects
{
    partial class FrmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            this.TxtUserName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtPassword = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BtnLogin = new System.Windows.Forms.Button();
            this.LnkForgot = new System.Windows.Forms.LinkLabel();
            this.LnkSignUp = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // TxtUserName
            // 
            this.TxtUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtUserName.Location = new System.Drawing.Point(128, 165);
            this.TxtUserName.Name = "TxtUserName";
            this.TxtUserName.Size = new System.Drawing.Size(189, 24);
            this.TxtUserName.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(1, 167);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Kullanıcı Adı : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(60, 205);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Şifre : ";
            // 
            // TxtPassword
            // 
            this.TxtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtPassword.Location = new System.Drawing.Point(128, 203);
            this.TxtPassword.Name = "TxtPassword";
            this.TxtPassword.Size = new System.Drawing.Size(189, 24);
            this.TxtPassword.TabIndex = 3;
            this.TxtPassword.UseSystemPasswordChar = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(52, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(226, 124);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // BtnLogin
            // 
            this.BtnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnLogin.Location = new System.Drawing.Point(63, 244);
            this.BtnLogin.Name = "BtnLogin";
            this.BtnLogin.Size = new System.Drawing.Size(188, 48);
            this.BtnLogin.TabIndex = 5;
            this.BtnLogin.Text = "Giriş Yap";
            this.BtnLogin.UseVisualStyleBackColor = true;
            this.BtnLogin.Click += new System.EventHandler(this.BtnLogin_Click);
            // 
            // LnkForgot
            // 
            this.LnkForgot.AutoSize = true;
            this.LnkForgot.BackColor = System.Drawing.Color.Transparent;
            this.LnkForgot.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LnkForgot.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.LnkForgot.LinkColor = System.Drawing.Color.White;
            this.LnkForgot.Location = new System.Drawing.Point(23, 416);
            this.LnkForgot.Name = "LnkForgot";
            this.LnkForgot.Size = new System.Drawing.Size(129, 18);
            this.LnkForgot.TabIndex = 6;
            this.LnkForgot.TabStop = true;
            this.LnkForgot.Text = "Şifremi Unuttum";
            this.LnkForgot.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LnkForgot_LinkClicked);
            // 
            // LnkSignUp
            // 
            this.LnkSignUp.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.LnkSignUp.AutoSize = true;
            this.LnkSignUp.BackColor = System.Drawing.Color.Transparent;
            this.LnkSignUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LnkSignUp.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.LnkSignUp.LinkColor = System.Drawing.Color.White;
            this.LnkSignUp.Location = new System.Drawing.Point(124, 317);
            this.LnkSignUp.Name = "LnkSignUp";
            this.LnkSignUp.Size = new System.Drawing.Size(71, 22);
            this.LnkSignUp.TabIndex = 7;
            this.LnkSignUp.TabStop = true;
            this.LnkSignUp.Text = "Kaydol";
            this.LnkSignUp.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.LnkSignUp.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LnkSignUp_LinkClicked);
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(333, 459);
            this.Controls.Add(this.LnkSignUp);
            this.Controls.Add(this.LnkForgot);
            this.Controls.Add(this.BtnLogin);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.TxtPassword);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtUserName);
            this.DoubleBuffered = true;
            this.Name = "FrmLogin";
            this.ShowIcon = false;
            this.Text = "Login Ekranı";
            this.Load += new System.EventHandler(this.FrmLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtPassword;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button BtnLogin;
        private System.Windows.Forms.LinkLabel LnkForgot;
        private System.Windows.Forms.LinkLabel LnkSignUp;
        public System.Windows.Forms.TextBox TxtUserName;
    }
}

