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

namespace SieuThiMini
{
    public partial class UCCTKM : UserControl
    {
        [Obsolete]
        public UCCTKM()
        {
            InitializeComponent();
            dgvCTKM.DataSource = ChuongTrinhKhuyenMaiBUS.getAllChuongTrinhKhuyenMai();
            dgv_CTCTKM.DataSource = CT_ChuongTrinhKhuyenMaiBUS.getAllCT_ChuongTrinhKhuyenMai();
        }

        internal static void BringToFont()
        {
            throw new NotImplementedException();
        }

        [Obsolete]
        private void btnThem_Click(object sender, EventArgs e)
        {
            string maChuongTrinh = txtMaCT.Text;
            string tenChuongTrinh = txtTenCT.Text;
            string maKH = txtMaKH.Text;
            DateTime ngayBatDau = dtNgayBatDau.Value;
            DateTime ngayKetThuc = dtNgayKetThuc.Value;
            ChuongTrinhKhuyenMai chuongTrinhKhuyenMai = new ChuongTrinhKhuyenMai(maChuongTrinh, tenChuongTrinh, maKH, ngayBatDau, ngayKetThuc);
            ChuongTrinhKhuyenMaiBUS.insertChuongTrinhKhuyenMai(chuongTrinhKhuyenMai);
            dgvCTKM.DataSource = ChuongTrinhKhuyenMaiBUS.getAllChuongTrinhKhuyenMai();
        }

        [Obsolete]
        private void btnSua_Click(object sender, EventArgs e)
        {
            string maChuongTrinh = txtMaCT.Text;
            string tenChuongTrinh = txtTenCT.Text;
            string maKH = txtMaKH.Text;
            DateTime ngayBatDau = dtNgayBatDau.Value;
            DateTime ngayKetThuc = dtNgayKetThuc.Value;
            ChuongTrinhKhuyenMai chuongTrinhKhuyenMai = new ChuongTrinhKhuyenMai(maChuongTrinh, tenChuongTrinh, maKH, ngayBatDau, ngayKetThuc);
            ChuongTrinhKhuyenMaiBUS.updateChuongTrinhKhuyenMai(chuongTrinhKhuyenMai);
            dgvCTKM.DataSource = ChuongTrinhKhuyenMaiBUS.getAllChuongTrinhKhuyenMai();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string maChuongTrinh = txtMaCT.Text;
            ChuongTrinhKhuyenMaiBUS.deleteChuongTrinhKhuyenMai(maChuongTrinh);
            dgvCTKM.DataSource = ChuongTrinhKhuyenMaiBUS.getAllChuongTrinhKhuyenMai();
        }

        [Obsolete]
        private void btnThem_CT_Click(object sender, EventArgs e)
        {
            string maChuongTrinh = txtMaCT_CT.Text;
            float phanTram = float.Parse(txtTenCT.Text);

            CTChuongTrinhKhuyenMai ct = new CTChuongTrinhKhuyenMai(maChuongTrinh, phanTram);
            CT_ChuongTrinhKhuyenMaiBUS.insertCT_ChuongTrinhKhuyenMai(ct);
            dgv_CTCTKM.DataSource = CT_ChuongTrinhKhuyenMaiBUS.getAllCT_ChuongTrinhKhuyenMai();
        }

        [Obsolete]
        private void btnXoa_CT_Click(object sender, EventArgs e)
        {
            string maChuongTrinh = txtMaCT_CT.Text;
            float phanTram = float.Parse(txtTenCT.Text);

            CTChuongTrinhKhuyenMai ct = new CTChuongTrinhKhuyenMai(maChuongTrinh, phanTram);
            CT_ChuongTrinhKhuyenMaiBUS.updateCT_ChuongTrinhKhuyenMai(ct);
            dgv_CTCTKM.DataSource = CT_ChuongTrinhKhuyenMaiBUS.getAllCT_ChuongTrinhKhuyenMai();
        }

        private void btnSua_CT_Click(object sender, EventArgs e)
        {
            string maChuongTrinh = txtMaCT_CT.Text;
          
            CT_ChuongTrinhKhuyenMaiBUS.deleteCT_ChuongTrinhKhuyenMai(maChuongTrinh);
            dgv_CTCTKM.DataSource = CT_ChuongTrinhKhuyenMaiBUS.getAllCT_ChuongTrinhKhuyenMai();
        }

        private void txtMaCT_TextChanged(object sender, EventArgs e)
        {

        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void txtMaKH_TextChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void dgvCTKM_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTenCT_TextChanged(object sender, EventArgs e)
        {

        }

        private void dtNgayKetThuc_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dtNgayBatDau_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void txt_TimKiem_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPhanTram_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtMaCT_CT_TextChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void dgv_CTCTKM_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }
    }
}
