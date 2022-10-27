using SieuThiMini.DAO;
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
        [Obsolete]
        public DangNhap()
        {
            InitializeComponent();
        }

        [Obsolete]
        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if (TaiKhoanDAO.loginAccount(textBox1.Text, textBox2.Text).Count != 0)
            {
                QuanLy quanLy = new QuanLy();
                this.Hide();
                quanLy.ShowDialog();
            }
            else
            {
                MessageBox.Show("nhập sai thông tin");
            }
        }

        [Obsolete]
        private void button1_Click(object sender, EventArgs e)
        {
            QuenMatKhau quenMatKhau = new QuenMatKhau();
            quenMatKhau.ShowDialog();
        }
    }
}
