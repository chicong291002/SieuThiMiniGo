﻿using SieuThiMini.BUS;
using SieuThiMini.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SieuThiMini.GUI
{
    public partial class ThemNhaCungCap : Form
    {
        public ThemNhaCungCap()
        {
            InitializeComponent();
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            try
            {
                string maNCC = txtMaNCC.Text.Trim();
                string tenNCC = txtTenNCC.Text.Trim();
                string SDT = txtSDT.Text;
                string diaChi = txtDiaChi.Text;
                string email = txtEmail.Text;
                NhaCungCap nhaCungCap = new NhaCungCap(maNCC, tenNCC, SDT, diaChi, email);
                NhaCungCapBUS.insertNhaCungCap(nhaCungCap);
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
