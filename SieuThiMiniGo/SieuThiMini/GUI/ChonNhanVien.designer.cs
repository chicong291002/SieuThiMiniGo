namespace SieuThiMini
{
    partial class ChonNhanVien
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
            this.tableChonNV = new System.Windows.Forms.DataGridView();
            this.btnChonNV = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tableChonNV)).BeginInit();
            this.SuspendLayout();
            // 
            // tableChonNV
            // 
            this.tableChonNV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableChonNV.Location = new System.Drawing.Point(23, 86);
            this.tableChonNV.Name = "tableChonNV";
            this.tableChonNV.RowHeadersWidth = 51;
            this.tableChonNV.RowTemplate.Height = 24;
            this.tableChonNV.Size = new System.Drawing.Size(600, 274);
            this.tableChonNV.TabIndex = 3;
            this.tableChonNV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tableChonNV_CellContentClick);
            // 
            // btnChonNV
            // 
            this.btnChonNV.Image = global::SieuThiMini.Properties.Resources.add11;
            this.btnChonNV.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnChonNV.Location = new System.Drawing.Point(270, 384);
            this.btnChonNV.Name = "btnChonNV";
            this.btnChonNV.Size = new System.Drawing.Size(128, 54);
            this.btnChonNV.TabIndex = 4;
            this.btnChonNV.Text = "Chọn";
            this.btnChonNV.UseVisualStyleBackColor = true;
            this.btnChonNV.Click += new System.EventHandler(this.btnChonNV_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(135, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(392, 57);
            this.label1.TabIndex = 1;
            this.label1.Text = "Danh Sách Nhân Viên";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // ChonNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(647, 450);
            this.Controls.Add(this.btnChonNV);
            this.Controls.Add(this.tableChonNV);
            this.Controls.Add(this.label1);
            this.Name = "ChonNhanVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ChonNhanVien";
            ((System.ComponentModel.ISupportInitialize)(this.tableChonNV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.DataGridView tableChonNV;
        private System.Windows.Forms.Button btnChonNV;
        private System.Windows.Forms.Label label1;
    }
}