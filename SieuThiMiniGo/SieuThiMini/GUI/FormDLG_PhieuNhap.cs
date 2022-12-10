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
using System.Drawing.Imaging;
using System.Drawing;
using System;
using System.Drawing.Drawing2D;
using SieuThiMini.BUS;

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

        private void btnInPhieuNhap_Click(object sender, EventArgs e)
        { 

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString("Hoá Đơn Phiếu Nhập",
                new Font("Arial", 40, FontStyle.Underline), Brushes.BlueViolet, new Point(105, 15));
            
            e.Graphics.DrawString("Nhân Viên: " +    txtNhanVien.Text, 
                new Font("Arial",12,FontStyle.Regular),Brushes.Black, new Point(25, 180));

            e.Graphics.DrawString("Ngày Lập: " +     txtNgayLap.Text, 
                new Font("Arial", 12,FontStyle.Regular), Brushes.Black, new Point(25, 200));

            e.Graphics.DrawString("Nhà Cung Cấp: " + txtNhaCungCap.Text,
                new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(25, 220));


            e.Graphics.DrawString("Mã SP",
                 new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(25, 280));

            e.Graphics.DrawString("Tên SP",
                new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(105, 280));

            e.Graphics.DrawString("Số Lượng",
                new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(505, 280));

            e.Graphics.DrawString("Đơn Giá",
                new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(605, 280));

            e.Graphics.DrawString("Thành Tiền",
                new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(705, 280));
            float sum = 0;
            int x = 320,i;
            int index = table_CTPN.Items.Count;
            for (i = 0; i < index; i++)
            {
                e.Graphics.DrawString(table_CTPN.Items[i].SubItems[0].Text.Trim(),
                new Font("Arial", 12, FontStyle.Regular),  Brushes.Black,  new Point(25, x));

                e.Graphics.DrawString(table_CTPN.Items[i].SubItems[1].Text.Trim(),
                 new Font("Arial", 12, FontStyle.Regular), Brushes.Black,  new Point(105, x));

                e.Graphics.DrawString(table_CTPN.Items[i].SubItems[2].Text.Trim(),
                 new Font("Arial", 12, FontStyle.Regular), Brushes.Black,  new Point(505, x));

                e.Graphics.DrawString(table_CTPN.Items[i].SubItems[3].Text.Trim(),
                 new Font("Arial", 12, FontStyle.Regular), Brushes.Black,  new Point(605, x));

                e.Graphics.DrawString(table_CTPN.Items[i].SubItems[4].Text.Trim(),
                 new Font("Arial", 12, FontStyle.Regular), Brushes.Black,  new Point(705, x));
                x += 50;
                sum += float.Parse(table_CTPN.Items[i].SubItems[4].Text.Trim());
            }

            e.Graphics.DrawString("Tổng Tiền",
                new Font("Arial", 12, FontStyle.Regular), Brushes.Red, new Point(705, x + 100));

            e.Graphics.DrawString(sum + "VNĐ",
                new Font("Arial", 12, FontStyle.Regular), Brushes.Red, new Point(705, x + 150));
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {  
           pdDocument.Print();
        }

       
    }
}
