namespace WinFormProjects_2
{
    partial class FrmDetail
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.MskBirthday = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtMail = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.MskPhone = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnUpdate = new System.Windows.Forms.Button();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.CmbStudent = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.MskBirthday);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.TxtMail);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.MskPhone);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.TxtName);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(12, 72);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(351, 206);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Öğrenci Bilgileri    ";
            // 
            // MskBirthday
            // 
            this.MskBirthday.Location = new System.Drawing.Point(152, 163);
            this.MskBirthday.Mask = "00-00-0000";
            this.MskBirthday.Name = "MskBirthday";
            this.MskBirthday.Size = new System.Drawing.Size(98, 20);
            this.MskBirthday.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(9, 166);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Doğum Tarihi : ";
            // 
            // TxtMail
            // 
            this.TxtMail.Location = new System.Drawing.Point(130, 119);
            this.TxtMail.Name = "TxtMail";
            this.TxtMail.Size = new System.Drawing.Size(197, 20);
            this.TxtMail.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(67, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Email : ";
            // 
            // MskPhone
            // 
            this.MskPhone.Location = new System.Drawing.Point(146, 74);
            this.MskPhone.Mask = "(999) 000-0000";
            this.MskPhone.Name = "MskPhone";
            this.MskPhone.Size = new System.Drawing.Size(128, 20);
            this.MskPhone.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(58, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tel No : ";
            // 
            // TxtName
            // 
            this.TxtName.Location = new System.Drawing.Point(130, 33);
            this.TxtName.Name = "TxtName";
            this.TxtName.Size = new System.Drawing.Size(197, 20);
            this.TxtName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(28, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "İsim Soyad : ";
            // 
            // BtnUpdate
            // 
            this.BtnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnUpdate.Location = new System.Drawing.Point(30, 300);
            this.BtnUpdate.Name = "BtnUpdate";
            this.BtnUpdate.Size = new System.Drawing.Size(147, 36);
            this.BtnUpdate.TabIndex = 8;
            this.BtnUpdate.Text = "Güncelle";
            this.BtnUpdate.UseVisualStyleBackColor = true;
            this.BtnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // BtnDelete
            // 
            this.BtnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnDelete.Location = new System.Drawing.Point(236, 300);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(97, 36);
            this.BtnDelete.TabIndex = 9;
            this.BtnDelete.Text = "Sil";
            this.BtnDelete.UseVisualStyleBackColor = true;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // CmbStudent
            // 
            this.CmbStudent.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.CmbStudent.FormattingEnabled = true;
            this.CmbStudent.Location = new System.Drawing.Point(152, 24);
            this.CmbStudent.Name = "CmbStudent";
            this.CmbStudent.Size = new System.Drawing.Size(181, 26);
            this.CmbStudent.TabIndex = 10;
            this.CmbStudent.SelectedValueChanged += new System.EventHandler(this.CmbStudent_SelectedValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(36, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 18);
            this.label5.TabIndex = 11;
            this.label5.Text = "Öğrenciler : ";
            // 
            // FrmDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 361);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.CmbStudent);
            this.Controls.Add(this.BtnDelete);
            this.Controls.Add(this.BtnUpdate);
            this.Controls.Add(this.groupBox2);
            this.Name = "FrmDetail";
            this.ShowIcon = false;
            this.Text = "Öğrenci Detayları";
            this.Load += new System.EventHandler(this.FrmDetail_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button BtnUpdate;
        private System.Windows.Forms.MaskedTextBox MskBirthday;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtMail;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox MskPhone;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.ComboBox CmbStudent;
        private System.Windows.Forms.Label label5;
    }
}