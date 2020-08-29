namespace DesignProject
{
    partial class Form3
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
            this.RdbA = new System.Windows.Forms.RadioButton();
            this.RdbB = new System.Windows.Forms.RadioButton();
            this.RdbD = new System.Windows.Forms.RadioButton();
            this.RdbC = new System.Windows.Forms.RadioButton();
            this.BtnSend = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // RdbA
            // 
            this.RdbA.AutoSize = true;
            this.RdbA.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.RdbA.Location = new System.Drawing.Point(34, 26);
            this.RdbA.Name = "RdbA";
            this.RdbA.Size = new System.Drawing.Size(35, 22);
            this.RdbA.TabIndex = 0;
            this.RdbA.Text = "A";
            this.RdbA.UseVisualStyleBackColor = true;
            // 
            // RdbB
            // 
            this.RdbB.AutoSize = true;
            this.RdbB.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.RdbB.Location = new System.Drawing.Point(34, 66);
            this.RdbB.Name = "RdbB";
            this.RdbB.Size = new System.Drawing.Size(36, 22);
            this.RdbB.TabIndex = 1;
            this.RdbB.TabStop = true;
            this.RdbB.Text = "B";
            this.RdbB.UseVisualStyleBackColor = true;
            // 
            // RdbD
            // 
            this.RdbD.AutoSize = true;
            this.RdbD.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.RdbD.Location = new System.Drawing.Point(34, 146);
            this.RdbD.Name = "RdbD";
            this.RdbD.Size = new System.Drawing.Size(37, 22);
            this.RdbD.TabIndex = 3;
            this.RdbD.TabStop = true;
            this.RdbD.Text = "D";
            this.RdbD.UseVisualStyleBackColor = true;
            // 
            // RdbC
            // 
            this.RdbC.AutoSize = true;
            this.RdbC.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.RdbC.Location = new System.Drawing.Point(34, 106);
            this.RdbC.Name = "RdbC";
            this.RdbC.Size = new System.Drawing.Size(37, 22);
            this.RdbC.TabIndex = 2;
            this.RdbC.Text = "C";
            this.RdbC.UseVisualStyleBackColor = true;
            this.RdbC.CheckedChanged += new System.EventHandler(this.RdbC_CheckedChanged);
            // 
            // BtnSend
            // 
            this.BtnSend.Location = new System.Drawing.Point(68, 230);
            this.BtnSend.Name = "BtnSend";
            this.BtnSend.Size = new System.Drawing.Size(114, 45);
            this.BtnSend.TabIndex = 4;
            this.BtnSend.Text = "Cevabı Gönder";
            this.BtnSend.UseVisualStyleBackColor = true;
            this.BtnSend.Click += new System.EventHandler(this.BtnSend_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.RdbB);
            this.groupBox1.Controls.Add(this.RdbA);
            this.groupBox1.Controls.Add(this.RdbD);
            this.groupBox1.Controls.Add(this.RdbC);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Location = new System.Drawing.Point(21, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(294, 194);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Seçenekler   ";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioButton1);
            this.groupBox2.Controls.Add(this.radioButton2);
            this.groupBox2.Controls.Add(this.radioButton3);
            this.groupBox2.Controls.Add(this.radioButton4);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox2.Location = new System.Drawing.Point(446, 29);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(294, 194);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Seçenekler   ";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.radioButton1.Location = new System.Drawing.Point(34, 66);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(36, 22);
            this.radioButton1.TabIndex = 1;
            this.radioButton1.Text = "B";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.radioButton2.Location = new System.Drawing.Point(34, 26);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(35, 22);
            this.radioButton2.TabIndex = 0;
            this.radioButton2.Text = "A";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.radioButton3.Location = new System.Drawing.Point(34, 146);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(37, 22);
            this.radioButton3.TabIndex = 3;
            this.radioButton3.Text = "D";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.radioButton4.Location = new System.Drawing.Point(34, 106);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(37, 22);
            this.radioButton4.TabIndex = 2;
            this.radioButton4.Text = "C";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(838, 540);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.BtnSend);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RadioButton RdbA;
        private System.Windows.Forms.RadioButton RdbB;
        private System.Windows.Forms.RadioButton RdbD;
        private System.Windows.Forms.RadioButton RdbC;
        private System.Windows.Forms.Button BtnSend;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton4;
    }
}