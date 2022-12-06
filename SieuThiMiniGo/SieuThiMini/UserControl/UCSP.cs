using DryIoc.ImTools;
using Microsoft.Reporting.Map.WebForms.BingMaps;
using OfficeOpenXml.FormulaParsing.ExpressionGraph.FunctionCompilers;
using SieuThiMini.BUS;
using SieuThiMini.DTO;
using SieuThiMini.GUI;
using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace SieuThiMini
{
    public partial class UCSP : UserControl
    {
        [Obsolete]
        public UCSP()
        {
            InitializeComponent();
            dgv_SanPham.DataSource = SanPhamBUS.getAllSanPham();
            dgvLoaiSanPham.DataSource = LoaiSanPhamBUS.getAllSanPham();
            dgvLoaiSanPham.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DataGridViewImageColumn pic = new DataGridViewImageColumn();
            pic = (DataGridViewImageColumn)dgv_SanPham.Columns[7];
            pic.ImageLayout = DataGridViewImageCellLayout.Zoom;
        }

        [Obsolete]
        private void btnThem_Click(object sender, EventArgs e)
        {
            string maSP = txtMaSP.Text.Trim();
            string tenSP = txtTenSP.Text.Trim();
            string donGia = txtDonGia.Text.Trim();
            string donViTinh = txtDonViTinh.Text.Trim();
            string soLuong = txtSoLuong.Text.Trim();
            string maLoai = txtMaLoai.Text.Trim();
            string maNCC = txtMaNCC.Text.Trim();

            byte[] anh = ImageToByteArray(pictureBox1);

            string checkNumber = "^[0-9 -]+$";
            Regex regexNumber = new Regex(checkNumber);
            var resNumber = regexNumber.IsMatch(soLuong);
            string checkDonGia = "^[0-9 -]+$";
            Regex regexDonGia = new Regex(checkDonGia);
            var resDonGia = regexDonGia.IsMatch(donGia);

            bool check = false;
            bool temp = false;
            bool checkTemp = false;
            int i;
            if (maSP.Equals("") || tenSP.Equals("") || donGia.Equals("") || donViTinh.Equals("") ||
                soLuong.Equals("") || maLoai.Equals("") || maNCC.Equals("") || anh.Equals(""))
            {
                MessageBox.Show("Chưa có chọn đầy đủ thông tin");
            }
            else
            {
                if (resNumber == false)
                {
                    MessageBox.Show("Kiểu số lượng không đúng ");
                }
                else
                {
                    if (resDonGia == false)
                    {
                        MessageBox.Show("Đơn giá không chính xác");
                    }
                    else
                    {

                        int index = dgv_SanPham.CurrentCell.RowIndex;
                        if (index >= 0)
                        {
                            for (i = 0; i < dgv_SanPham.Rows.Count - 1; i++)
                            {
                                string kq = dgv_SanPham.Rows[i].Cells[0].Value.ToString().Trim();
                                if (maSP.Equals(kq))
                                {
                                    MessageBox.Show(maSP + "=====" + kq);
                                    check = true;
                                    break;
                                }
                            }

                        }

                        if (check == false)
                        {

                            foreach (loaiSanPham loaiSanPham in LoaiSanPhamBUS.getAllSanPham())
                            {

                                if (loaiSanPham.MaLoai.Trim().Equals(txtMaLoai.Text.Trim()))
                                {
                                    MessageBox.Show(loaiSanPham.MaLoai.Trim() + "===" + txtMaLoai.Text.Trim());
                                    temp = true;
                                    break;
                                }
                            }

                            if (temp == true)
                            {
                                foreach (NhaCungCap ncc in NhaCungCapBUS.getAllNhaCungCap())
                                {

                                    if (ncc.MaNCC.Trim().Equals(txtMaNCC.Text.Trim()))
                                    {
                                        checkTemp = true;
                                        break;
                                    }
                                }
                                if (checkTemp == true)
                                {
                                    MessageBox.Show("Thêm Thành Công");
                                    SanPham sp = new SanPham(maSP, tenSP, donGia, donViTinh, soLuong, maLoai, maNCC, anh);
                                    SanPhamBUS.insertSanPham(sp);
                                    dgv_SanPham.DataSource = SanPhamBUS.getAllSanPham();
                                }
                                else
                                {
                                    MessageBox.Show("Thêm Thất Bại Mã Nhà Cung Cấp phải trùng với mã loại đã có trong danh sách");
                                    txtMaSP.Text = "";
                                    txtTenSP.Text = "";
                                    txtDonGia.Text = "";
                                    txtDonViTinh.Text = "";
                                    txtSoLuong.Text = "";
                                    txtMaLoai.Text = "";
                                    txtMaNCC.Text = "";
                                }
                            }
                            else
                            {
                                MessageBox.Show("Thêm Thất Bại Mã Loại khi thêm phải trùng với mã loại đã có trong danh sách");
                                txtMaSP.Text = "";
                                txtTenSP.Text = "";
                                txtDonGia.Text = "";
                                txtDonViTinh.Text = "";
                                txtSoLuong.Text = "";
                                txtMaLoai.Text = "";
                                txtMaNCC.Text = "";
                            }
                        }
                        else
                        {
                            MessageBox.Show("mã bị trùng");
                        }
                    }
                }
            }
        }

        [Obsolete]
        private void btnSua_Click(object sender, EventArgs e)
        {
            string maSP = txtMaSP.Text.Trim();
            string tenSP = txtTenSP.Text.Trim();
            string donGia = txtDonGia.Text.Trim();
            string donViTinh = txtDonViTinh.Text.Trim();
            string soLuong = txtSoLuong.Text.Trim();
            string maLoai = txtMaLoai.Text.Trim();
            string maNCC = txtMaNCC.Text.Trim();
            byte[] anh = ImageToByteArray(pictureBox1);
            string checkNumber = "^[0-9 -]+$";
            Regex regexNumber = new Regex(checkNumber);
            var resNumber = regexNumber.IsMatch(soLuong);

            string checkDonGia = "^[0-9 -]+$";
            Regex regexDonGia = new Regex(checkDonGia);
            var resDonGia = regexDonGia.IsMatch(donGia);

            if (resNumber == false)
            {
                MessageBox.Show("Kiểu số lượng không đúng rùi");
            }
            else
            {
                if (resDonGia == false)
                {
                    MessageBox.Show("Đơn giá không chính xác");
                }
                else
                {
                    SanPham sp = new SanPham(maSP, tenSP, donGia, donViTinh, soLuong, maLoai, maNCC, anh);
                    SanPhamBUS.updateSanPham(sp);
                    MessageBox.Show("Sửa Thành Công");
                    dgv_SanPham.DataSource = SanPhamBUS.getAllSanPham();
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {

            string maSP = txtMaSP.Text.Trim();
          

            bool check = false;
            foreach (CTHoaDonDTO cthd in CTHoaDonBUS.docCTHD())
            {
                foreach (CTPhieuNhapHang ctpnh in CTPhieuNhapBUS.layToanBoDanhSach())
                {
                    string kq = cthd.MaSP.Trim();
                    string temp = ctpnh.MaSP.Trim();
                   
                    if (maSP.Equals(kq) || maSP.Equals(temp))
                    {
                        check = true;
                        break;
                    }
                }
            }
            if (check == true)
            {
                MessageBox.Show("Không thể xoá sản phẩm do trùng với danh sách phiếu nhập hoặc hoá đơn đã có");
            }
            else
            {
                MessageBox.Show("Xoá Thành Công");
                SanPhamBUS.deleteSanPham(maSP);
                dgv_SanPham.DataSource = SanPhamBUS.getAllSanPham();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Chọn Ảnh";
            openFileDialog.Filter = "Image Files(*.gif;*.jpg;*jpeg;*.bmp;*.wmf;*.png)|*.gif;*.jpg;*jpeg;*.bmp;*.wmf;*.png";
            openFileDialog.FilterIndex = 2;
            openFileDialog.RestoreDirectory = true;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.ImageLocation = openFileDialog.FileName;
            }
        }

        public byte[] ImageToByteArray(PictureBox pictureBox)
        {
            //string s = Application.StartupPath.ToString();

            MemoryStream memoryStream = new MemoryStream();
            pictureBox.Image.Save(memoryStream, pictureBox.Image.RawFormat);
            return memoryStream.ToArray();
        }

        private void dgv_SanPham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow data = new DataGridViewRow();
                data = dgv_SanPham.Rows[e.RowIndex];
                txtMaSP.Text = data.Cells[0].Value.ToString().Trim();
                txtTenSP.Text = data.Cells[1].Value.ToString().Trim();
                txtDonGia.Text = data.Cells[2].Value.ToString().Trim();
                txtDonViTinh.Text = data.Cells[3].Value.ToString().Trim();
                txtSoLuong.Text = data.Cells[4].Value.ToString().Trim();
                txtMaLoai.Text = data.Cells[5].Value.ToString().Trim();
                txtMaNCC.Text = data.Cells[6].Value.ToString().Trim();
                if (data.Cells[7].Value.ToString().Trim() != "")
                {
                    MemoryStream memoryStream = new MemoryStream((byte[])data.Cells[7].Value);
                    pictureBox1.Image = Image.FromStream(memoryStream);
                }
                else
                {
                    pictureBox1.Image = null;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void dgv_SanPham_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            ChonNhaCungCap chonNhanVien = new ChonNhaCungCap();
            chonNhanVien.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string maSp = txtMaSP.Text;
            maSp = maSp.Trim();
            MessageBox.Show(SanPhamBUS.laySoLuong(maSp).ToString());
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            dgv_SanPham.DataSource = SanPhamBUS.getAllSanPham();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        [Obsolete]
        private void btnThemLoai_Click(object sender, EventArgs e)
        {
            string maLoai = txt_CTMaLoai.Text.Trim();
            string tenLoai = txt_CTTenLoai.Text.Trim();

            if (maLoai.Equals("") || tenLoai.Equals(""))
            {
                MessageBox.Show("Chưa điền đầy đủ thông tin để thêm");
            }
            else
            {

                bool check = false;
                int i;
                for (i = 0; i < dgvLoaiSanPham.Rows.Count; i++)
                {
                    string kq = dgvLoaiSanPham.Rows[i].Cells[0].Value.ToString().Trim();
                    if (maLoai.Equals(kq))
                    {
                        check = true;
                        MessageBox.Show("mã bị trùng");
                        break;
                    }
                }

                if (check == false)
                {
                    loaiSanPham loaiSanPham = new loaiSanPham(maLoai, tenLoai);
                    MessageBox.Show("Thêm Loại Sản Phẩm Thành Công");
                    LoaiSanPhamBUS.insertSanPham(loaiSanPham);
                    dgvLoaiSanPham.DataSource = LoaiSanPhamBUS.getAllSanPham();
                }
            }
        }

        [Obsolete]
        private void btnSuaLoai_Click(object sender, EventArgs e)
        {
            string maLoai = txt_CTMaLoai.Text.Trim();
            string tenLoai = txt_CTTenLoai.Text.Trim();


            loaiSanPham loaiSanPham = new loaiSanPham(maLoai, tenLoai);
            MessageBox.Show("Sửa Loại Sản Phẩm Thành Công");
            LoaiSanPhamBUS.updateSanPham(loaiSanPham);
            dgvLoaiSanPham.DataSource = LoaiSanPhamBUS.getAllSanPham();

        }

        private void btnXoaLoai_Click(object sender, EventArgs e)
        {
            string maLoai = txt_CTMaLoai.Text.Trim();
            int i = dgvLoaiSanPham.CurrentCell.RowIndex;
            MessageBox.Show(i + "");
            bool check = false;
            if (i >= 0)
            {
                for (i = 0; i < dgv_SanPham.Rows.Count; i++)
                {
                    string kq = dgv_SanPham.Rows[i].Cells[5].Value.ToString().Trim();

                    if (maLoai.Equals(kq))
                    {
                        MessageBox.Show(maLoai + "==" + kq);
                        check = true;
                        break;
                    }
                    if (i == dgvLoaiSanPham.Rows.Count)
                    {
                        MessageBox.Show(i + "==");
                        break;
                    }
                }

                if (check == true)
                {
                    MessageBox.Show("Loại sản phẩm đã tồn tại trong danh sách sản phẩm Không thể xoá");
                }
                else if (check == false)
                {
                    MessageBox.Show("Xoá Loại Sản Phẩm Thành Công");
                    LoaiSanPhamBUS.deleteSanPham(maLoai);
                    dgvLoaiSanPham.DataSource = LoaiSanPhamBUS.getAllSanPham();
                    txt_CTMaLoai.Text = "";
                    txt_CTTenLoai.Text = "";
                }
            }
            else
            {
                MessageBox.Show("Chưa chọn loại sản phẩm để xoá");
            }
        }

        private void dgvLoaiSanPham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow data = new DataGridViewRow();
                data = dgvLoaiSanPham.Rows[e.RowIndex];
                txt_CTMaLoai.Text = data.Cells[0].Value.ToString().Trim();
                txt_CTTenLoai.Text = data.Cells[1].Value.ToString().Trim();

            }
            catch (Exception)
            {
                throw;
            }
        }

        private void cbLoc_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            dgv_SanPham.DataSource = SanPhamBUS.searchSanPham(txtTimKiem.Text.Trim());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ChonNhaCungCap chonNhaCungCap = new ChonNhaCungCap();
            chonNhaCungCap.ShowDialog();
            txtMaNCC.Text = ChonNhaCungCap.maSP.Trim();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void txtMaNCC_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnMaLoai_Click(object sender, EventArgs e)
        {
            ChonLoaiSanPham chonLoaiSanPham = new ChonLoaiSanPham();
            chonLoaiSanPham.ShowDialog();
            txtMaLoai.Text = ChonLoaiSanPham.maLoaiSP.Trim();
        }

        private void btnMaSP_Click(object sender, EventArgs e)
        {
            txtMaSP.Text = "SP" + dgv_SanPham.Rows.Count;
        }

        private void btnMaLoaiSP_Click(object sender, EventArgs e)
        {
            txtMaLoai.Text = "L" + dgvLoaiSanPham.Rows.Count;
        }
    }
}
