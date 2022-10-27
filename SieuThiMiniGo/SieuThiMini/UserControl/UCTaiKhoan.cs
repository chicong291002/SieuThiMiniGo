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
    public partial class UCTaiKhoan : UserControl
    {
        [Obsolete]
        public UCTaiKhoan()
        {
            InitializeComponent();
            dgvTaiKhoan.DataSource = TaiKhoanBUS.getAllTaiKhoan();
        }

        [Obsolete]
        private void btnThem_Click(object sender, EventArgs e)
        {
            string maTK = txtMaTK.Text;
            string tenTK = txtTenTK.Text;
            string matKhau = txtMatKhau.Text;
            string email = txtEmail.Text;
            string maNV = txtMaNV.Text;
            string phanQuyen = cbPhanQuyen.Text;
            string trangThai = cbTrangThai.Text;
            TaiKhoan tk = new TaiKhoan(maTK, tenTK, matKhau, email, maNV, phanQuyen, trangThai);
            TaiKhoanBUS.insertTaiKhoan(tk);
            dgvTaiKhoan.DataSource = TaiKhoanBUS.getAllTaiKhoan();
        }

        [Obsolete]
        private void btnSua_Click(object sender, EventArgs e)
        {
            string maTK = txtMaTK.Text;
            string tenTK = txtTenTK.Text;
            string matKhau = txtMatKhau.Text;
            string email = txtEmail.Text;
            string maNV = txtMaNV.Text;
            string phanQuyen = cbPhanQuyen.Text;
            string trangThai = cbTrangThai.Text;
            TaiKhoan tk = new TaiKhoan(maTK, tenTK, matKhau, email, maNV, phanQuyen, trangThai);
            TaiKhoanBUS.updateTaiKhoan(tk);
            dgvTaiKhoan.DataSource = TaiKhoanBUS.getAllTaiKhoan();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string maTK = txtMaTK.Text;
            TaiKhoanBUS.deleteTaiKhoan(maTK);
            dgvTaiKhoan.DataSource = TaiKhoanBUS.getAllTaiKhoan();
        }

        private void dgvTaiKhoan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow data = new DataGridViewRow();
                data = dgvTaiKhoan.Rows[e.RowIndex];
                txtMaTK.Text = data.Cells[0].Value.ToString();
                txtTenTK.Text = data.Cells[1].Value.ToString();
                txtMaNV.Text = data.Cells[2].Value.ToString();
                txtMaNV.Text = data.Cells[3].Value.ToString();
                cbPhanQuyen.Text = data.Cells[4].Value.ToString();
                cbTrangThai.Text = data.Cells[5].Value.ToString();
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void UCTaiKhoan_Load(object sender, EventArgs e)
        {

        }
    }
}
