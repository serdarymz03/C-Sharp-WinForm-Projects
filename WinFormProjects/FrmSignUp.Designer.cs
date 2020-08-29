namespace WinFormProjects
{
    partial class FrmSignUp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSignUp));
            this.label1 = new System.Windows.Forms.Label();
            this.TxtUserName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtPassword = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtPassword2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtQuestion = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtAnswer = new System.Windows.Forms.TextBox();
            this.BtnSignUp = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(12, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Kullanıcı Adı : ";
            // 
            // TxtUserName
            // 
            this.TxtUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtUserName.Location = new System.Drawing.Point(169, 44);
            this.TxtUserName.Name = "TxtUserName";
            this.TxtUserName.Size = new System.Drawing.Size(189, 29);
            this.TxtUserName.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(94, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Şifre : ";
            // 
            // TxtPassword
            // 
            this.TxtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtPassword.Location = new System.Drawing.Point(169, 86);
            this.TxtPassword.Name = "TxtPassword";
            this.TxtPassword.Size = new System.Drawing.Size(189, 29);
            this.TxtPassword.TabIndex = 4;
            this.TxtPassword.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(18, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "Şifre Tekrar : ";
            // 
            // TxtPassword2
            // 
            this.TxtPassword2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtPassword2.Location = new System.Drawing.Point(169, 126);
            this.TxtPassword2.Name = "TxtPassword2";
            this.TxtPassword2.Size = new System.Drawing.Size(189, 29);
            this.TxtPassword2.TabIndex = 6;
            this.TxtPassword2.UseSystemPasswordChar = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label4.Location = new System.Drawing.Point(38, 166);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 25);
            this.label4.TabIndex = 9;
            this.label4.Text = "Gizli Soru : ";
            // 
            // TxtQuestion
            // 
            this.TxtQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtQuestion.Location = new System.Drawing.Point(169, 166);
            this.TxtQuestion.Name = "TxtQuestion";
            this.TxtQuestion.Size = new System.Drawing.Size(189, 29);
            this.TxtQuestion.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label5.Location = new System.Drawing.Point(21, 206);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(142, 25);
            this.label5.TabIndex = 11;
            this.label5.Text = "Gizli Cevap : ";
            // 
            // TxtAnswer
            // 
            this.TxtAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtAnswer.Location = new System.Drawing.Point(169, 206);
            this.TxtAnswer.Name = "TxtAnswer";
            this.TxtAnswer.Size = new System.Drawing.Size(189, 29);
            this.TxtAnswer.TabIndex = 10;
            // 
            // BtnSignUp
            // 
            this.BtnSignUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnSignUp.Location = new System.Drawing.Point(99, 265);
            this.BtnSignUp.Name = "BtnSignUp";
            this.BtnSignUp.Size = new System.Drawing.Size(192, 42);
            this.BtnSignUp.TabIndex = 12;
            this.BtnSignUp.Text = "KAYDOL";
            this.BtnSignUp.UseVisualStyleBackColor = true;
            this.BtnSignUp.Click += new System.EventHandler(this.BtnSignUp_Click);
            // 
            // FrmSignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(399, 365);
            this.Controls.Add(this.BtnSignUp);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TxtAnswer);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TxtQuestion);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxtPassword2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtPassword);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtUserName);
            this.DoubleBuffered = true;
            this.Name = "FrmSignUp";
            this.ShowIcon = false;
            this.Text = "Kaydolma Penceresi";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtUserName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtPassword;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtPassword2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtQuestion;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtAnswer;
        private System.Windows.Forms.Button BtnSignUp;
    }
}