using OfficeOpenXml;
using SieuThiMini.BUS;
using SieuThiMini.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace SieuThiMini
{
    public partial class UCNhanVien : UserControl
    {
        [Obsolete]
        public UCNhanVien()
        {
            InitializeComponent();
            dgvNhanVien.DataSource = NhanVienBUS.GetAllNhanVien();
        }

        [Obsolete]
        private void btnThem_Click(object sender, EventArgs e)
        {
            string maNV = txtMaNV.Text;
            string hoNV = txtHoNV.Text;
            string tenNV = txtTenNV.Text;
            string sdt = txtSDT.Text;
            string cmnd = txtCMND.Text;
            string email = txtEmail.Text;
            DateTime ngaySinh = dtNgaySinh.Value;
            string gioiTinh = cbGioiTinh.Text;
            float luong = float.Parse(txtLuong.Text);
            string viTri = cbViTri.Text;
            DateTime ngayVaoLam = dtNgayVaoLam.Value;
            NhanVien nv = new NhanVien(maNV, hoNV, tenNV, sdt, cmnd, email, ngaySinh, gioiTinh, luong, viTri, ngayVaoLam);
            NhanVienBUS.insertNhanVien(nv);
            dgvNhanVien.DataSource = NhanVienBUS.GetAllNhanVien();
        }

        [Obsolete]
        private void btnXoa_Click(object sender, EventArgs e)
        {
            string maNV = txtMaNV.Text;
            string hoNV = txtHoNV.Text;
            string tenNV = txtTenNV.Text;
            string sdt = txtSDT.Text;
            string cmnd = txtCMND.Text;
            string email = txtEmail.Text;
            DateTime ngaySinh = dtNgaySinh.Value;
            string gioiTinh = cbGioiTinh.Text;
            float luong = float.Parse(txtLuong.Text);
            string viTri = cbViTri.Text;
            DateTime ngayVaoLam = dtNgayVaoLam.Value;
            NhanVien nv = new NhanVien(maNV, hoNV, tenNV, sdt, cmnd, email, ngaySinh, gioiTinh, luong, viTri, ngayVaoLam);
            NhanVienBUS.updateNhanVien(nv);
            dgvNhanVien.DataSource = NhanVienBUS.GetAllNhanVien();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string maNV = txtMaNV.Text;
            NhanVienBUS.deleteNhanVien(maNV);
            dgvNhanVien.DataSource = NhanVienBUS.GetAllNhanVien();
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            dgvNhanVien.DataSource = NhanVienBUS.searchNhanVien(txtTimKiem.Text);
        }

        private void dgvNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow data = new DataGridViewRow();
                data = dgvNhanVien.Rows[e.RowIndex];
                txtMaNV.Text = data.Cells[0].Value.ToString();
                txtHoNV.Text = data.Cells[1].Value.ToString();
                txtTenNV.Text = data.Cells[2].Value.ToString();
                txtSDT.Text = data.Cells[3].Value.ToString();
                txtCMND.Text = data.Cells[4].Value.ToString();
                txtEmail.Text = data.Cells[5].Value.ToString();
                dtNgaySinh.Value = (DateTime)data.Cells[6].Value;
                cbGioiTinh.Text = data.Cells[7].Value.ToString();
                txtLuong.Text = data.Cells[8].Value.ToString();
                cbViTri.Text = data.Cells[9].Value.ToString();
                dtNgayVaoLam.Value = (DateTime)data.Cells[10].Value;                
            }
            catch (Exception)
            {
                throw;
            }
        }

        [Obsolete]
        private void ImportExcel(string path)
        {
           
            using (ExcelPackage excelPackage = new ExcelPackage(new FileInfo(path)))
            {
                ExcelWorksheet excelWorksheet = excelPackage.Workbook.Worksheets[0];
                DataTable dataTable = new DataTable();
                int i, j;
                for (i = excelWorksheet.Dimension.Start.Column; i <= excelWorksheet.Dimension.End.Column; i++)
                {
                    dataTable.Columns.Add(excelWorksheet.Cells[1, i].Value.ToString());
                }
                for (i = excelWorksheet.Dimension.Start.Row + 1; i <= excelWorksheet.Dimension.End.Row; i++)
                {
                    List<string> listRows = new List<string>();
                    for (j = excelWorksheet.Dimension.Start.Column; j <= excelWorksheet.Dimension.End.Column; j++)
                    {
                        listRows.Add(excelWorksheet.Cells[i, j].Value.ToString());
                    }
                    dataTable.Rows.Add(listRows.ToArray());
                }
                dgvNhanVien.DataSource = dataTable;

                /*
                List<NhanVien> nhanvien = new List<NhanVien>();

                int k = 0;
                for (i = 0; i < dataTable.Rows.Count; i++)
                {
                    if (k == dataTable.Rows.Count)
                    {
                        break;
                    }
                    NhanVien nv = new NhanVien();
                    nv.Manv = dataTable.Rows[i]["MaNV"].ToString().Trim();
                    nv.Honv = dataTable.Rows[i]["HoNV"].ToString();
                    nv.Tennv = dataTable.Rows[i]["TenNV"].ToString();
                    nv.Sdt = dataTable.Rows[i]["SDT"].ToString();
                    nv.Cmnd = dataTable.Rows[i]["CMND"].ToString();
                    nv.Email = dataTable.Rows[i]["Email"].ToString();
                    nv.NgaySinh = DateTime.Parse(dataTable.Rows[i]["NgaySinh"].ToString().Trim());
                    nv.GioiTinh = dataTable.Rows[i]["GioiTinh"].ToString();
                    nv.Luong = float.Parse(dataTable.Rows[i]["Luong"].ToString());
                    nv.ViTri = dataTable.Rows[i]["ViTri"].ToString();
                    nv.NgayVaoLam = DateTime.Parse(dataTable.Rows[i]["NgayVaoLam"].ToString().Trim());
                    nhanvien.Add(nv);
                    NhanVienBUS.insertNhanVien(nv);
                    dgvNhanVien.DataSource = nhanvien;
                }
                NhanVienBUS.GetAllNhanVien();
                */
            }
        }

        [Obsolete]      
        private void btnNhapExcel_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Import Excel";
            openFileDialog.Filter = "Excel (*.xlsx)|*.xlsx|Excel 2003 (*.xls)|*.xls";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    ImportExcel(openFileDialog.FileName);
                    MessageBox.Show("Nhập file thành công");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("không thành công:" + ex.Message);
                    throw;
                }
            }
        }

        private void ExportExcel(string path)
        {
            Excel.Application application = new Excel.Application();
            application.Application.Workbooks.Add(Type.Missing);
            int i, j;
            for (i = 0; i < dgvNhanVien.ColumnCount; i++)
            {
                application.Cells[1, i + 1] = dgvNhanVien.Columns[i].HeaderText;
            }

            for (i = 0; i < dgvNhanVien.Rows.Count; i++)
            {
                for (j = 0; j < dgvNhanVien.Columns.Count; j++)
                {
                    application.Cells[i + 2, j + 1] = dgvNhanVien.Rows[i].Cells[j].Value;
                }
            }
            application.Columns.AutoFit();
            application.ActiveWorkbook.SaveCopyAs(path);
            application.ActiveWorkbook.Saved = true;
        }

        private void btnXuatExcel_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Title = "Export Excel";
            saveFileDialog.Filter = "Excel (*.xlsx)|*.xlsx|Excel 2003 (*.xls)|*.xls";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    ExportExcel(saveFileDialog.FileName);
                    MessageBox.Show("Xuất file thành công");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Xuất file không thành công\n" + ex.Message);
                    throw;
                }
            }
        }

        private void btnInAn_Click(object sender, EventArgs e)
        {
            FormNhanVien formNhanVien = new FormNhanVien();
            formNhanVien.ShowDialog();
        }
    }
}
