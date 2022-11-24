using DryIoc.FastExpressionCompiler.LightExpression;
using SieuThiMini.BUS;
using SieuThiMini.DAO;
using SieuThiMini.DTO;
using SieuThiMini.GUI;
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
    public partial class DangNhap : Form
    {
        public static string maNV;

        [Obsolete]
        public DangNhap()
        {
            InitializeComponent();
        }

        /*
        [Obsolete]
        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            bool flag = false;
            TaiKhoanBUS.getAllTaiKhoan();
            foreach (TaiKhoan tk in TaiKhoanBUS.dstk)
            {

                if (tk.TenTK.Trim().Equals(txtUserName.Text) && tk.MatKhau.Trim().Equals(txtPassWord.Text) && tk.PhanQuyen.Equals("Quản Lý"))
                {
                    MessageBox.Show("Đăng Nhập Thành Công");
                    flag = true;
                    QuanLy quanLy = new QuanLy();
                    quanLy.ShowDialog();
                    this.Hide();
                }

                if (tk.TenTK.Trim().Equals(txtUserName.Text) && tk.MatKhau.Trim().Equals(txtPassWord.Text) && tk.PhanQuyen.Equals("Nhân Viên"))
                {
                    MessageBox.Show("Đăng Nhập Thành Công");
                    flag = true;
                    BanHang bh = new BanHang();

                    bh.ShowDialog();
                    this.Hide();
                }
            }
            if (flag == false)
            {
                MessageBox.Show("Nhập sai thông tin");
            }
        }
        */

        [Obsolete]
        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if (txtUserName.Text.Equals("") || txtPassWord.Text.Equals(""))
            {
                MessageBox.Show("Hãy nhập đầy đủ tài khoản - mật khẩu!");
            }
            else
            {
                maNV = TaiKhoanBUS.login(txtUserName.Text, txtPassWord.Text).Trim();

               
                if (TaiKhoanBUS.quyen().Trim().Equals("Nhân Viên"))
                {
                    MessageBox.Show("Đăng nhập thành công!");
                    this.Visible = false;
                    BanHang fm = new BanHang(maNV);
                    fm.ShowDialog();
                }
                else if (TaiKhoanBUS.quyen().Trim().Equals("Quản Lý"))
                {
                    MessageBox.Show("Đăng nhập thành công!");
                    this.Visible = false;
                    QuanLy fm = new QuanLy();
                    fm.ShowDialog();
                }
                else MessageBox.Show("Đăng nhập thất bại!");
            }
        }

        [Obsolete]
        private void button1_Click(object sender, EventArgs e)
        {
            QuenMatKhau quenMatKhau = new QuenMatKhau();
            this.Hide();
            quenMatKhau.ShowDialog();
        }

        private void cbShowPass_CheckedChanged(object sender, EventArgs e)
        {
            txtPassWord.PasswordChar = cbShowPass.Checked ? '\0' : '*';
        }
    }
}
