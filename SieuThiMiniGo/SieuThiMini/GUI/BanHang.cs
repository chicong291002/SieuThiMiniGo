using SieuThiMini.BUS;
using SieuThiMini.DAO;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SieuThiMini
{
    public partial class BanHang : Form
    {

        public static short LocMaLoai = 0, dieuChinhListView = 0;
        double sum_inGH = 0, sumOld = 0, sumNew = 0, thanhTien = 0;
        int countLanThemVaoGH = 0;

        public BanHang()
        {
            InitializeComponent();
        }

        private void btnDocDSHD_Click(object sender, EventArgs e)
        {
            tableHoaDon.DataSource = HoaDonBUS.docDSHoaDon();
            tableHoaDon.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void tableHoaDon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow dataGridViewRow = new DataGridViewRow();
                dataGridViewRow = tableHoaDon.Rows[e.RowIndex];
                txtMaHD.Text = dataGridViewRow.Cells[0].Value.ToString();
                txtMaNV_inHD.Text = dataGridViewRow.Cells[1].Value.ToString();
                txtMaKH_inHD.Text = dataGridViewRow.Cells[2].Value.ToString();
                txtNgayLap_inHD.Text = dataGridViewRow.Cells[3].Value.ToString();
                txtTongTien_inHD.Text = dataGridViewRow.Cells[4].Value.ToString();
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btnThem_inHD_Click(object sender, EventArgs e)
        {
            HoaDonDTO hd = new HoaDonDTO();
            hd.Invoice_id = txtMaHD.Text;
            hd.Employee_id = txtMaNV_inHD.Text;
            hd.Customer_id = txtMaKH_inHD.Text;
            hd.DateFounded = DateTime.Parse(txtNgayLap_inHD.Text);
            hd.TotalMoney = float.Parse(txtTongTien_inHD.Text);

            HoaDonBUS.themHD(hd);

            txtMaHD.Text = "";
            txtNgayLap_inHD.Text = "";

            btnDocDSHD_Click(sender, e);

            if (HoaDonDAO.flag == true)
            {
                List<CTHoaDonDTO> dssp = new List<CTHoaDonDTO>();
                CTHoaDonDTO sp;
                for (int i = 0; i < countLanThemVaoGH; i++)
                {
                    sp = new CTHoaDonDTO()
                    {
                        MaHD = hd.Invoice_id,
                        MaSP = tableGioHang.Items[i].SubItems[0].Text,
                        TenSP = tableGioHang.Items[i].SubItems[1].Text,
                        DonGia = float.Parse(tableGioHang.Items[i].SubItems[2].Text),
                        SoLuong = int.Parse(tableGioHang.Items[i].SubItems[3].Text),
                        Thanhtien = float.Parse(tableGioHang.Items[i].SubItems[4].Text)
                    };

                    dssp.Add(sp);
                }
                tableCTHD.DataSource = dssp;
            }
        }

        private void btnNgayLap_inHD_Click(object sender, EventArgs e)
        {

            txtNgayLap_inHD.Text = DateTime.Now.ToString("yyyy/MM/dd hh:mm:ss");
        }

        private void btnSua_inHD_Click(object sender, EventArgs e)
        {
            int i = tableHoaDon.CurrentRow.Index;
            if (i >= 0)
            {
                HoaDonDTO hd = new HoaDonDTO();
                hd.Invoice_id = txtMaHD.Text;
                hd.Employee_id = txtMaNV_inHD.Text;
                hd.Customer_id = txtMaKH_inHD.Text;
                hd.DateFounded = DateTime.Parse(txtNgayLap_inHD.Text);
                hd.TotalMoney = float.Parse(txtTongTien_inHD.Text);

                HoaDonBUS.suaHD(hd);
                btnDocDSHD_Click(sender, e);
            }
            else MessageBox.Show("Hãy chọn chọn dòng trước khi sửa");
        }

        private void btnXoa_inHD_Click(object sender, EventArgs e)
        {
            int i = tableHoaDon.CurrentRow.Index;
            if (i >= 0)
            {
                HoaDonBUS.xoaHD(txtMaHD.Text);
                btnDocDSHD_Click(sender, e);
            }
            else MessageBox.Show("Hãy chọn chọn dòng trước khi xóa");
        }

        private void btnChonNV_inHD_Click(object sender, EventArgs e)
        {
            ChonNhaCungCap chonNhanVien = new ChonNhaCungCap();
            chonNhanVien.ShowDialog();
        }

        private void txtTimKiem_inHD_TextChanged(object sender, EventArgs e)
        {
            tableHoaDon.DataSource = HoaDonBUS.timHD(txtTimKiem_inHD.Text);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            lblLoai.Text = "KEM VÀ NƯỚC GIẢI KHÁT";
            panelBanHang.Visible = true;

            tableChonHang.DataSource = SanPhamBUS.locSPTheoloai("L1");
            LocMaLoai = 1;
            //tableChonHang.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            lblLoai.Text = "BÁNH KẸO";
            panelBanHang.Visible = true;

            tableChonHang.DataSource = SanPhamBUS.locSPTheoloai("L2");
            LocMaLoai = 2;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            lblLoai.Text = "ĐỒ ĂN NHANH";
            panelBanHang.Visible = true;

            tableChonHang.DataSource = SanPhamBUS.locSPTheoloai("L3");
            LocMaLoai = 3;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            lblLoai.Text = "THỰC PHẨM KHÔ";
            panelBanHang.Visible = true;

            tableChonHang.DataSource = SanPhamBUS.locSPTheoloai("L4");
            LocMaLoai = 4;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            lblLoai.Text = "HÓA MỸ PHẨM";
            panelBanHang.Visible = true;

            tableChonHang.DataSource = SanPhamBUS.locSPTheoloai("L5");
            LocMaLoai = 5;
        }

        private void btnThemVaoGio_Click(object sender, EventArgs e)
        {
            int i = tableChonHang.CurrentRow.Index;
            if (i >= 0)
            {
                if (int.Parse(txtSoLuong_inHD.Text) <= 0 || int.Parse(txtSoLuong_inHD.Text) > int.Parse(tableChonHang.Rows[i].Cells[4].Value.ToString()))
                {
                    MessageBox.Show("Số lượng không phù hợp");
                }
                else
                {
                    string maSP = tableChonHang.Rows[i].Cells[0].Value.ToString();
                    string tenSP = tableChonHang.Rows[i].Cells[1].Value.ToString();
                    float donGia = int.Parse(tableChonHang.Rows[i].Cells[2].Value.ToString());
                    int soLuong = int.Parse(txtSoLuong_inHD.Text);
                    thanhTien = soLuong * donGia;

                    ListViewItem listViewItem = new ListViewItem(maSP);
                    listViewItem.SubItems.Add(tenSP);
                    listViewItem.SubItems.Add(donGia.ToString());
                    listViewItem.SubItems.Add(soLuong.ToString());
                    listViewItem.SubItems.Add(thanhTien.ToString());

                    tableGioHang.Items.Add(listViewItem);

                    sum_inGH += (donGia * int.Parse(txtSoLuong_inHD.Text));
                    txtTongTien_inGH.Text = sum_inGH.ToString();
                    txtSoLuong_inGiohang.Text = "0";
                    txtSoLuong_inHD.Text = "0";

                    countLanThemVaoGH++;
                }
            }
            else MessageBox.Show("Hãy chọn sản phẩm trước khi thêm!");
        }

        private void txtSoLuong_Click(object sender, EventArgs e)
        {
            txtSoLuong_inHD.Text = "";
        }

        private void txtTimNhanhSP_inBanHang_Click(object sender, EventArgs e)
        {
            txtTimNhanhSP_inBanHang.Text = "";
        }

        private void txtTimNhanhSP_inBanHang_TextChanged(object sender, EventArgs e)
        {
            tableChonHang.DataSource = SanPhamBUS.timNhanhSPTheoLoai(txtTimNhanhSP_inBanHang.Text, "L" + LocMaLoai);
        }

        private void tableChonHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = tableChonHang.CurrentRow.Index;
            if (i >= 0)
            {
                txtShowTTSP.Text = "";
                DataGridViewRow dataGridViewRow = new DataGridViewRow();
                dataGridViewRow = tableChonHang.Rows[e.RowIndex];
                for (int u = 0; u < tableChonHang.ColumnCount - 2; u++)
                {
                    txtShowTTSP.Text += dataGridViewRow.Cells[u].Value + " ";
                    txtSoLuong_inHD.Text = "0";
                }
            }
        }

        private void tableCTHD_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow dataGridViewRow = new DataGridViewRow();
                dataGridViewRow = tableCTHD.Rows[e.RowIndex];
                txtMaSP_inCTHD.Text = dataGridViewRow.Cells[0].Value.ToString();
                txtTenSP_inCTHD.Text = dataGridViewRow.Cells[1].Value.ToString();
                txtMaHD_inCTHD.Text = dataGridViewRow.Cells[2].Value.ToString();
                txtDonGia_inCTHD.Text = dataGridViewRow.Cells[3].Value.ToString();
                txtThanhTien_intCTHD.Text = dataGridViewRow.Cells[4].Value.ToString();
                txtSoLuong_inCTHD.Text = dataGridViewRow.Cells[5].Value.ToString();
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btnDoc_inCTHD_Click(object sender, EventArgs e)
        {

        }

        private void btnXacNhan_inCTHD_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < tableCTHD.Rows.Count; i++)
            {
                CTHoaDonDTO cthd = new CTHoaDonDTO();
                cthd.MaHD = tableCTHD.Rows[i].Cells[2].Value.ToString();
                cthd.MaSP = tableCTHD.Rows[i].Cells[0].Value.ToString();
                cthd.TenSP = tableCTHD.Rows[i].Cells[1].Value.ToString();
                cthd.SoLuong = int.Parse(tableCTHD.Rows[i].Cells[5].Value.ToString());
                cthd.DonGia = float.Parse(tableCTHD.Rows[i].Cells[3].Value.ToString());
                cthd.Thanhtien = float.Parse(tableCTHD.Rows[i].Cells[4].Value.ToString());

                CTHoaDonBUS.themCTHD(cthd);
            }
            MessageBox.Show("Hoàn tất!");
            CTHoaDonBUS.docCTHD();

            txtMaHD_inCTHD.Text = "";
            txtMaSP_inCTHD.Text = "";
            txtTenSP_inCTHD.Text = "";
            txtDonGia_inCTHD.Text = "";
            txtSoLuong_inCTHD.Text = "";
            txtThanhTien_intCTHD.Text = "";

            string maSP;
            for (int i = 0; i < tableCTHD.Rows.Count; i++)
            {
                maSP = tableCTHD.Rows[i].Cells[0].Value.ToString();

            }
            MessageBox.Show(tableCTHD.Rows[0].Cells[4].Value.ToString());

        }

        private void button15_Click(object sender, EventArgs e)
        {

        }

        private void tableHoaDon_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnThanhToan_inGH_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(1);
            btnDocDSHD_Click(sender, e);
            txtTongTien_inHD.Text = txtTongTien_inGH.Text;
            List<CTHoaDonDTO> dssp = new List<CTHoaDonDTO>();
            CTHoaDonDTO sp;
            for (int i = 0; i < countLanThemVaoGH; i++)
            {
                sp = new CTHoaDonDTO()
                {
                    MaHD = "",
                    MaSP = tableGioHang.Items[i].SubItems[0].Text,
                    TenSP = tableGioHang.Items[i].SubItems[1].Text,
                    DonGia = float.Parse(tableGioHang.Items[i].SubItems[2].Text),
                    SoLuong = int.Parse(tableGioHang.Items[i].SubItems[3].Text),
                    Thanhtien = float.Parse(tableGioHang.Items[i].SubItems[4].Text)
                };

                dssp.Add(sp);
            }
            tableCTHD.DataSource = dssp;
        }

        private void tableGioHang_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tableGioHang.SelectedItems.Count > 0)
            {
                ListViewItem listView = tableGioHang.SelectedItems[0];
                txtSoLuong_inGiohang.Text = listView.SubItems[3].Text;

                sumOld = int.Parse(listView.SubItems[2].Text) * int.Parse(listView.SubItems[3].Text);
            }
            else return;
        }

        private void btnSua_inGH_Click(object sender, EventArgs e)
        {
            if (tableGioHang.SelectedItems.Count > 0)
            {
                ListViewItem listView = tableGioHang.SelectedItems[0];
                listView.SubItems[3].Text = txtSoLuong_inGiohang.Text.Trim();

                sumNew = int.Parse(txtSoLuong_inGiohang.Text.Trim()) * int.Parse(listView.SubItems[2].Text);

                sum_inGH = sum_inGH - sumOld + sumNew;
                txtTongTien_inGH.Text = sum_inGH.ToString();
            }
            else MessageBox.Show("Hãy chọn sản phẩm cần sửa số lượng!");
            txtSoLuong_inGiohang.Text = "0";
        }

        private void btnXoa_inGH_Click(object sender, EventArgs e)
        {
            if (tableGioHang.SelectedItems.Count > 0)
            {
                tableGioHang.Items.RemoveAt(tableGioHang.SelectedItems[0].Index);

                sum_inGH = sum_inGH - sumOld;
                txtTongTien_inGH.Text = sum_inGH.ToString();
            }
            else MessageBox.Show("Hãy chọn sản phẩm cần xoá!");
            txtSoLuong_inGiohang.Text = "0";
            countLanThemVaoGH -= 1;
        }
    }
}
