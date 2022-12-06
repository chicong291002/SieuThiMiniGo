using SieuThiMini.BUS;
using SieuThiMini.DTO;
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

namespace SieuThiMini.GUI
{
    public partial class UCTaiKhoan : UserControl
    {

        [Obsolete]
        public UCTaiKhoan()
        {
            InitializeComponent();
            dgvTaiKhoan.DataSource = TaiKhoanBUS.getAllTaiKhoan();
            dgvTaiKhoan.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        [Obsolete]
        private void btnThem_Click(object sender, EventArgs e)
        {
            string maTK = txtMaTK.Text.Trim();
            string tenTK = txtTenTK.Text;
            string matKhau = txtMatKhau.Text;
            string email = txtEmail.Text;
            string maNV = txtMaNV.Text.Trim();
            string phanQuyen = cbPhanQuyen.Text.Trim();
            string trangThai = cbTrangThai.Text.Trim();

            bool temp = false;
            bool check = false; 
            int i;
            if (maTK.Equals("") || tenTK.Equals("") || matKhau.Equals("") || email.Equals("") ||
                 maNV.Equals("") || phanQuyen.Equals("") || trangThai.Equals(""))
            {
                MessageBox.Show("Chưa có chọn đầy đủ thông tin");
            }
            else
            {
                //check email
                string checkEmail = @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$";
                Regex regexEmail = new Regex(checkEmail);
                var res1111 = regexEmail.IsMatch(email);


                string checkPass = "^(?=.*[a-z])(?=.*[A-Z])(?=.*\\d)(?=.*[^\\da-zA-Z]).{8,15}$";
                Regex regexPassWord = new Regex(checkPass);
                var resPassWord = regexPassWord.IsMatch(matKhau + "");
                string kq11 = cbPhanQuyen.GetItemText(cbPhanQuyen.SelectedItem).Trim();
                string kq1 = cbTrangThai.GetItemText(cbTrangThai.SelectedItem).Trim();


                if (check == false)
                {
                    if (res1111 == false)
                    {
                        MessageBox.Show("Email chưa hợp lý");
                    }
                    else
                    {

                            //int index = dgvTaiKhoan.CurrentCell.RowIndex;
                           // if (index >= 0)
                            {
                                for (i = 0; i < dgvTaiKhoan.Rows.Count - 1; i++)
                                {
                                    string kq = dgvTaiKhoan.Rows[i].Cells[0].Value.ToString().Trim();
                                    if (maTK.Equals(kq))
                                    {
                                        check = true;
                                        break;
                                    }
                                }
                            }

                            if (check == false)
                            {
                                foreach (NhanVien nv in NhanVienBUS.GetAllNhanVien())
                                {

                                    if (nv.MaNV.Trim().Equals(txtMaNV.Text.Trim()))
                                    {
                                        temp = true;
                                        break;
                                    }
                                }

                                if (temp == true)
                                {

                                    MessageBox.Show("Thêm Thành Công");
                                    TaiKhoan tk = new TaiKhoan(maTK, tenTK, matKhau, email, maNV, phanQuyen, trangThai);
                                    TaiKhoanBUS.insertTaiKhoan(tk);
                                    dgvTaiKhoan.DataSource = TaiKhoanBUS.getAllTaiKhoan();
                                }
                                else
                                {
                                    MessageBox.Show("mã nhân viên thêm phải trùng với danh sách nhân viên");
                                }
                            }
                            else
                            {
                                MessageBox.Show("mã bị trùng");
                                txtMaTK.Text = "";
                                txtTenTK.Text = "";
                                txtMatKhau.Text = "";
                                txtEmail.Text = "";
                                txtMaNV.Text = "";
                                cbPhanQuyen.Text = "";
                                cbTrangThai.Text = "";
                            }
                        }

                    
                }
            }
        }

        [Obsolete]
        private void btnSua_Click(object sender, EventArgs e)
        {
            string maTK = txtMaTK.Text.Trim();
            string tenTK = txtTenTK.Text.Trim();
            string matKhau = txtMatKhau.Text.Trim();
            string email = txtEmail.Text.Trim();
            string maNV = txtMaNV.Text.Trim();
            string phanQuyen = cbPhanQuyen.Text.Trim();
            string trangThai = cbTrangThai.Text.Trim();
            TaiKhoan tk = new TaiKhoan(maTK, tenTK, matKhau, email, maNV, phanQuyen, trangThai);
            TaiKhoanBUS.updateTaiKhoan(tk);
            dgvTaiKhoan.DataSource = TaiKhoanBUS.getAllTaiKhoan();
            MessageBox.Show("Sửa Thành Công");
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string maTK = txtMaTK.Text.Trim();
            TaiKhoanBUS.deleteTaiKhoan(maTK);
            dgvTaiKhoan.DataSource = TaiKhoanBUS.getAllTaiKhoan();
            MessageBox.Show("Xoá Thành Công");
        }

        private void dgvTaiKhoan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow data = new DataGridViewRow();
                data = dgvTaiKhoan.Rows[e.RowIndex];
                txtMaTK.Text = data.Cells[0].Value.ToString().Trim();
                txtTenTK.Text = data.Cells[1].Value.ToString();
                txtMatKhau.Text = data.Cells[2].Value.ToString();



                txtMaNV.Text = data.Cells[3].Value.ToString().Trim();

                cbPhanQuyen.Text = data.Cells[4].Value.ToString();

                cbTrangThai.Text = data.Cells[5].Value.ToString();
                txtEmail.Text = data.Cells[6].Value.ToString();
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void UCTaiKhoan_Load(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            dgvTaiKhoan.DataSource = TaiKhoanBUS.search(textBox5.Text);
        }

        private void btnChonMaNV_Click(object sender, EventArgs e)
        {
            ChonNhanVien chonNhanVien = new ChonNhanVien();
            chonNhanVien.ShowDialog();
            txtMaNV.Text = ChonNhanVien.maNCC.Trim();
        }

        private void btnMaTK_Click(object sender, EventArgs e)
        {
            txtMaTK.Text = "TK" + (dgvTaiKhoan.Rows.Count+1);
        }
    }
}
