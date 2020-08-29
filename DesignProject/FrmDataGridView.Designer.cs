namespace DesignProject
{
    partial class FrmDataGridView
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.DtgList = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ıdyiGösterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.başlığıDeğiştirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.DtgList)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // DtgList
            // 
            this.DtgList.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DtgList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DtgList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DtgList.ContextMenuStrip = this.contextMenuStrip1;
            this.DtgList.Cursor = System.Windows.Forms.Cursors.PanWest;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DtgList.DefaultCellStyle = dataGridViewCellStyle2;
            this.DtgList.Location = new System.Drawing.Point(54, 55);
            this.DtgList.MultiSelect = false;
            this.DtgList.Name = "DtgList";
            this.DtgList.ReadOnly = true;
            this.DtgList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DtgList.Size = new System.Drawing.Size(604, 150);
            this.DtgList.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ıdyiGösterToolStripMenuItem,
            this.başlığıDeğiştirToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(152, 48);
            // 
            // ıdyiGösterToolStripMenuItem
            // 
            this.ıdyiGösterToolStripMenuItem.Name = "ıdyiGösterToolStripMenuItem";
            this.ıdyiGösterToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.ıdyiGösterToolStripMenuItem.Text = "Id\'yi Göster";
            this.ıdyiGösterToolStripMenuItem.Click += new System.EventHandler(this.ıdyiGösterToolStripMenuItem_Click);
            // 
            // başlığıDeğiştirToolStripMenuItem
            // 
            this.başlığıDeğiştirToolStripMenuItem.Name = "başlığıDeğiştirToolStripMenuItem";
            this.başlığıDeğiştirToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.başlığıDeğiştirToolStripMenuItem.Text = "Başlığı Değiştir";
            this.başlığıDeğiştirToolStripMenuItem.Click += new System.EventHandler(this.başlığıDeğiştirToolStripMenuItem_Click);
            // 
            // FrmDataGridView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DtgList);
            this.Name = "FrmDataGridView";
            this.Text = "FrmDataGridView";
            this.Load += new System.EventHandler(this.FrmDataGridView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DtgList)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DtgList;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ıdyiGösterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem başlığıDeğiştirToolStripMenuItem;
    }
}