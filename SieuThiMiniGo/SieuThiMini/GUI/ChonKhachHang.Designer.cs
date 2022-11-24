namespace SieuThiMini.GUI
{
    partial class ChonKhachHang
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
            this.btnChonKH = new System.Windows.Forms.Button();
            this.tableChonKH = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tableChonKH)).BeginInit();
            this.SuspendLayout();
            // 
            // btnChonKH
            // 
            this.btnChonKH.Image = global::SieuThiMini.Properties.Resources.confirm;
            this.btnChonKH.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnChonKH.Location = new System.Drawing.Point(272, 384);
            this.btnChonKH.Name = "btnChonKH";
            this.btnChonKH.Size = new System.Drawing.Size(128, 54);
            this.btnChonKH.TabIndex = 7;
            this.btnChonKH.Text = "Chọn";
            this.btnChonKH.UseVisualStyleBackColor = true;
            this.btnChonKH.Click += new System.EventHandler(this.btnChonKH_Click);
            // 
            // tableChonKH
            // 
            this.tableChonKH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableChonKH.Location = new System.Drawing.Point(35, 84);
            this.tableChonKH.Name = "tableChonKH";
            this.tableChonKH.RowHeadersWidth = 51;
            this.tableChonKH.RowTemplate.Height = 24;
            this.tableChonKH.Size = new System.Drawing.Size(600, 274);
            this.tableChonKH.TabIndex = 6;
            this.tableChonKH.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tableChonKH_CellContentClick);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(148, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(392, 57);
            this.label1.TabIndex = 5;
            this.label1.Text = "Danh Sách Khách Hàng";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // ChonKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cyan;
            this.ClientSize = new System.Drawing.Size(677, 459);
            this.Controls.Add(this.btnChonKH);
            this.Controls.Add(this.tableChonKH);
            this.Controls.Add(this.label1);
            this.Name = "ChonKhachHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ChonKhachHang";
            ((System.ComponentModel.ISupportInitialize)(this.tableChonKH)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnChonKH;
        private System.Windows.Forms.DataGridView tableChonKH;
        private System.Windows.Forms.Label label1;
    }
}