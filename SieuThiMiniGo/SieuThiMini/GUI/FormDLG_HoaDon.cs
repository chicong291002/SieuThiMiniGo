using SieuThiMini.DTO;
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
    public partial class FormDLG_HoaDon : Form
    {
        public FormDLG_HoaDon()
        {
            InitializeComponent();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            printDocument1.Print();
        }

        public void xuLyHienThiNhap(List<ListViewItem> DSHD,string maNV,string maKH,string ngayLap)
        {
            try
            {
                txtNhanVien.Text = maNV;
                txtKH.Text = maKH;
                txtNgayLap.Text = ngayLap;
                foreach (ListViewItem s in DSHD)
                {
                    table_HD.Items.Add(s);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("lỗi rồi " + ex.Message);
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString("Hoá Đơn Thanh Toán",
                new Font("Arial", 40, FontStyle.Italic), Brushes.BurlyWood, new Point(105, 15));

            e.Graphics.DrawString("Mã Nhân Viên: " + txtNhanVien.Text,
                new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(25, 180));

            e.Graphics.DrawString("Mã Khách Hàng: " + txtKH.Text,
                new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(25, 200));

            e.Graphics.DrawString("Ngày Lập: " + txtNgayLap.Text,
                new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(25, 220));


            e.Graphics.DrawString("Mã HD",
                 new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(25, 280));

            e.Graphics.DrawString("Mã SP",
                new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(105, 280));

            e.Graphics.DrawString("Tên SP",
                new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(205, 280));

            e.Graphics.DrawString("Số Lượng",
                new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(505, 280));

            e.Graphics.DrawString("Đơn Giá",
                new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(605, 280));

            e.Graphics.DrawString("Thành Tiền",
                new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(705, 280));

            int x = 320, i;
            int index = table_HD.Items.Count;
            float sum = 0;
            for (i = 0; i < index; i++)
            {
                e.Graphics.DrawString(table_HD.Items[i].SubItems[0].Text.Trim(),
                new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(25, x));

                e.Graphics.DrawString(table_HD.Items[i].SubItems[1].Text.Trim(),
                 new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(105, x));

                e.Graphics.DrawString(table_HD.Items[i].SubItems[2].Text.Trim(),
                 new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(205, x));

                e.Graphics.DrawString(table_HD.Items[i].SubItems[3].Text.Trim(),
                 new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(505, x));

                e.Graphics.DrawString(table_HD.Items[i].SubItems[4].Text.Trim(),
                 new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(605, x));

                e.Graphics.DrawString(table_HD.Items[i].SubItems[5].Text.Trim(),
                new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(705, x));

                x += 50;
                sum += float.Parse(table_HD.Items[i].SubItems[5].Text.Trim());
            }

            e.Graphics.DrawString("Tổng Tiền",
                new Font("Arial", 12, FontStyle.Regular), Brushes.Red, new Point(705, x + 100));

            e.Graphics.DrawString(sum + "VNĐ",
                new Font("Arial", 12, FontStyle.Regular), Brushes.Red, new Point(705, x + 150));
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
