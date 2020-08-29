namespace DesignProject
{
    partial class FrmCombobox
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
            this.CmbMenu = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CmbMenu
            // 
            this.CmbMenu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.CmbMenu.FormattingEnabled = true;
            this.CmbMenu.Location = new System.Drawing.Point(90, 76);
            this.CmbMenu.Name = "CmbMenu";
            this.CmbMenu.Size = new System.Drawing.Size(219, 26);
            this.CmbMenu.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(127, 128);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(126, 45);
            this.button1.TabIndex = 1;
            this.button1.Text = "Seçili Elemanı Göster";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FrmCombobox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.CmbMenu);
            this.Name = "FrmCombobox";
            this.Text = "FrmCombobox";
            this.Load += new System.EventHandler(this.FrmCombobox_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox CmbMenu;
        private System.Windows.Forms.Button button1;
    }
}