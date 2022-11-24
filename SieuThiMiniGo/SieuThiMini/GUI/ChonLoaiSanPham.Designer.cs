namespace SieuThiMini.GUI
{
    partial class ChonLoaiSanPham
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
            this.btnChonLoaiSP = new System.Windows.Forms.Button();
            this.tableChonLoaiSP = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tableChonLoaiSP)).BeginInit();
            this.SuspendLayout();
            // 
            // btnChonLoaiSP
            // 
            this.btnChonLoaiSP.Image = global::SieuThiMini.Properties.Resources.confirm;
            this.btnChonLoaiSP.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnChonLoaiSP.Location = new System.Drawing.Point(255, 395);
            this.btnChonLoaiSP.Name = "btnChonLoaiSP";
            this.btnChonLoaiSP.Size = new System.Drawing.Size(128, 54);
            this.btnChonLoaiSP.TabIndex = 10;
            this.btnChonLoaiSP.Text = "Chọn";
            this.btnChonLoaiSP.UseVisualStyleBackColor = true;
            this.btnChonLoaiSP.Click += new System.EventHandler(this.btnChonLoaiSP_Click);
            // 
            // tableChonLoaiSP
            // 
            this.tableChonLoaiSP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableChonLoaiSP.Location = new System.Drawing.Point(28, 95);
            this.tableChonLoaiSP.Name = "tableChonLoaiSP";
            this.tableChonLoaiSP.RowHeadersWidth = 51;
            this.tableChonLoaiSP.RowTemplate.Height = 24;
            this.tableChonLoaiSP.Size = new System.Drawing.Size(600, 274);
            this.tableChonLoaiSP.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(118, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(441, 57);
            this.label1.TabIndex = 8;
            this.label1.Text = "Danh Sách Loại Sản Phẩm";
            // 
            // ChonLoaiSanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(659, 465);
            this.Controls.Add(this.btnChonLoaiSP);
            this.Controls.Add(this.tableChonLoaiSP);
            this.Controls.Add(this.label1);
            this.Name = "ChonLoaiSanPham";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ChonLoaiSanPham";
            ((System.ComponentModel.ISupportInitialize)(this.tableChonLoaiSP)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnChonLoaiSP;
        private System.Windows.Forms.DataGridView tableChonLoaiSP;
        private System.Windows.Forms.Label label1;
    }
}