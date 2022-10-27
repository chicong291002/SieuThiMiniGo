namespace SieuThiMini
{
    partial class ChonNhaCungCap
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label1 = new System.Windows.Forms.Label();
            this.tableChonNV = new System.Windows.Forms.DataGridView();
            this.btnChonNV = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tableChonNV)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(240, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Thông Tin Nhà Cung Cấp";
            // 
            // tableChonNV
            // 
            this.tableChonNV.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.tableChonNV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.tableChonNV.ColumnHeadersHeight = 29;
            this.tableChonNV.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tableChonNV.Location = new System.Drawing.Point(44, 107);
            this.tableChonNV.Name = "tableChonNV";
            this.tableChonNV.ReadOnly = true;
            this.tableChonNV.RowHeadersVisible = false;
            this.tableChonNV.RowHeadersWidth = 51;
            this.tableChonNV.RowTemplate.Height = 24;
            this.tableChonNV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tableChonNV.Size = new System.Drawing.Size(567, 249);
            this.tableChonNV.TabIndex = 3;
            // 
            // btnChonNV
            // 
            this.btnChonNV.Location = new System.Drawing.Point(271, 401);
            this.btnChonNV.Name = "btnChonNV";
            this.btnChonNV.Size = new System.Drawing.Size(105, 37);
            this.btnChonNV.TabIndex = 4;
            this.btnChonNV.Text = "Chọn";
            this.btnChonNV.UseVisualStyleBackColor = true;
            this.btnChonNV.Click += new System.EventHandler(this.btnChonNV_Click);
            // 
            // ChonNhaCungCap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ClientSize = new System.Drawing.Size(647, 450);
            this.Controls.Add(this.btnChonNV);
            this.Controls.Add(this.tableChonNV);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.Name = "ChonNhaCungCap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ChonNhanVien";
            ((System.ComponentModel.ISupportInitialize)(this.tableChonNV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView tableChonNV;
        private System.Windows.Forms.Button btnChonNV;
    }
}