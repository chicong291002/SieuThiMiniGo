using DryIoc.ImTools;
using SieuThiMini.BUS;
using SieuThiMini.DTO;
using SieuThiMini.GUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
            dgvCTKM.DataSource = KhuyenMaiBUS.docDSKM();
            dgv_CTCTKM.DataSource = CTCTKhuyenMaiBUS.getAllCT_ChuongTrinhKhuyenMai();
            dgv_CTCTKM.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCTKM.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        internal static void BringToFont()
        {
            throw new NotImplementedException();
        }
        private void dgvCTKM_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow data = new DataGridViewRow();
                data = dgvCTKM.Rows[e.RowIndex];
                string maPhieu = data.Cells[0].Value.ToString().Trim();
                dgv_CTCTKM.DataSource = CTCTKhuyenMaiBUS.getKM(maPhieu);

                txtMaCT.Text = data.Cells[0].Value.ToString();
                txtTenCT.Text = data.Cells[1].Value.ToString();
                txtMaKH.Text = data.Cells[2].Value.ToString();
                dtNgayBatDau.Text = data.Cells[3].Value.ToString();
                dtNgayKetThuc.Text = data.Cells[4].Value.ToString();
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void dgv_CTCTKM_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow data = new DataGridViewRow();
                data = dgv_CTCTKM.Rows[e.RowIndex];
                txtMaCT_CT.Text = data.Cells[0].Value.ToString();
                txtPhanTram.Text = data.Cells[1].Value.ToString();
            }
            catch (Exception)
            {
                throw;
            }
        }

        [Obsolete]
        private void btnThem_CT_Click(object sender, EventArgs e)
        {
            string ma = txtMaCT_CT.Text.Trim();
            string phantram = txtPhanTram.Text.Trim();

            if (ma.Equals("") || phantram.Equals(""))
            {
                MessageBox.Show("Chưa có điền đầy đủ thông tin để thêm ");
            }
            else
            {

                CTCTKhuyenMaiDTO ct = new CTCTKhuyenMaiDTO(ma, phantram);
                string checkNumber = "^[0-9 -]+$";

                bool check = false;

                Regex regexNumber = new Regex(checkNumber);
                var resNumber = regexNumber.IsMatch(phantram + "");
                if (resNumber == false)
                {
                    MessageBox.Show("Phần trăm nhập dữ liệu chưa đúng vui lòng kiểm tra lại");
                }
                else
                {
                    if (int.Parse(phantram) > 100 && int.Parse(phantram) <= 0)
                    {
                        MessageBox.Show("Nhập phần trăm bị sai phantram>0 và phantram <=100 ");
                    }
                    else
                    {
                        int i = dgv_CTCTKM.CurrentCell.RowIndex;
                        if (i >= 0)
                        {
                            for (i = 0; i < dgvCTKM.Rows.Count; i++)
                            {
                                string kq = dgvCTKM.Rows[i].Cells[0].Value.ToString().Trim();
                                MessageBox.Show(kq + "===" + ma);
                                if (ma.Equals(kq))
                                {
                                    check = true;
                                    txtMaCT_CT.Text = "";
                                    txtPhanTram.Text = "";
                                    break;
                                }
                                if (i == dgvCTKM.Rows.Count)
                                {
                                    break;
                                }
                            }
                        }

                        if (check == true)
                        {
                            MessageBox.Show("Thêm CT Thành Công");
                            CTCTKhuyenMaiDTO khuyenMaiDTO = new CTCTKhuyenMaiDTO(ma, phantram);

                            CTCTKhuyenMaiBUS.insertCT_ChuongTrinhKhuyenMai(ct);
                            dgv_CTCTKM.DataSource = CTCTKhuyenMaiBUS.getAllCT_ChuongTrinhKhuyenMai();
                        }
                    }
                }
            }
        }

        private void btnXoa_CT_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Xoá CT Thành Công");
            string ma = txtMaCT_CT.Text.Trim();
            CTCTKhuyenMaiBUS.deleteCT_ChuongTrinhKhuyenMai(ma);
            dgv_CTCTKM.DataSource = CTCTKhuyenMaiBUS.getAllCT_ChuongTrinhKhuyenMai();
        }

        [Obsolete]
        private void btnSua_CT_Click(object sender, EventArgs e)
        {
            string ma = txtMaCT_CT.Text.Trim();
            string phantram = txtPhanTram.Text.Trim();
            CTCTKhuyenMaiDTO ct = new CTCTKhuyenMaiDTO(ma, phantram);
            string checkNumber = "^[0-9 -]+$";
            Regex regexNumber = new Regex(checkNumber);
            var resNumber = regexNumber.IsMatch(phantram);
            if (resNumber == false)
            {
                MessageBox.Show("Phần trăm nhập dữ liệu chưa đúng vui lòng kiểm tra lại");
            }
            else
            {
                if (int.Parse(phantram) > 100 && int.Parse(phantram) <= 0)
                {
                    MessageBox.Show("Nhập phần trăm bị sai phantram>0 và phantram <=100 ");
                }
                else
                {
                    MessageBox.Show("Sửa CT Thành Công");
                    CTCTKhuyenMaiBUS.updateCT_ChuongTrinhKhuyenMai(ct);
                    dgv_CTCTKM.DataSource = CTCTKhuyenMaiBUS.getAllCT_ChuongTrinhKhuyenMai();
                }
            }
        }

        private void dgv_CTCTKM_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgv_CTCTKM_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow data = new DataGridViewRow();
                data = dgv_CTCTKM.Rows[e.RowIndex];
                txtMaCT_CT.Text = data.Cells[0].Value.ToString().Trim();
                txtPhanTram.Text = data.Cells[1].Value.ToString().Trim();
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string maCT = txtMaCT.Text.Trim();
            string tenCT = txtTenCT.Text.Trim();
            string maKH = txtMaKH.Text.Trim();
            DateTime ngayBatDau = dtNgayBatDau.Value;
            DateTime ngayKetThuc = dtNgayKetThuc.Value;

            if (maCT.Equals("") || tenCT.Equals("") || maKH.Equals("") || ngayBatDau.Equals("") || ngayKetThuc.Equals(""))
            {
                MessageBox.Show("Chưa có chọn đầy đủ thông tin");
            }
            else
            {

                MessageBox.Show("Thêm Khuyến Mãi Thành Công");
                bool check = false;

                int i;
                if (check == false)
                {
                    if (ngayKetThuc < ngayBatDau)
                    {
                        MessageBox.Show("Ngày kết thúc chưa có đúng nha !! Phải lớn hơn ngày Bắt Đầu á");
                    }
                    else
                    {

                        int index = dgvCTKM.CurrentCell.RowIndex;
                        if (index > 0)
                        {
                            for (i = 0; i < dgvCTKM.Rows.Count; i++)
                            {
                                string kq = dgvCTKM.Rows[i].Cells[0].Value.ToString().Trim();
                                if (maCT.Equals(kq))
                                {
                                    check = true;
                                    MessageBox.Show("mã bị trùng");
                                    txtMaCT.Text = "";
                                    txtTenCT.Text = "";
                                    txtMaKH.Text = "";
                                    break;
                                }
                            }
                        }

                        if (check == false)
                        {
                            MessageBox.Show("Thêm Nhân Viên Thành Công");
                            KhuyenMaiDTO khuyenMaiDTO = new KhuyenMaiDTO(maCT, tenCT, maKH, ngayBatDau, ngayKetThuc);
                            KhuyenMaiBUS.insert(khuyenMaiDTO);
                            dgvCTKM.DataSource = KhuyenMaiBUS.docDSKM();
                        }
                    }
                }
            }
        }


        private void btnSua_Click(object sender, EventArgs e)
        {
            string maCT = txtMaCT.Text.Trim();
            string tenCT = txtTenCT.Text;
            string maKH = txtMaKH.Text.Trim();
            DateTime ngayBatDau = dtNgayBatDau.Value;
            DateTime ngayKetThuc = dtNgayKetThuc.Value;
            if (ngayKetThuc < ngayBatDau)
            {
                MessageBox.Show("Ngày kết thúc chưa có đúng nha !! Phải lớn hơn ngày Bắt Đầu á");
            }
            else
            {

                int index = dgvCTKM.CurrentCell.RowIndex;
                if (index < 0)
                {
                    MessageBox.Show("Chưa chọn sao sửa anh trai!");
                }
                else
                {
                    MessageBox.Show("Sửa Khuyến Mãi Thành Công");
                    KhuyenMaiDTO khuyenMaiDTO = new KhuyenMaiDTO(maCT, tenCT, maKH, ngayBatDau, ngayKetThuc);
                    KhuyenMaiBUS.update(khuyenMaiDTO);
                    dgvCTKM.DataSource = KhuyenMaiBUS.docDSKM();
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {

            string maCT = txtMaCT.Text.Trim();

            MessageBox.Show("Xoá Thành Công");
            bool check = false;

            foreach (CTCTKhuyenMaiDTO ct in CTCTKhuyenMaiBUS.getAllCT_ChuongTrinhKhuyenMai())
            {
                MessageBox.Show(ct.MaCT.Trim() + "---" + maCT);
                if (ct.MaCT.Trim().Equals(maCT))
                {
                    check = true;
                    CTCTKhuyenMaiBUS.deleteCT_ChuongTrinhKhuyenMai(maCT);
                    KhuyenMaiBUS.delete(maCT);
                }
            }
            if (check == true)
            {
                dgvCTKM.DataSource = KhuyenMaiBUS.docDSKM();
                dgv_CTCTKM.DataSource = CTCTKhuyenMaiBUS.getAllCT_ChuongTrinhKhuyenMai();
            }
            else
            {
                KhuyenMaiBUS.delete(maCT);
                dgvCTKM.DataSource = KhuyenMaiBUS.docDSKM();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.GetCurrentProcess().Kill();
            Application.Exit();
        }

        private void btnKH_Click(object sender, EventArgs e)
        {
            ChonKhachHang chonKhachHang = new ChonKhachHang();
            chonKhachHang.ShowDialog();
            txtMaKH.Text = ChonKhachHang.maKH.Trim();
        }
    }
}
