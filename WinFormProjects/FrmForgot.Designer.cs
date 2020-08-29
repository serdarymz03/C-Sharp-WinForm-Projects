namespace WinFormProjects
{
    partial class FrmForgot
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
            this.label1 = new System.Windows.Forms.Label();
            this.TxtQuestion = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtAnswer = new System.Windows.Forms.TextBox();
            this.BtnControl = new System.Windows.Forms.Button();
            this.TxtPassword = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtPassword2 = new System.Windows.Forms.TextBox();
            this.BtnUpdatePassword = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(13, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Gizli Soru :";
            // 
            // TxtQuestion
            // 
            this.TxtQuestion.Enabled = false;
            this.TxtQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtQuestion.Location = new System.Drawing.Point(131, 34);
            this.TxtQuestion.Name = "TxtQuestion";
            this.TxtQuestion.Size = new System.Drawing.Size(189, 24);
            this.TxtQuestion.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(13, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Gizli Cevap :";
            // 
            // TxtAnswer
            // 
            this.TxtAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtAnswer.Location = new System.Drawing.Point(131, 80);
            this.TxtAnswer.Name = "TxtAnswer";
            this.TxtAnswer.Size = new System.Drawing.Size(189, 24);
            this.TxtAnswer.TabIndex = 4;
            this.TxtAnswer.UseSystemPasswordChar = true;
            // 
            // BtnControl
            // 
            this.BtnControl.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BtnControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnControl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnControl.Location = new System.Drawing.Point(58, 123);
            this.BtnControl.Name = "BtnControl";
            this.BtnControl.Size = new System.Drawing.Size(225, 42);
            this.BtnControl.TabIndex = 6;
            this.BtnControl.Text = "Cevabı Kontrol Et";
            this.BtnControl.UseVisualStyleBackColor = false;
            this.BtnControl.Click += new System.EventHandler(this.BtnControl_Click);
            // 
            // TxtPassword
            // 
            this.TxtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtPassword.Location = new System.Drawing.Point(127, 34);
            this.TxtPassword.Name = "TxtPassword";
            this.TxtPassword.Size = new System.Drawing.Size(189, 24);
            this.TxtPassword.TabIndex = 7;
            this.TxtPassword.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(18, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Yeni Şifre : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(3, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Şifre Tekrar : ";
            // 
            // TxtPassword2
            // 
            this.TxtPassword2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtPassword2.Location = new System.Drawing.Point(127, 76);
            this.TxtPassword2.Name = "TxtPassword2";
            this.TxtPassword2.Size = new System.Drawing.Size(189, 24);
            this.TxtPassword2.TabIndex = 9;
            this.TxtPassword2.UseSystemPasswordChar = true;
            // 
            // BtnUpdatePassword
            // 
            this.BtnUpdatePassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.BtnUpdatePassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnUpdatePassword.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnUpdatePassword.Location = new System.Drawing.Point(36, 112);
            this.BtnUpdatePassword.Name = "BtnUpdatePassword";
            this.BtnUpdatePassword.Size = new System.Drawing.Size(225, 48);
            this.BtnUpdatePassword.TabIndex = 11;
            this.BtnUpdatePassword.Text = "Şifreyi Güncelle";
            this.BtnUpdatePassword.UseVisualStyleBackColor = false;
            this.BtnUpdatePassword.Click += new System.EventHandler(this.BtnUpdatePassword_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BtnUpdatePassword);
            this.groupBox1.Controls.Add(this.TxtPassword);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.TxtPassword2);
            this.groupBox1.Enabled = false;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(12, 226);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(330, 194);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Şifre İşlemleri    ";
            // 
            // FrmForgot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 432);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.BtnControl);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtAnswer);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtQuestion);
            this.Name = "FrmForgot";
            this.ShowIcon = false;
            this.Text = "Şifre Yenileme Paneli";
            this.Load += new System.EventHandler(this.FrmForgot_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox TxtQuestion;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox TxtAnswer;
        private System.Windows.Forms.Button BtnControl;
        public System.Windows.Forms.TextBox TxtPassword;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox TxtPassword2;
        private System.Windows.Forms.Button BtnUpdatePassword;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}