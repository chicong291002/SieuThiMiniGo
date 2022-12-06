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

namespace SieuThiMini
{
    public partial class QuanLy : Form
    {

        [Obsolete]
        public QuanLy()
        {
            InitializeComponent();
        }

        
         

        [Obsolete]
        private void button9_Click(object sender, EventArgs e)
        {
            DangNhap dangNhap = new DangNhap();
            this.Hide();
            dangNhap.ShowDialog();
        }
        private void QuanLy_Load(object sender, EventArgs e)
        {
            
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            UC_SP.BringToFront();
            
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            UC_NV.BringToFront();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            UC_CTKM.BringToFront();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UC_NhapHang.BringToFront();
        }

        private void button8_Click_1(object sender, EventArgs e)
        {
            UC_ThongKe.BringToFront();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            UC_TaiKhoan.BringToFront();
        }

        [Obsolete]
        private void button9_Click_1(object sender, EventArgs e)
        {
            DangNhap dangNhap = new DangNhap();
            this.Hide();
            dangNhap.ShowDialog();
        }

        private void UC_ThongKe_Load(object sender, EventArgs e)
        {

        }

        [Obsolete]
        private void btnBanHang_Click(object sender, EventArgs e)
        {
            this.Hide();
            BanHang banHang = new BanHang(true,DangNhap.maNV);
            banHang.ShowDialog();
        }
    }
}
