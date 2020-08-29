namespace DesignProject
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
            this.BtnHello = new System.Windows.Forms.Button();
            this.TxtMessage = new System.Windows.Forms.TextBox();
            this.BtnMessage = new System.Windows.Forms.Button();
            this.ChcFirst = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // BtnHello
            // 
            this.BtnHello.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BtnHello.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnHello.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.BtnHello.Font = new System.Drawing.Font("MS PGothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnHello.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnHello.Location = new System.Drawing.Point(25, 53);
            this.BtnHello.Name = "BtnHello";
            this.BtnHello.Padding = new System.Windows.Forms.Padding(15);
            this.BtnHello.Size = new System.Drawing.Size(147, 93);
            this.BtnHello.TabIndex = 0;
            this.BtnHello.Text = "Ekrana Yansıt";
            this.BtnHello.UseVisualStyleBackColor = false;
            this.BtnHello.Click += new System.EventHandler(this.BtnHello_Click);
            // 
            // TxtMessage
            // 
            this.TxtMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtMessage.Location = new System.Drawing.Point(334, 66);
            this.TxtMessage.Name = "TxtMessage";
            this.TxtMessage.Size = new System.Drawing.Size(223, 26);
            this.TxtMessage.TabIndex = 1;
            // 
            // BtnMessage
            // 
            this.BtnMessage.Location = new System.Drawing.Point(364, 107);
            this.BtnMessage.Name = "BtnMessage";
            this.BtnMessage.Size = new System.Drawing.Size(160, 39);
            this.BtnMessage.TabIndex = 2;
            this.BtnMessage.Text = "Mesajı Ekrana Yansıt";
            this.BtnMessage.UseVisualStyleBackColor = true;
            this.BtnMessage.Click += new System.EventHandler(this.BtnMessage_Click);
            // 
            // ChcFirst
            // 
            this.ChcFirst.AutoSize = true;
            this.ChcFirst.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ChcFirst.Location = new System.Drawing.Point(41, 182);
            this.ChcFirst.Name = "ChcFirst";
            this.ChcFirst.Size = new System.Drawing.Size(60, 22);
            this.ChcFirst.TabIndex = 3;
            this.ChcFirst.Text = "ABC";
            this.ChcFirst.UseVisualStyleBackColor = true;
            this.ChcFirst.CheckedChanged += new System.EventHandler(this.ChcFirst_CheckedChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.checkBox2.Location = new System.Drawing.Point(41, 206);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(60, 22);
            this.checkBox2.TabIndex = 4;
            this.checkBox2.Text = "DEF";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.checkBox3.Location = new System.Drawing.Point(41, 230);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(61, 22);
            this.checkBox3.TabIndex = 5;
            this.checkBox3.Text = "GHJ";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.checkBox3);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.ChcFirst);
            this.Controls.Add(this.BtnMessage);
            this.Controls.Add(this.TxtMessage);
            this.Controls.Add(this.BtnHello);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnHello;
        private System.Windows.Forms.TextBox TxtMessage;
        private System.Windows.Forms.Button BtnMessage;
        private System.Windows.Forms.CheckBox ChcFirst;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox3;
    }
}

