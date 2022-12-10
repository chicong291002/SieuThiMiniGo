using SieuThiMini.BUS;
using SieuThiMini.DAO;
using SieuThiMini.DTO;
using SieuThiMini.GUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
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
        float sum_inGH = 0, sumOld = 0, sumNew = 0, thanhTien = 0;
        int countLanThemVaoGH = 0;
        public static string maKH_inHD;

        public static float tongTienKM;

        [Obsolete]
        public BanHang()
        {
            InitializeComponent();
            btnXoa_inKH.Visible = false;
            tableKhachHang.DataSource = KhachHangBUS.docDSKH();
            tableHoaDon.DataSource = HoaDonBUS.docDSHoaDon();
            tableCTHD.DataSource = CTHoaDonBUS.docCTHD();
            tableCTHD.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            tableHoaDon.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        [Obsolete]
        public BanHang(bool a, string maNV) : this()
        {
            btnXoa_inKH.Visible = a;
            btnSua_inKH.Visible = a;
            btnQuayLai.Visible = a;
            txtMaNV_inHD.Text = maNV;
        }

        public void apDungKM(float sum)
        {
            txtTongTien_inHD.Text = sum.ToString();
        }

        [Obsolete]
        public BanHang(string nhanMaNV) : this()
        {
            txtMaNV_inHD.Text = nhanMaNV;
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

                tableCTHD.DataSource = CTHoaDonBUS.locTheoHD(dataGridViewRow.Cells[0].Value.ToString());

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
            hd.DateFounded = (txtNgayLap_inHD.Text);
            hd.TotalMoney = float.Parse(txtTongTien_inHD.Text);

            HoaDonBUS.themHD(hd);

            txtMaHD.Text = "";
            //txtNgayLap_inHD.Text = "";

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

                ChonKhuyenMai.daApDung = false;
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
                hd.DateFounded = txtNgayLap_inHD.Text;
                hd.TotalMoney = float.Parse(txtTongTien_inHD.Text);

                HoaDonBUS.suaHD(hd);
                btnDocDSHD_Click(sender, e);

                txtMaHD.Text = "";
                txtNgayLap_inHD.Text = "";
                txtMaKH_inHD.Text = "KH0";
                txtTongTien_inHD.Text = "";
            }
            else MessageBox.Show("Hãy chọn chọn dòng trước khi sửa");
        }

        private void btnXoa_inHD_Click(object sender, EventArgs e)
        {
            int i = tableHoaDon.CurrentRow.Index;
            if (i >= 0)
            {
                CTHoaDonBUS.xoaCTHD(txtMaHD.Text);
                HoaDonBUS.xoaHD(txtMaHD.Text);
                btnDocDSHD_Click(sender, e);
                btnDoc_inCTHD_Click(null, null);

                txtMaHD.Text = "";
                txtMaNV_inHD.Text = "";
                txtMaKH_inHD.Text = "KH0";
                txtNgayLap_inHD.Text = "";
                txtTongTien_inHD.Text = "";
            }
            else MessageBox.Show("Hãy chọn chọn dòng trước khi xóa");
        }

        private void btnChonNV_inHD_Click(object sender, EventArgs e)
        {
            ChonNhanVien chonNhanVien = new ChonNhanVien();
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
            txtSoLuong_inHD.Text = "1";
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

                    if (countLanThemVaoGH == 0)
                    {
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
                    else
                    {
                        bool trungMaSP = false;
                        for (int j = 0; j < countLanThemVaoGH; j++)
                        {
                            if (maSP == tableGioHang.Items[j].SubItems[0].Text)
                            {
                                trungMaSP = true;
                            }
                        }

                        if (trungMaSP == false)
                        {
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
                        else MessageBox.Show("Sản phẩm này đã có trong giỏ hàng. Hãy sửa số lượng hoặc xóa sản phẩm!");
                        trungMaSP = false;
                    }
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

                if (dataGridViewRow.Cells[7].Value.ToString() != "")
                {
                    MemoryStream memoryStream = new MemoryStream((byte[])dataGridViewRow.Cells[7].Value);
                    pictureBox1.Image = Image.FromStream(memoryStream);
                }
                else
                {
                    pictureBox1.Image = null;
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
            tableCTHD.DataSource = CTHoaDonBUS.docCTHD();
        }

        public void ThongTin()
        {
            int index = tableGioHang.Items.Count;
            if (index <= 0)
            {
                MessageBox.Show("chưa chọn hàng nào kìa");
            }
            else
            {
                ListViewItem lvi;

                List<ListViewItem> dssp = new List<ListViewItem>();

                int temp = tableCTHD.Rows.Count;
                string manv = txtMaNV_inHD.Text.Trim();
                string makh = txtMaKH_inHD.Text.Trim();
                string ngayLap = txtNgayLap_inHD.Text.Trim();
                MessageBox.Show(ngayLap);



                    for (int i = 0; i < temp; i++)
                    {
                        string maHD = tableCTHD.Rows[i].Cells[2].Value.ToString();
                        string maSP = tableCTHD.Rows[i].Cells[0].Value.ToString();
                        string tenSP = tableCTHD.Rows[i].Cells[1].Value.ToString();
                        int soLuong = int.Parse(tableCTHD.Rows[i].Cells[5].Value.ToString());
                        float donGia = float.Parse(tableCTHD.Rows[i].Cells[3].Value.ToString());
                        float thanhTien = float.Parse(tableCTHD.Rows[i].Cells[4].Value.ToString());
                        MessageBox.Show(maHD + "=====" + maSP);

                        lvi = new ListViewItem(maHD);
                        lvi.SubItems.Add(maSP);
                        lvi.SubItems.Add(tenSP);
                        lvi.SubItems.Add(soLuong.ToString());
                        lvi.SubItems.Add(donGia.ToString());
                        lvi.SubItems.Add(thanhTien.ToString());
                        dssp.Add(lvi);
                    }
            
                FormDLG_HoaDon ctHD = new FormDLG_HoaDon();
                ctHD.xuLyHienThiNhap(dssp,manv,makh,ngayLap);
                ctHD.ShowDialog();
            }
        }

        private void btnXacNhan_inCTHD_Click(object sender, EventArgs e)
        {

            try
            {
                ThongTin();
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
                CTHoaDonBUS.docCTHD();

                txtMaHD_inCTHD.Text = "";
                txtMaSP_inCTHD.Text = "";
                txtTenSP_inCTHD.Text = "";
                txtDonGia_inCTHD.Text = "";
                txtSoLuong_inCTHD.Text = "";
                txtThanhTien_intCTHD.Text = "";

                //Giam so luong SP khi xac nhan thanh toan
                string maSP;
                int soLuongSPHienTai, soLuongCon;

                for (int i = 0; i < tableCTHD.Rows.Count; i++)
                {
                    maSP = tableCTHD.Rows[i].Cells[0].Value.ToString();
                    maSP = maSP.Trim();
                    soLuongSPHienTai 
                        
                        
                        = CTHoaDonBUS.laySLSP_old(maSP);

                    soLuongCon = (soLuongSPHienTai - int.Parse(tableCTHD.Rows[i].Cells[5].Value.ToString()));
                    CTHoaDonBUS.suaSLSP(maSP, soLuongCon);
                }

                //Reset lai phan ban hang
                panelBanHang.Visible = false;
                tableGioHang.Items.Clear();
                countLanThemVaoGH = 0;
                LocMaLoai = 0;
                btnDoc_inCTHD_Click(null, null);
                txtTongTien_inHD.Text = "0";
                txtMaKH_inHD.Text = "KH0";
                txtTongTien_inGH.Text = "0";
                thanhTien = 0;
                sumNew = 0;
                sumOld = 0;
                sum_inGH = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtTimKiem_inCTHD_TextChanged(object sender, EventArgs e)
        {
            tableCTHD.DataSource = CTHoaDonBUS.timCTHD(txtTimKiem_inCTHD.Text);
        }

        private void tableKhachHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow dataGridViewRow = new DataGridViewRow();
            dataGridViewRow = tableKhachHang.Rows[e.RowIndex];
            txtMaKH.Text = dataGridViewRow.Cells[0].Value.ToString();
            txtHoKH.Text = dataGridViewRow.Cells[1].Value.ToString();
            txtTenKH.Text = dataGridViewRow.Cells[2].Value.ToString();
            txtSDT_inKH.Text = dataGridViewRow.Cells[3].Value.ToString();
            txtCCCD_inKH.Text = dataGridViewRow.Cells[4].Value.ToString();
            dateTimeNgaySinh_inKH.Value = DateTime.Parse(dataGridViewRow.Cells[5].Value.ToString());
            cbGioiTinh_inKH.Text = dataGridViewRow.Cells[6].Value.ToString();
        }

        private void btnInHD_Click(object sender, EventArgs e)
        {
            reportHD reportHD = new reportHD();
            reportHD.ShowDialog();
        }

        private void BanHang_Load(object sender, EventArgs e)
        {
            dateTimeNgaySinh_inKH.Format = DateTimePickerFormat.Custom;
            dateTimeNgaySinh_inKH.CustomFormat = "yyyy/MM/dd";
            btnDocDSHD_Click(sender, e);
        }

        private void btnDoc_inKH_Click(object sender, EventArgs e)
        {
            tableKhachHang.DataSource = KhachHangBUS.docDSKH();
        }

        private void txtTimKiem_inKH_TextChanged(object sender, EventArgs e)
        {
            tableKhachHang.DataSource = KhachHangBUS.timHD(txtTimKiem_inKH.Text);
        }

        private void btnThem_inKH_Click(object sender, EventArgs e)
        {
            KhachHangDTO kh = new KhachHangDTO();
            kh.MaKH1 = txtMaKH.Text;
            kh.HoKH1 = txtHoKH.Text;
            kh.TenKH1 = txtTenKH.Text;
            kh.SoDT1 = txtSDT_inKH.Text;
            kh.CMND1 = txtCCCD_inKH.Text;
            kh.Ngaysinh1 = dateTimeNgaySinh_inKH.Text;
            kh.GioiTinh1 = cbGioiTinh_inKH.Text.Trim();

            KhachHangBUS.themKH(kh);
            btnDoc_inKH_Click(null, null);

            txtMaKH.Text = "";
            txtHoKH.Text = "";
            txtTenKH.Text = "";
            txtCCCD_inKH.Text = "";
            txtSDT_inKH.Text = "";
            dateTimeNgaySinh_inKH.Text = DateTime.Now.ToString("yyyy/MM/dd");
            cbGioiTinh_inKH.SelectedItem = null;
            MessageBox.Show("Thêm Khách Hàng Thành Công");
        }

        private void btnXoa_inKH_Click(object sender, EventArgs e)
        {
            bool check = false;
            int i = tableKhachHang.CurrentRow.Index;
            string maKH = txtMaKH.Text.Trim();
            if (i >= 0)
            {
                for (i = 0; i < tableHoaDon.Rows.Count - 1; i++)
                {
                    string kq = tableHoaDon.Rows[i].Cells[2].Value.ToString().Trim();
                    if (maKH.Equals(kq))
                    {
                        MessageBox.Show(kq + "===" + maKH);
                        check = true;
                        break;
                    }
                }

                if (check == false)
                {
                    MessageBox.Show("Xoá Khách Hàng Thành Công");
                    KhachHangBUS.xoaKH(maKH);
                    tableKhachHang.DataSource = KhachHangBUS.docDSKH();
                }
                else if (check == true)
                {
                    MessageBox.Show("Khách Hàng tồn tại trong hoá đơn nên không thể xoá");
                }

                btnDoc_inKH_Click(null, null);
                txtMaKH.Text = "";
                txtHoKH.Text = "";
                txtTenKH.Text = "";
                txtCCCD_inKH.Text = "";
                txtSDT_inKH.Text = "";
                dateTimeNgaySinh_inKH.Text = DateTime.Now.ToString("yyyy/MM/dd");
                cbGioiTinh_inKH.SelectedItem = null;
            }
            else MessageBox.Show("Hãy chọn chọn dòng trước khi xóa");
        }

        private void btnSua_inKH_Click(object sender, EventArgs e)
        {
            int i = tableKhachHang.CurrentRow.Index;
            if (i >= 0)
            {
                KhachHangDTO kh = new KhachHangDTO();
                kh.MaKH1 = txtMaKH.Text;
                kh.HoKH1 = txtHoKH.Text;
                kh.TenKH1 = txtTenKH.Text;
                kh.SoDT1 = txtSDT_inKH.Text;
                kh.CMND1 = txtCCCD_inKH.Text;
                kh.Ngaysinh1 = dateTimeNgaySinh_inKH.Text;
                kh.GioiTinh1 = cbGioiTinh_inKH.Text.Trim();

                KhachHangBUS.suaKH(kh);
                btnDoc_inKH_Click(null, null);

                txtMaKH.Text = "";
                txtHoKH.Text = "";
                txtTenKH.Text = "";
                txtCCCD_inKH.Text = "";
                txtSDT_inKH.Text = "";
                dateTimeNgaySinh_inKH.Text = DateTime.Now.ToString("yyyy/MM/dd");
                cbGioiTinh_inKH.SelectedItem = null;
            }
            else MessageBox.Show("Hãy chọn chọn dòng trước khi sửa");
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (ChonKhuyenMai.daApDung == false)
            {
                maKH_inHD = txtMaKH_inHD.Text;
                tongTienKM = float.Parse(txtTongTien_inHD.Text);

                ChonKhuyenMai chonKhuyenMai = new ChonKhuyenMai();
                chonKhuyenMai.UIParent = this;
                chonKhuyenMai.ShowDialog();
            }
            else
            {
                MessageBox.Show("Hóa đơn đã được áp dụng khuyến mãi!");
            }
        }

        private void btnTaoMaKH_Click(object sender, EventArgs e)
        {

        }

        [Obsolete]
        private void button7_Click(object sender, EventArgs e)
        {
            /*
            System.Diagnostics.Process.GetCurrentProcess().Kill();
            Application.Exit();*/
            this.Visible = false;
            QuanLy quanLy = new QuanLy();
            quanLy.ShowDialog();

        }

        [Obsolete]
        private void button8_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            DangNhap fm = new DangNhap();
            fm.ShowDialog();
        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button15_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.GetCurrentProcess().Kill();
            Application.Exit();
        }

        private void btnMaKH_Click(object sender, EventArgs e)
        {
            txtMaKH.Text = "KH" + tableKhachHang.Rows.Count;
        }

        private void btnThanhToan_inGH_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(1);
            btnDocDSHD_Click(sender, e);

            txtTongTien_inHD.Text = txtTongTien_inGH.Text;

            //MessageBox.Show(tableGioHang.Items[0].SubItems[2].Text);
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

            txtMaHD.Text = "HD" + tableHoaDon.Rows.Count;
            btnNgayLap_inHD_Click(null, null);






            //Tao ma hoa don tu dong
            /*
            string ktn, s;
            DataTable dt1 = HoaDonBUS.docDSHoaDon();

            if (dt1.Rows.Count <= 0) // Kiểm tra xem trong csdl co dữ liệu chưa
            // nếu chưa có
            {
                int n = dt1.Rows.Count + 1;
                string s3 = n.ToString();
                txtMaHD.Text = "HD" + s3;
            }
            else
            {
                // có rồi
                for (int i = 0; i <= dt1.Rows.Count; i++)
                {
                    s = (i + 1).ToString();

                    if (i == dt1.Rows.Count)
                    {
                        ktn = "HD" + (i + 1).ToString();

                        txtMaHD.Text = ktn;
                    }
                    else
                    {
                        ktn = "HD" + s;
                        try
                        {
                            if (ktn != (dt1.Rows[i][0].ToString()))
                            {
                                txtMaHD.Text = ktn;
                                break;
                            }
                        } // có dữ liệu là MTD001, MTD002, MTD003, MTDu008. thì nó sẽ tăng là MTDu004 tiếp cho đến
                          //MTDu007 rồi nó tăng lên MTDu009 cứ thế.
                        catch { }

                    }

                }
            }*/
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

                string kq = txtSoLuong_inGiohang.Text.Trim();

                if (int.Parse(kq) <= 0)
                {
                    MessageBox.Show("Số Lượng sửa phải > 0");
                }
                else
                {
                    listView.SubItems[3].Text = txtSoLuong_inGiohang.Text.Trim();
                    sumNew = int.Parse(txtSoLuong_inGiohang.Text.Trim()) * int.Parse(listView.SubItems[2].Text);
                    listView.SubItems[4].Text = sumNew.ToString();
                    sum_inGH = sum_inGH - sumOld + sumNew;
                    txtTongTien_inGH.Text = sum_inGH.ToString();
                }
            }
            else
                MessageBox.Show("Hãy chọn sản phẩm cần sửa số lượng!");
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
