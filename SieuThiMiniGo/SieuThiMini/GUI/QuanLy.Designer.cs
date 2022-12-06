using SieuThiMini.GUI;

namespace SieuThiMini
{
    partial class QuanLy
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
        [System.Obsolete]
        private void InitializeComponent()
        {
            this.panelThongTin = new System.Windows.Forms.Panel();
            this.UC_ThongKe = new SieuThiMini.GUI.UserCThongKe();
            this.UC_TaiKhoan = new SieuThiMini.GUI.UCTaiKhoan();
            this.UC_NV = new SieuThiMini.UCNhanVien();
            this.UC_SP = new SieuThiMini.UCSP();
            this.UC_CTKM = new SieuThiMini.UCCTKM();
            this.UC_NhapHang = new SieuThiMini.GUI.UCNhapHang();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnBanHang = new System.Windows.Forms.Button();
            this.btnNhapHang = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button9 = new System.Windows.Forms.Button();
            this.btnThongKe = new System.Windows.Forms.Button();
            this.btnTaiKhoan = new System.Windows.Forms.Button();
            this.btnNhanVien = new System.Windows.Forms.Button();
            this.btnSanPham = new System.Windows.Forms.Button();
            this.btnCTKM = new System.Windows.Forms.Button();
            this.panelThongTin.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelThongTin
            // 
            this.panelThongTin.Controls.Add(this.UC_ThongKe);
            this.panelThongTin.Controls.Add(this.UC_TaiKhoan);
            this.panelThongTin.Controls.Add(this.UC_NV);
            this.panelThongTin.Controls.Add(this.UC_SP);
            this.panelThongTin.Controls.Add(this.UC_CTKM);
            this.panelThongTin.Controls.Add(this.UC_NhapHang);
            this.panelThongTin.Location = new System.Drawing.Point(333, 4);
            this.panelThongTin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelThongTin.Name = "panelThongTin";
            this.panelThongTin.Size = new System.Drawing.Size(1405, 801);
            this.panelThongTin.TabIndex = 1;
            // 
            // UC_ThongKe
            // 
            this.UC_ThongKe.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.UC_ThongKe.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.UC_ThongKe.Location = new System.Drawing.Point(3, -3);
            this.UC_ThongKe.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.UC_ThongKe.Name = "UC_ThongKe";
            this.UC_ThongKe.Size = new System.Drawing.Size(1399, 801);
            this.UC_ThongKe.TabIndex = 7;
            this.UC_ThongKe.Load += new System.EventHandler(this.UC_ThongKe_Load);
            // 
            // UC_TaiKhoan
            // 
            this.UC_TaiKhoan.BackColor = System.Drawing.SystemColors.HighlightText;
            this.UC_TaiKhoan.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.UC_TaiKhoan.Location = new System.Drawing.Point(3, 0);
            this.UC_TaiKhoan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.UC_TaiKhoan.Name = "UC_TaiKhoan";
            this.UC_TaiKhoan.Size = new System.Drawing.Size(1402, 796);
            this.UC_TaiKhoan.TabIndex = 4;
            // 
            // UC_NV
            // 
            this.UC_NV.BackColor = System.Drawing.SystemColors.HighlightText;
            this.UC_NV.ForeColor = System.Drawing.Color.Blue;
            this.UC_NV.Location = new System.Drawing.Point(3, -2);
            this.UC_NV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.UC_NV.Name = "UC_NV";
            this.UC_NV.Size = new System.Drawing.Size(1399, 801);
            this.UC_NV.TabIndex = 2;
            // 
            // UC_SP
            // 
            this.UC_SP.BackColor = System.Drawing.SystemColors.HighlightText;
            this.UC_SP.Location = new System.Drawing.Point(0, 0);
            this.UC_SP.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.UC_SP.Name = "UC_SP";
            this.UC_SP.Size = new System.Drawing.Size(1402, 801);
            this.UC_SP.TabIndex = 1;
            // 
            // UC_CTKM
            // 
            this.UC_CTKM.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.UC_CTKM.Location = new System.Drawing.Point(0, 0);
            this.UC_CTKM.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.UC_CTKM.Name = "UC_CTKM";
            this.UC_CTKM.Size = new System.Drawing.Size(1405, 801);
            this.UC_CTKM.TabIndex = 0;
            // 
            // UC_NhapHang
            // 
            this.UC_NhapHang.BackColor = System.Drawing.SystemColors.HighlightText;
            this.UC_NhapHang.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.UC_NhapHang.Location = new System.Drawing.Point(0, 0);
            this.UC_NhapHang.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.UC_NhapHang.Name = "UC_NhapHang";
            this.UC_NhapHang.Size = new System.Drawing.Size(1402, 801);
            this.UC_NhapHang.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.AllowDrop = true;
            this.panel1.Controls.Add(this.btnBanHang);
            this.panel1.Controls.Add(this.btnNhapHang);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.button9);
            this.panel1.Controls.Add(this.btnThongKe);
            this.panel1.Controls.Add(this.btnTaiKhoan);
            this.panel1.Controls.Add(this.btnNhanVien);
            this.panel1.Controls.Add(this.btnSanPham);
            this.panel1.Controls.Add(this.btnCTKM);
            this.panel1.Location = new System.Drawing.Point(3, 4);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(332, 798);
            this.panel1.TabIndex = 2;
            // 
            // btnBanHang
            // 
            this.btnBanHang.Image = global::SieuThiMini.Properties.Resources.sales;
            this.btnBanHang.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.btnBanHang.Location = new System.Drawing.Point(66, 246);
            this.btnBanHang.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBanHang.Name = "btnBanHang";
            this.btnBanHang.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnBanHang.Size = new System.Drawing.Size(228, 52);
            this.btnBanHang.TabIndex = 24;
            this.btnBanHang.Text = "Bán Hàng";
            this.btnBanHang.UseVisualStyleBackColor = true;
            this.btnBanHang.Click += new System.EventHandler(this.btnBanHang_Click);
            // 
            // btnNhapHang
            // 
            this.btnNhapHang.Image = global::SieuThiMini.Properties.Resources.importGoods;
            this.btnNhapHang.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNhapHang.Location = new System.Drawing.Point(66, 314);
            this.btnNhapHang.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnNhapHang.Name = "btnNhapHang";
            this.btnNhapHang.Size = new System.Drawing.Size(228, 57);
            this.btnNhapHang.TabIndex = 23;
            this.btnNhapHang.Text = "Nhập Hàng";
            this.btnNhapHang.UseVisualStyleBackColor = true;
            this.btnNhapHang.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SieuThiMini.Properties.Resources.logoLogin;
            this.pictureBox1.Location = new System.Drawing.Point(63, 7);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(205, 142);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            // 
            // button9
            // 
            this.button9.Image = global::SieuThiMini.Properties.Resources.exit;
            this.button9.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button9.Location = new System.Drawing.Point(66, 705);
            this.button9.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(228, 43);
            this.button9.TabIndex = 20;
            this.button9.Text = "Đăng xuất";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click_1);
            // 
            // btnThongKe
            // 
            this.btnThongKe.Image = global::SieuThiMini.Properties.Resources.analytics;
            this.btnThongKe.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThongKe.Location = new System.Drawing.Point(66, 551);
            this.btnThongKe.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThongKe.Name = "btnThongKe";
            this.btnThongKe.Size = new System.Drawing.Size(228, 50);
            this.btnThongKe.TabIndex = 19;
            this.btnThongKe.Text = "Thống kê";
            this.btnThongKe.UseVisualStyleBackColor = true;
            this.btnThongKe.Click += new System.EventHandler(this.button8_Click_1);
            // 
            // btnTaiKhoan
            // 
            this.btnTaiKhoan.Image = global::SieuThiMini.Properties.Resources.accounting;
            this.btnTaiKhoan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTaiKhoan.Location = new System.Drawing.Point(66, 636);
            this.btnTaiKhoan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTaiKhoan.Name = "btnTaiKhoan";
            this.btnTaiKhoan.Size = new System.Drawing.Size(228, 48);
            this.btnTaiKhoan.TabIndex = 17;
            this.btnTaiKhoan.Text = "Tài khoản";
            this.btnTaiKhoan.UseVisualStyleBackColor = true;
            this.btnTaiKhoan.Click += new System.EventHandler(this.button5_Click);
            // 
            // btnNhanVien
            // 
            this.btnNhanVien.Image = global::SieuThiMini.Properties.Resources.employee;
            this.btnNhanVien.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNhanVien.Location = new System.Drawing.Point(66, 390);
            this.btnNhanVien.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnNhanVien.Name = "btnNhanVien";
            this.btnNhanVien.Size = new System.Drawing.Size(228, 57);
            this.btnNhanVien.TabIndex = 16;
            this.btnNhanVien.Text = "Nhân viên";
            this.btnNhanVien.UseVisualStyleBackColor = true;
            this.btnNhanVien.Click += new System.EventHandler(this.button4_Click_1);
            // 
            // btnSanPham
            // 
            this.btnSanPham.Image = global::SieuThiMini.Properties.Resources.products1;
            this.btnSanPham.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSanPham.Location = new System.Drawing.Point(66, 168);
            this.btnSanPham.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSanPham.Name = "btnSanPham";
            this.btnSanPham.Size = new System.Drawing.Size(228, 54);
            this.btnSanPham.TabIndex = 15;
            this.btnSanPham.Text = "Sản phẩm";
            this.btnSanPham.UseVisualStyleBackColor = true;
            this.btnSanPham.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // btnCTKM
            // 
            this.btnCTKM.Image = global::SieuThiMini.Properties.Resources.promotion;
            this.btnCTKM.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCTKM.Location = new System.Drawing.Point(63, 470);
            this.btnCTKM.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCTKM.Name = "btnCTKM";
            this.btnCTKM.Size = new System.Drawing.Size(231, 52);
            this.btnCTKM.TabIndex = 14;
            this.btnCTKM.Text = "Chương trình khuyến mãi";
            this.btnCTKM.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCTKM.UseVisualStyleBackColor = true;
            this.btnCTKM.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // QuanLy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1736, 801);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelThongTin);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "QuanLy";
            this.Text = "QuanLy";
            this.Load += new System.EventHandler(this.QuanLy_Load);
            this.panelThongTin.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelThongTin;
        private UCCTKM UC_CTKM;
        private UCSP UC_SP;
        private UCNhanVien UC_NV;
        private UCNhapHang UC_NhapHang;
        private GUI.UserCThongKe UC_ThongKe;
        private GUI.UCTaiKhoan UC_TaiKhoan;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnNhapHang;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button btnThongKe;
        private System.Windows.Forms.Button btnTaiKhoan;
        private System.Windows.Forms.Button btnNhanVien;
        private System.Windows.Forms.Button btnSanPham;
        private System.Windows.Forms.Button btnCTKM;
        private System.Windows.Forms.Button btnBanHang;
    }
}