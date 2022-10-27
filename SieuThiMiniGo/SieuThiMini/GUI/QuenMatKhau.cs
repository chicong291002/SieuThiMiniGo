using SieuThiMini.BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SieuThiMini.GUI
{
    public partial class QuenMatKhau : Form
    {
        [Obsolete]
        public QuenMatKhau()
        {
            InitializeComponent();
        }

        private void btnHienThi_Click(object sender, EventArgs e)
        {
            if (txtEmail.Text.Trim().Equals(""))
            {
                MessageBox.Show("chưa nhập email");
            }
            else
            {
                if (TaiKhoanBUS.checkPassWord(txtEmail.Text) != "")
                {
                    label2.ForeColor = Color.Red;
                    label2.Text = "Mật khẩu:" + TaiKhoanBUS.checkPassWord(txtEmail.Text);
                }
            }
        }

        [Obsolete]
        private void btnQuayVe_Click(object sender, EventArgs e)
        {
            DangNhap dangNhap = new DangNhap();
            this.Hide();
            dangNhap.ShowDialog();
        }
    }
}
