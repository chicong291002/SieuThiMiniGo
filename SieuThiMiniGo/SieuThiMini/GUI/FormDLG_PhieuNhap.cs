using SieuThiMini.DTO;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SieuThiMini.GUI
{
    public partial class FormDLG_PhieuNhap : Form
    {
        public FormDLG_PhieuNhap()
        {
            InitializeComponent();
        }

        private void FormDLG_PhieuNhap_Load(object sender, EventArgs e)
        {

        }

        private void btnInPhieu_Click(object sender, EventArgs e)
        {

        }

        public void xuLyHienThiNhap(List<ListViewItem> dspn,string nhanVien,string nhaCungCap,DateTime ngayLap)
        {
            try
            {
                txtNhanVien.Text = nhanVien;
                txtNhaCungCap.Text = nhaCungCap;
                txtNgayLap.Text = ngayLap.ToString();
                foreach(ListViewItem s in dspn)
                {
                    table_CTPN.Items.Add(s);                    
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("lỗi rồi " + ex.Message);
            }
        }

        private void table_CTPN_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void txtNgayLap_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
