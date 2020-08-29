namespace DesignProject
{
    partial class FormBrowser
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
            this.FolderBrowser = new System.Windows.Forms.FolderBrowserDialog();
            this.BtnFolderBrowser = new System.Windows.Forms.Button();
            this.BtnOpenFileDialog = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.RchSaveFile = new System.Windows.Forms.RichTextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnFolderBrowser
            // 
            this.BtnFolderBrowser.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnFolderBrowser.Location = new System.Drawing.Point(47, 59);
            this.BtnFolderBrowser.Name = "BtnFolderBrowser";
            this.BtnFolderBrowser.Size = new System.Drawing.Size(164, 67);
            this.BtnFolderBrowser.TabIndex = 0;
            this.BtnFolderBrowser.Text = "Folder Browser\'ı Aç";
            this.BtnFolderBrowser.UseVisualStyleBackColor = true;
            this.BtnFolderBrowser.Click += new System.EventHandler(this.BtnFolderBrowser_Click);
            // 
            // BtnOpenFileDialog
            // 
            this.BtnOpenFileDialog.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnOpenFileDialog.Location = new System.Drawing.Point(47, 183);
            this.BtnOpenFileDialog.Name = "BtnOpenFileDialog";
            this.BtnOpenFileDialog.Size = new System.Drawing.Size(164, 67);
            this.BtnOpenFileDialog.TabIndex = 1;
            this.BtnOpenFileDialog.Text = "Open File Dialog";
            this.BtnOpenFileDialog.UseVisualStyleBackColor = true;
            this.BtnOpenFileDialog.Click += new System.EventHandler(this.BtnOpenFileDialog_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // RchSaveFile
            // 
            this.RchSaveFile.Location = new System.Drawing.Point(337, 59);
            this.RchSaveFile.Name = "RchSaveFile";
            this.RchSaveFile.Size = new System.Drawing.Size(364, 138);
            this.RchSaveFile.TabIndex = 2;
            this.RchSaveFile.Text = "";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.Location = new System.Drawing.Point(427, 215);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(164, 67);
            this.button2.TabIndex = 3;
            this.button2.Text = "Save File Dialog";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // FormBrowser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.RchSaveFile);
            this.Controls.Add(this.BtnOpenFileDialog);
            this.Controls.Add(this.BtnFolderBrowser);
            this.Name = "FormBrowser";
            this.Text = "FormBrowser";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FolderBrowserDialog FolderBrowser;
        private System.Windows.Forms.Button BtnFolderBrowser;
        private System.Windows.Forms.Button BtnOpenFileDialog;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.RichTextBox RchSaveFile;
        private System.Windows.Forms.Button button2;
    }
}