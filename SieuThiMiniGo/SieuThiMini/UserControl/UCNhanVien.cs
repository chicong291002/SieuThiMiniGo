using DryIoc.ImTools;
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
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
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
            dgvNhanVien.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        [Obsolete]
        private void btnThem_Click(object sender, EventArgs e)
        {
            string maNV = txtMaNV.Text.Trim();
            string hoNV = txtHoNV.Text.Trim();
            string tenNV = txtTenNV.Text.Trim();
            string sdt = txtSDT.Text.Trim();
            string cmnd = txtCMND.Text.Trim();
            string email = txtEmail.Text.Trim();
            DateTime ngaySinh = dtNgaySinh.Value;
            string gioiTinh = cbGioiTinh.Text.Trim();
            string luong = txtLuong.Text.Trim();
            string viTri = cbViTri.Text.Trim();
            DateTime ngayVaoLam = dtNgayVaoLam.Value;

            if (maNV.Equals("") || hoNV.Equals("") || tenNV.Equals("") || sdt.Equals("") || cmnd.Equals("") || email.Equals("")
                || gioiTinh.Equals("") || luong.Equals("") || viTri.Equals("")){
                MessageBox.Show("Chưa có chọn đầy đủ thông tin");
            }
            else
            {
                bool check = false;
                int i;

                //check gender
                String sex = "^[a-zA-Z]+(([\\'\\ \\][(^10$|^[0-9]{1,2}]))+(([\\'\\ \\][(?:m|M|f|F|)$]))*$";
                Regex regexSex = new Regex(sex);
                var resSex = regexSex.IsMatch(gioiTinh);

                //check fullName
                String USERNAME_PATTERN = "^[a-zA-Z_ÀÁÂÃÈÉÊÌÍÒÓÔÕÙÚĂĐĨŨƠàáâãèéêìíòóôõùúăđĩũơƯĂẠẢẤẦẨẪẬẮẰẲẴẶ" +
                "ẸẺẼỀỀỂưăạảấầẩẫậắằẳẵặẹẻẽềềểỄỆỈỊỌỎỐỒỔỖỘỚỜỞỠỢỤỦỨỪễệỉịọỏốồổỗộớờởỡợ" +
                "ụủứừỬỮỰỲỴÝỶỸửữựỳỵỷỹ\\s]+$";
                Regex regex = new Regex(USERNAME_PATTERN);
                var res = regex.IsMatch(tenNV);

                //check email
                string checkEmail = @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$";
                Regex regexEmail = new Regex(checkEmail);
                var res1111 = regexEmail.IsMatch(email);

                //check sdt
                string checkSDT = @"^\(?([0-9]{3})\)?[-.●]?([0-9]{3})[-.●]?([0-9]{4})$";
                Regex regexSDT = new Regex(checkSDT);
                var resSDT = regexSDT.IsMatch(sdt);

                //check CMND
                string checkCMND = @"[0-9]{9}";
                Regex regexCMND = new Regex(checkCMND);
                var resCMND = regexCMND.IsMatch(cmnd);

                //check fullName
                String xx = "^[a-zA-Z_ÀÁÂÃÈÉÊÌÍÒÓÔÕÙÚĂĐĨŨƠàáâãèéêìíòóôõùúăđĩũơƯĂẠẢẤẦẨẪẬẮẰẲẴẶ" +
                "ẸẺẼỀỀỂưăạảấầẩẫậắằẳẵặẹẻẽềềểỄỆỈỊỌỎỐỒỔỖỘỚỜỞỠỢỤỦỨỪễệỉịọỏốồổỗộớờởỡợ" +
                "ụủứừỬỮỰỲỴÝỶỸửữựỳỵỷỹ\\s]+$";
                Regex regex11 = new Regex(xx);
                var resname = regex11.IsMatch(tenNV);

                //check Ho
                String ho = "^[a-zA-Z_ÀÁÂÃÈÉÊÌÍÒÓÔÕÙÚĂĐĨŨƠàáâãèéêìíòóôõùúăđĩũơƯĂẠẢẤẦẨẪẬẮẰẲẴẶ" +
                "ẸẺẼỀỀỂưăạảấầẩẫậắằẳẵặẹẻẽềềểỄỆỈỊỌỎỐỒỔỖỘỚỜỞỠỢỤỦỨỪễệỉịọỏốồổỗộớờởỡợ" +
                "ụủứừỬỮỰỲỴÝỶỸửữựỳỵỷỹ\\s]+$";
                Regex regexHo = new Regex(ho);
                var resHo = regexHo.IsMatch(hoNV);

                string checkNumber = "^[0-9 -]+$";
                Regex regexNumber = new Regex(checkNumber);
                var resNumber = regexNumber.IsMatch(luong + "");


                if (resname == false)
                {
                    MessageBox.Show("Tên của bạn chưa có đúng á");
                }
                else
                {
                    if (res1111 == false)
                    {
                        MessageBox.Show("email chưa chính xác");
                    }
                    else
                    {
                        if (resHo == false)
                        {
                            MessageBox.Show("Họ của bạn không chính xác");
                        }
                        else
                        {
                            if (resNumber == false)
                            {
                                MessageBox.Show("Nhập lương sai cú pháp");
                            }
                            else
                            {
                                if (resSDT == false)
                                {
                                    MessageBox.Show("SDT chưa chính xác");
                                }
                                else
                                {
                                    if (resCMND == false)
                                    {
                                        MessageBox.Show("Chứng Minh nhân dân chưa đúng");
                                    }
                                    else
                                    {

                                        if (ngayVaoLam < ngaySinh)
                                        {
                                            MessageBox.Show("Ngày Vào Làm phải lớn hơn ngày sinh nha fen !!");
                                        }
                                        else
                                        {

                                            int index = dgvNhanVien.CurrentCell.RowIndex;
                                            if (index >= 0)
                                            {
                                                for (i = 0; i < dgvNhanVien.Rows.Count - 1; i++)
                                                {
                                                    string kq = dgvNhanVien.Rows[i].Cells[0].Value.ToString().Trim();
                                                    if (maNV.Equals(kq))
                                                    {
                                                        check = true;
                                                        break;
                                                    }
                                                }
                                            }

                                            if (check == false)
                                            {
                                                MessageBox.Show("Thêm Nhân Viên Thành Công");
                                                NhanVien nv = new NhanVien(maNV, hoNV, tenNV, sdt, cmnd, email, ngaySinh, gioiTinh, luong, viTri, ngayVaoLam);
                                                NhanVienBUS.insertNhanVien(nv);
                                                dgvNhanVien.DataSource = NhanVienBUS.GetAllNhanVien();
                                            }
                                            else
                                            {

                                                MessageBox.Show("mã bị trùng");
                                                txtMaNV.Text = "";
                                                txtHoNV.Text = "";
                                                txtTenNV.Text = "";
                                                txtSDT.Text = "";
                                                txtCMND.Text = "";
                                                cbGioiTinh.Text = "";
                                                txtLuong.Text = "";
                                                cbViTri.Text = "";
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        [Obsolete]
        private void btnXoa_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Xoá Nhân Viên Thành Công");
            string maNV = txtMaNV.Text.Trim();
            bool check = false;
            foreach (TaiKhoan tk in TaiKhoanBUS.getAllTaiKhoan())
            {
                string kq = tk.MaNV.Trim();
                if (maNV.Equals(kq))
                {
                    check = true;
                    TaiKhoanBUS.deleteTaiKhoanNV(maNV);
                    NhanVienBUS.deleteNhanVien(maNV);
                }
            }
            if (check == false)
            {
                dgvNhanVien.DataSource = NhanVienBUS.GetAllNhanVien();
            }
            else
            {
                NhanVienBUS.deleteNhanVien(maNV);
                dgvNhanVien.DataSource = NhanVienBUS.GetAllNhanVien();
            }
        }

        [Obsolete]
        private void btnSua_Click(object sender, EventArgs e)
        {
            string maNV = txtMaNV.Text.Trim();
            string hoNV = txtHoNV.Text.Trim();
            string tenNV = txtTenNV.Text.Trim();
            string sdt = txtSDT.Text.Trim();
            string cmnd = txtCMND.Text.Trim();
            string email = txtEmail.Text.Trim();
            DateTime ngaySinh = dtNgaySinh.Value;
            string gioiTinh = cbGioiTinh.Text;
            string luong = txtLuong.Text.Trim();
            string viTri = cbViTri.Text.Trim();
            DateTime ngayVaoLam = dtNgayVaoLam.Value;

            //check gender
            String sex = "^[a-zA-Z]+(([\\'\\ \\][(^10$|^[0-9]{1,2}]))+(([\\'\\ \\][(?:m|M|f|F|)$]))*$";
            Regex regexSex = new Regex(sex);
            var resSex = regexSex.IsMatch(gioiTinh);

            //check fullName
            String USERNAME_PATTERN = "^[a-zA-Z_ÀÁÂÃÈÉÊÌÍÒÓÔÕÙÚĂĐĨŨƠàáâãèéêìíòóôõùúăđĩũơƯĂẠẢẤẦẨẪẬẮẰẲẴẶ" +
            "ẸẺẼỀỀỂưăạảấầẩẫậắằẳẵặẹẻẽềềểỄỆỈỊỌỎỐỒỔỖỘỚỜỞỠỢỤỦỨỪễệỉịọỏốồổỗộớờởỡợ" +
            "ụủứừỬỮỰỲỴÝỶỸửữựỳỵỷỹ\\s]+$";
            Regex regex = new Regex(USERNAME_PATTERN);
            var res = regex.IsMatch(tenNV);

            //check email
            string checkEmail = @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$";
            Regex regexEmail = new Regex(checkEmail);
            var res1111 = regexEmail.IsMatch(email);

            //check sdt
            string checkSDT = @"^\(?([0-9]{3})\)?[-.●]?([0-9]{3})[-.●]?([0-9]{4})$";
            Regex regexSDT = new Regex(checkSDT);
            var resSDT = regexSDT.IsMatch(sdt);

            //check CMND
            string checkCMND = @"[0-9]{9}";
            Regex regexCMND = new Regex(checkCMND);
            var resCMND = regexCMND.IsMatch(cmnd);

            //check fullName
            String xx = "^[a-zA-Z_ÀÁÂÃÈÉÊÌÍÒÓÔÕÙÚĂĐĨŨƠàáâãèéêìíòóôõùúăđĩũơƯĂẠẢẤẦẨẪẬẮẰẲẴẶ" +
            "ẸẺẼỀỀỂưăạảấầẩẫậắằẳẵặẹẻẽềềểỄỆỈỊỌỎỐỒỔỖỘỚỜỞỠỢỤỦỨỪễệỉịọỏốồổỗộớờởỡợ" +
            "ụủứừỬỮỰỲỴÝỶỸửữựỳỵỷỹ\\s]+$";
            Regex regex11 = new Regex(xx);
            var resname = regex11.IsMatch(tenNV);

            //check Ho
            String ho = "^[a-zA-Z_ÀÁÂÃÈÉÊÌÍÒÓÔÕÙÚĂĐĨŨƠàáâãèéêìíòóôõùúăđĩũơƯĂẠẢẤẦẨẪẬẮẰẲẴẶ" +
            "ẸẺẼỀỀỂưăạảấầẩẫậắằẳẵặẹẻẽềềểỄỆỈỊỌỎỐỒỔỖỘỚỜỞỠỢỤỦỨỪễệỉịọỏốồổỗộớờởỡợ" +
            "ụủứừỬỮỰỲỴÝỶỸửữựỳỵỷỹ\\s]+$";
            Regex regexHo = new Regex(ho);
            var resHo = regexHo.IsMatch(hoNV);

            string checkNumber = "^[0-9 -]+$";
            Regex regexNumber = new Regex(checkNumber);
            var resNumber = regexNumber.IsMatch(luong + "");


            if (resname == false)
            {
                MessageBox.Show("Tên của bạn chưa có đúng á");
            }
            else
            {
                if (res1111 == false)
                {
                    MessageBox.Show("email chưa chính xác");
                }
                else
                {
                    if (resHo == false)
                    {
                        MessageBox.Show("Họ của bạn không chính xác");
                    }
                    else
                    {
                        if (resNumber == false)
                        {
                            MessageBox.Show("Nhập lương sai cú pháp");
                        }
                        else
                        {
                            if (resSDT == false)
                            {
                                MessageBox.Show("SDT chưa chính xác");
                            }
                            else
                            {
                                if (resCMND == false)
                                {
                                    MessageBox.Show("Chứng Minh nhân dân chưa đúng");
                                }
                                else
                                {
                                    if (ngayVaoLam < ngaySinh)
                                    {
                                        MessageBox.Show("Ngày Vào Làm phải lớn hơn ngày sinh nha fen !!");
                                    }
                                    else
                                    {
                                        int index = dgvNhanVien.CurrentCell.RowIndex;
                                        if (index < 0)
                                        {
                                            MessageBox.Show("Chưa chọn sao sửa anh trai!");
                                        }
                                        else
                                        {
                                            MessageBox.Show("Sửa Nhân Viên Thành Công");
                                            NhanVien nv = new NhanVien(maNV, hoNV, tenNV, sdt, cmnd, email, ngaySinh, gioiTinh, luong, viTri, ngayVaoLam);
                                            NhanVienBUS.updateNhanVien(nv);

                                            dgvNhanVien.DataSource = NhanVienBUS.GetAllNhanVien();
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
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

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnXoa_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Xoá Nhân Viên Thành Công");
            string maNV = txtMaNV.Text.Trim();
            bool check = false;
            foreach (TaiKhoan tk in TaiKhoanBUS.getAllTaiKhoan())
            {
                string kq = tk.MaNV.Trim();
                if (maNV.Equals(kq))
                {
                    check = true;
                    TaiKhoanBUS.deleteTaiKhoanNV(maNV);
                    NhanVienBUS.deleteNhanVien(maNV);
                }
            }
            if (check == true)
            {
                dgvNhanVien.DataSource = NhanVienBUS.GetAllNhanVien();
            }
            else
            {
                NhanVienBUS.deleteNhanVien(maNV);
                dgvNhanVien.DataSource = NhanVienBUS.GetAllNhanVien();
            }
        }

        private void btnMaNV_Click(object sender, EventArgs e)
        {
            txtMaNV.Text = "NV" + dgvNhanVien.Rows.Count;
        }
    }
}
