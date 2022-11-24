using SieuThiMini.BUS;
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
    public partial class SuaNhaCungCap : Form
    {
        static NhaCungCap thongtinNCC = new NhaCungCap();
        public SuaNhaCungCap()
        {
            InitializeComponent();
            txtMaNCC.Text = ChonNhaCungCap.maNCC.Trim();
            txTenNCC.Text = ChonNhaCungCap.tenNCC;
            txtSDT.Text = ChonNhaCungCap.sdt;
            txtDiaChi.Text = ChonNhaCungCap.diaChi;
            txtEmail.Text = ChonNhaCungCap.email;
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            try
            {
                string maNCC = txtMaNCC.Text.Trim();
                string tenNCC = txTenNCC.Text;
                string SDT = txtSDT.Text;
                string diaChi = txtDiaChi.Text;
                string email = txtEmail.Text;
                NhaCungCap ncc = new NhaCungCap(maNCC, tenNCC, SDT, diaChi, email);
                NhaCungCapBUS.updateNhaCungCap(ncc);
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
