using Microsoft.Office.Interop.Excel;
using SieuThiMini.BUS;
using SieuThiMini.DTO;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media.Media3D;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using DataTable = System.Data.DataTable;

namespace SieuThiMini.GUI
{

    public partial class UCNhapHang : UserControl
    {
        ArrayList dskt = new ArrayList();
        float tongTien = 0;
        [Obsolete]
        public UCNhapHang()
        {
            InitializeComponent();


            table_ChonHang.DataSource = SanPhamBUS.getAllSanPham();
            table_PN.DataSource = PhieuNhapBUS.layToanBoDanhSach();
            table_CTPN.DataSource = CTPhieuNhapBUS.layToanBoDanhSach();
            DataGridViewImageColumn pic = new DataGridViewImageColumn();
            pic = (DataGridViewImageColumn)table_ChonHang.Columns[7];
            pic.ImageLayout = DataGridViewImageCellLayout.Zoom;
            table_PN.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            table_CTPN.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void table_ChonHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow data = new DataGridViewRow();
                data = table_ChonHang.Rows[e.RowIndex];
                txtMaSP.Text = data.Cells[0].Value.ToString();
                txtTenSP.Text = data.Cells[1].Value.ToString();

                txtSoLuongNhap.Text = data.Cells[3].Value.ToString();
                txtGiaNhap.Text = data.Cells[4].Value.ToString();
                txtTongTien.Text = data.Cells[5].Value.ToString();
                txtMaNV.Text = data.Cells[6].Value.ToString();
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void txtSoLuongTonKho_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void txtSoLuongNhap_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void txtGiaNhap_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void txtTongTien_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ChonNhaCungCap chonNhaCungCap = new ChonNhaCungCap();
            chonNhaCungCap.ShowDialog();
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {

        }

        [Obsolete]
        private void btnChonNhap_Click_1(object sender, EventArgs e)
        {
            try
            {
                int i = table_ChonHang.CurrentCell.RowIndex;
                if (i >= 0)
                {
                    string maSP = txtMaSP.Text.Trim();
                    string tenSP = txtTenSP.Text.Trim();
                    int soLuongCu = int.Parse(txtSoLuongNhap.Text.Trim());
                    float donGia = float.Parse(txtGiaNhap.Text.Trim());
                    float thanhTien = soLuongCu * donGia;

                    if (maSP.Equals("") || tenSP.Equals("") || soLuongCu.Equals("") || donGia.Equals("") ||
                    thanhTien.Equals(""))
                    {
                        MessageBox.Show("Chưa có chọn đầy đủ thông tin");
                    }
                    else
                    {

                        string checkNumber = "^[0-9 -]+$";
                        Regex regexNumber = new Regex(checkNumber);
                        var resNumber = regexNumber.IsMatch(soLuongCu + "");

                        if (resNumber == false)
                        {
                            MessageBox.Show("Định dạng số không đúng");
                        }
                        else
                        {

                            ListViewItem listViewItem1;
                            int j;
                            bool check = false;
                            if (txtMaNCC.Text.Trim().Equals(""))
                            {
                                MessageBox.Show("Chưa chọn nhà cung cấp kìa ");
                            }
                            else
                            {

                                txtTongTien.Text = (soLuongCu * donGia) + "";
                                if (soLuongCu <= 0)
                                {
                                    MessageBox.Show("Nhập số lượng sai > 0");
                                    txtMaSP.Text = "";
                                    txtTenSP.Text = "";
                                    txtGiaNhap.Text = "";
                                    txtSoLuongNhap.Text = "";
                                }
                                else
                                {
                                    for (j = 0; j < tableHangChoNhap.Items.Count; j++)
                                    {

                                        string kq = tableHangChoNhap.Items[j].SubItems[0].Text.ToString().Trim();
                                        int kq1 = int.Parse(tableHangChoNhap.Items[j].SubItems[2].Text.ToString().Trim());
                                        if (kq.Equals(maSP))
                                        {
                                            check = true;
                                            int kqMoi = kq1 + soLuongCu;
                                            float thanhTien1 = kqMoi * donGia;
                                            txtTongTien.Text = thanhTien1 + "";

                                            tableHangChoNhap.Items[j].SubItems[2].Text = kqMoi.ToString().Trim();
                                            tableHangChoNhap.Items[j].SubItems[4].Text = thanhTien1.ToString().Trim();

                                        }

                                    }

                                    if (check == false)
                                    {
                                        listViewItem1 = new ListViewItem(maSP);
                                        listViewItem1.SubItems.Add(tenSP);
                                        listViewItem1.SubItems.Add(soLuongCu.ToString());
                                        listViewItem1.SubItems.Add(donGia.ToString());
                                        listViewItem1.SubItems.Add(thanhTien.ToString().Trim());
                                        tableHangChoNhap.Items.Add(listViewItem1);
                                        MessageBox.Show("Thêm Vào Giỏ Hàng Thành Công");
                                    }
                                }
                            }
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
        }

        private void btnMaNhaCungCap_Click(object sender, EventArgs e)
        {
            ChonNhaCungCap chonNhaCungCap = new ChonNhaCungCap();
            chonNhaCungCap.ShowDialog();
            txtMaNCC.Text = ChonNhaCungCap.maSP + " - " + ChonNhaCungCap.tenSP;
        }

        private void txtMaNCC_TextChanged(object sender, EventArgs e)
        {

        }

        [Obsolete]
        private void btnXacNhan_Click_1(object sender, EventArgs e)
        {
            int index = tableHangChoNhap.Items.Count;
            if (index <= 0)
            {
                MessageBox.Show("chưa chọn hàng nào kìa");
            }
            else
            {
                string[] nhaCungCap = txtMaNCC.Text.Trim().Split('-');
                string[] nhanVien = txtMaNV.Text.Trim().Split('-');
                DateTime ngayLap = DateTime.Now;

                float sum = 0;
                int i;
                for (i = 0; i < tableHangChoNhap.Items.Count; i++)
                {
                    sum += float.Parse(tableHangChoNhap.Items[i].SubItems[4].Text.Trim());
                }
                tongTien = sum;
                PhieuNhapBUS.insert(nhaCungCap, nhanVien, ngayLap, tongTien);


                    List<ListViewItem> dssp = new List<ListViewItem>();
                    for (i = 0; i < index; i++)
                    {
                        string maSP = tableHangChoNhap.Items[i].SubItems[0].Text.Trim();
                        string tenSP = tableHangChoNhap.Items[i].SubItems[1].Text.Trim();
                        int soLuong = int.Parse(tableHangChoNhap.Items[i].SubItems[2].Text.Trim());
                        float donGia = float.Parse(tableHangChoNhap.Items[i].SubItems[3].Text.Trim());
                        float thanhTien = float.Parse(tableHangChoNhap.Items[i].SubItems[4].Text.Trim());
                        ListViewItem lvi = new ListViewItem(maSP);
                        lvi.SubItems.Add(tenSP);
                        lvi.SubItems.Add(soLuong.ToString());
                        lvi.SubItems.Add(donGia.ToString());
                        lvi.SubItems.Add(thanhTien.ToString());
                        MessageBox.Show(maSP + "=" + tenSP + "="+ soLuong + "=" + donGia + "=" + thanhTien);
                        dssp.Add(lvi);
                        CTPhieuNhapBUS.luuCTPhieuNhap(maSP, soLuong, donGia, thanhTien);

                    }

                    FormDLG_PhieuNhap ctpn = new FormDLG_PhieuNhap();
                    ctpn.xuLyHienThiNhap(dssp, nhanVien[0], nhaCungCap[0], ngayLap);
                    table_PN.DataSource = PhieuNhapBUS.layToanBoDanhSach();
                    table_CTPN.DataSource = CTPhieuNhapBUS.layToanBoDanhSach();
                    ctpn.ShowDialog();
                
                

            }
            table_ChonHang.DataSource = SanPhamBUS.getAllSanPham();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (tableHangChoNhap.SelectedItems.Count > 0)
            {
                tableHangChoNhap.Items.Remove(tableHangChoNhap.SelectedItems[0]);
            }
            else
            {
                MessageBox.Show("Không có gì để xoá");
            }
        }

        private void tableHangChoNhap_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tableHangChoNhap.SelectedItems.Count > 0)
            {
                txtMaSP.Text = tableHangChoNhap.SelectedItems[0].SubItems[0].Text;
                txtTenSP.Text = tableHangChoNhap.SelectedItems[0].SubItems[1].Text;
                txtSoLuongNhap.Text = tableHangChoNhap.SelectedItems[0].SubItems[2].Text;
                txt_DonGia.Text = tableHangChoNhap.SelectedItems[0].SubItems[3].Text;
                txtTongTien.Text = tableHangChoNhap.SelectedItems[0].SubItems[4].Text;
            }
            else return;
        }

        private void Refresh_PN_Click(object sender, EventArgs e)
        {
            table_PN.DataSource = PhieuNhapBUS.layToanBoDanhSach();
        }

        private void table_PN_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            DataGridViewRow data = new DataGridViewRow();
            data = table_PN.Rows[e.RowIndex];
            string maPhieu = data.Cells[0].Value.ToString().Trim();
            table_CTPN.DataSource = CTPhieuNhapBUS.getCTPhieuNhap(maPhieu);

            txtPN.Text = data.Cells[0].Value.ToString();
            txtNV.Text = data.Cells[1].Value.ToString();
            txtNCC.Text = data.Cells[2].Value.ToString();
            dtNgayLap.Text = data.Cells[3].Value.ToString();
            txtTongTienn.Text = data.Cells[4].Value.ToString();
        }

        private void Refresh_CTPN_Click(object sender, EventArgs e)
        {
            table_CTPN.DataSource = CTPhieuNhapBUS.layToanBoDanhSach();
        }

        private void table_ChonHang_CellClick_2(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow data = new DataGridViewRow();
                data = table_ChonHang.Rows[e.RowIndex];
                txtMaSP.Text = data.Cells[0].Value.ToString().Trim();
                txtTenSP.Text = data.Cells[1].Value.ToString();

                txtGiaNhap.Text = data.Cells[2].Value.ToString();
                txtSoLuongNhap.Text = data.Cells[4].Value.ToString();
                /*
                float gianhap = float.Parse(txtGiaNhap.Text);
                int soluong = int.Parse(txtSoLuongNhap.Text);
                txtTongTien.Text = (gianhap * soluong).ToString();
                */

            }
            catch (Exception)
            {
                throw;
            }
        }

        private void table_CTPN_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow data = new DataGridViewRow();
                data = table_CTPN.Rows[e.RowIndex];
                txt_CTPN.Text = data.Cells[0].Value.ToString().Trim();
                txtSP.Text = data.Cells[1].Value.ToString();
                txt_SoLuong.Text = data.Cells[2].Value.ToString();
                txt_DonGia.Text = data.Cells[3].Value.ToString();
                txt_CTTongTien.Text = data.Cells[4].Value.ToString();
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void btnNhaCungCap_Click(object sender, EventArgs e)
        {
            ChonNhaCungCap chonNhaCungCap = new ChonNhaCungCap();
            chonNhaCungCap.ShowDialog();
            txtMaNCC.Text = ChonNhaCungCap.maSP;
        }

        private void btnNhaCungCap_Click_1(object sender, EventArgs e)
        {
            ChonNhaCungCap chonNhaCungCap = new ChonNhaCungCap();
            chonNhaCungCap.ShowDialog();
            txtMaNCC.Text = ChonNhaCungCap.maSP;
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void txtMaNV_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            table_ChonHang.DataSource = SanPhamBUS.searchSanPham(textBox7.Text);
        }

        private void btnInAn_Click(object sender, EventArgs e)
        {
            FormReportPhieuNhap formReportPhieuNhap = new FormReportPhieuNhap();
            formReportPhieuNhap.ShowDialog();
            this.Hide();
        }
    }
}
