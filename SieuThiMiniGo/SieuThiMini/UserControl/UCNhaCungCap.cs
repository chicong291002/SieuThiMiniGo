using SieuThiMini.BUS;
using SieuThiMini.DTO;
using System;
using System.Windows.Forms;

namespace SieuThiMini.GUI
{
    public partial class UCNhaCungCap : UserControl
    {
        public UCNhaCungCap()
        {
            InitializeComponent();
            dgv_NhaCungCap.DataSource = NhaCungCapBUS.getAllNhaCungCap();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string maNCC = txtMaNCC.Text;
            string tenNCC = txtTenNCC.Text;
            string SDT = txtSDT.Text;
            string diaChi = txtDiaChi.Text;
            string email = txtEmail.Text;
            NhaCungCap ncc = new NhaCungCap(maNCC, tenNCC, SDT, diaChi, email);
            NhaCungCapBUS.insertNhaCungCap(ncc);
            dgv_NhaCungCap.DataSource = NhaCungCapBUS.getAllNhaCungCap();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string maNCC = txtMaNCC.Text;
            string tenNCC = txtTenNCC.Text;
            string SDT = txtSDT.Text;
            string diaChi = txtDiaChi.Text;
            string email = txtEmail.Text;
            NhaCungCap ncc = new NhaCungCap(maNCC, tenNCC, SDT, diaChi, email);
            NhaCungCapBUS.updateNhaCungCap(ncc);
            dgv_NhaCungCap.DataSource = NhaCungCapBUS.getAllNhaCungCap();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string maNCC = txtMaNCC.Text;

            NhaCungCapBUS.deleteNhaCungCap(maNCC);
            dgv_NhaCungCap.DataSource = NhaCungCapBUS.getAllNhaCungCap();
        }

        private void dgv_NhaCungCap_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow data = new DataGridViewRow();
                data = dgv_NhaCungCap.Rows[e.RowIndex];
                txtMaNCC.Text = data.Cells[0].Value.ToString();
                txtTenNCC.Text = data.Cells[1].Value.ToString();
                txtSDT.Text = data.Cells[2].Value.ToString();
                txtDiaChi.Text = data.Cells[3].Value.ToString();
                txtEmail.Text = data.Cells[4].Value.ToString();
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
