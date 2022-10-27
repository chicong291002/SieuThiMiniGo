using SieuThiMini.BUS;
using SieuThiMini.DTO;
using SieuThiMini.GUI;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace SieuThiMini
{
    public partial class UCSP : UserControl
    {
        [Obsolete]
        public UCSP()
        {
            InitializeComponent();
            dgv_SanPham.DataSource = SanPhamBUS.getAllSanPham();
            dgv_MaLoai.DataSource = LoaiSanPhamBUS.getAllSanPham();
            DataGridViewImageColumn pic = new DataGridViewImageColumn();
            pic = (DataGridViewImageColumn)dgv_SanPham.Columns[7];
            pic.ImageLayout = DataGridViewImageCellLayout.Zoom;
            
        }

        [Obsolete]
        private void btnThem_Click(object sender, EventArgs e)
        {
            string maSP = txtMaSP.Text;
            string tenSP = txtTenSP.Text;
            float donGia = float.Parse(txtDonGia.Text);
            string donViTinh = txtDonViTinh.Text;
            int soLuong = int.Parse(txtSoLuong.Text);
            string maLoai = txtMaLoai.Text;
            string maNCC = txtMaNCC.Text;
            byte[] anh = ImageToByteArray(pictureBox1);
            SanPham sp = new SanPham(maSP, tenSP, donGia, donViTinh, soLuong, maLoai, maNCC, anh);
            SanPhamBUS.insertSanPham(sp);
            MessageBox.Show("Thêm Thành Công");
            dgv_SanPham.DataSource = SanPhamBUS.getAllSanPham();
        }

        [Obsolete]
        private void btnSua_Click(object sender, EventArgs e)
        {
            string maSP = txtMaSP.Text;
            string tenSP = txtTenSP.Text;
            float donGia = float.Parse(txtDonGia.Text);
            string donViTinh = txtDonViTinh.Text;
            int soLuong = int.Parse(txtSoLuong.Text);
            string maLoai = txtMaLoai.Text;
            string maNCC = txtMaNCC.Text;
            byte[] anh = ImageToByteArray(pictureBox1);
            SanPham sp = new SanPham(maSP, tenSP, donGia, donViTinh, soLuong, maLoai, maNCC, anh);
            SanPhamBUS.updateSanPham(sp);
            dgv_SanPham.DataSource = SanPhamBUS.getAllSanPham();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string maSP = txtMaSP.Text;
            SanPhamBUS.deleteSanPham(maSP);
            dgv_SanPham.DataSource = SanPhamBUS.getAllSanPham();
        }

        private void btnThemMaLoai_Click(object sender, EventArgs e)
        {
            string maLoai = txt_MaLoai.Text;
            string tenLoai = txtTenLoai.Text;
            loaiSanPham loaiSanPham = new loaiSanPham(maLoai, tenLoai);

        }

        private void btnSuaMaLoai_Click(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void btnXoaMaLoai_Click(object sender, EventArgs e)
        {

        }

        private void btnInAn_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Chọn Ảnh";
            openFileDialog.Filter = "Image Files(*.gif;*.jpg;*jpeg;*.bmp;*.wmf;*.png)|*.gif;*.jpg;*jpeg;*.bmp;*.wmf;*.png";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.ImageLocation = openFileDialog.FileName;
            }
        }

        public byte[] ImageToByteArray(PictureBox pictureBox)
        {
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
                txtMaSP.Text = data.Cells[0].Value.ToString();
                txtTenSP.Text = data.Cells[1].Value.ToString();
                txtDonGia.Text = data.Cells[2].Value.ToString();
                txtDonViTinh.Text = data.Cells[3].Value.ToString();
                txtSoLuong.Text = data.Cells[4].Value.ToString();
                txtMaLoai.Text = data.Cells[5].Value.ToString();
                txtMaNCC.Text = data.Cells[6].Value.ToString();
                if (data.Cells[7].Value.ToString() != "")
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

        private void button2_Click(object sender, EventArgs e)
        {
            ChonNhaCungCap chonNhaCungCap = new ChonNhaCungCap();
            chonNhaCungCap.ShowDialog();
            txtMaNCC.Text = ChonNhaCungCap.maSP;
        }
    }
}
