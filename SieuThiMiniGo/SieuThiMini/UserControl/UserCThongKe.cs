using SieuThiMini.BUS;
using SieuThiMini.DAO;
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
using System.Windows.Forms.DataVisualization.Charting;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SieuThiMini.GUI
{
    public partial class UserCThongKe : UserControl
    {
        private string[] quy_Thu;
        private string[] thang_Thu;
        public static int tongquy;
        //private string[] thang_Chi;
       // rbThang_CheckedChanged(sender, e);

        public UserCThongKe()
        {
            InitializeComponent();
        }

        private void UserCThongKe_Load(object sender, EventArgs e)
        {

        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        public static void doctkquy(int nam,int thangtruoc, int thangsau)
        {
            tongquy = 0;
            string tongtien;
            ThongKeBUS.getTongDoanhChiQuy(nam,thangtruoc, thangsau);
            foreach (ThongKeDTO tk in ThongKeBUS.dstk)
            {
                tongtien = tk.TongTien + "";
                tongquy += int.Parse(tongtien);
            }
        }

        public static void doctkthang(int nam, int thang)
        {
            tongquy = 0;
            string tongtien;
            ThongKeBUS.getTongThuThang(nam, thang);
            foreach (ThongKeDTO tk in ThongKeBUS.dstk1)
            {
                tongtien = tk.TongTien + "";
                tongquy += int.Parse(tongtien);
            }
        }

        public void loadQuy(int nam)
        {
            doctkquy(nam,0, 4);
            txtQuy1.Text = tongquy.ToString();
            doctkquy(nam, 3, 7);
            txtQuy2.Text = tongquy.ToString();
            doctkquy(nam, 6, 10);
            txtQuy3.Text = tongquy.ToString();
            doctkquy(nam, 9, 12);
            txtQuy4.Text = tongquy.ToString();
        }

        public void loadThang(int nam)
        {
            doctkthang(nam, 1);
            txt1.Text = tongquy.ToString();
            doctkthang(nam, 2);
            txt2.Text = tongquy.ToString();
            doctkthang(nam, 3);
            txt3.Text = tongquy.ToString();
            doctkthang(nam, 4);
            txt4.Text = tongquy.ToString();
            doctkthang(nam, 5);
            txt5.Text = tongquy.ToString();
            doctkthang(nam, 6);
            txt6.Text = tongquy.ToString();
            doctkthang(nam, 7);
            txt7.Text = tongquy.ToString();
            doctkthang(nam, 8);
            txt8.Text = tongquy.ToString();
            doctkthang(nam, 9);
            txt9.Text = tongquy.ToString();
            doctkthang(nam, 10);
            txt10.Text = tongquy.ToString();
            doctkthang(nam, 11);
            txt11.Text = tongquy.ToString();
            doctkthang(nam, 12);
            txt12.Text = tongquy.ToString();
        }

        private void rbThang_CheckedChanged(object sender, EventArgs e)
        {
           

            loadThang(int.Parse(cbNam.SelectedItem + ""));

            
            chart1.Series["Money"].Points.Clear();
            chart1.Series["Money"].Points.AddXY("1", txt1.Text);
            chart1.Series["Money"].Points.AddXY("2", txt2.Text);
            chart1.Series["Money"].Points.AddXY("3", txt3.Text);
            chart1.Series["Money"].Points.AddXY("4", txt4.Text);
            chart1.Series["Money"].Points.AddXY("5", txt5.Text);
            chart1.Series["Money"].Points.AddXY("6", txt6.Text);
            chart1.Series["Money"].Points.AddXY("7", txt7.Text);
            chart1.Series["Money"].Points.AddXY("8", txt8.Text);
            chart1.Series["Money"].Points.AddXY("9", txt9.Text);
            chart1.Series["Money"].Points.AddXY("10", txt10.Text);
            chart1.Series["Money"].Points.AddXY("11", txt11.Text);
            chart1.Series["Money"].Points.AddXY("12", txt12.Text);
            

        }

        private void rbQuy_CheckedChanged(object sender, EventArgs e)
        {
            loadQuy(int.Parse(cbNam.SelectedItem + ""));
            chart1.Series["Money"].Points.Clear();
            chart1.Series["Money"].Points.AddXY("Quý 1", txtQuy1.Text);
            chart1.Series["Money"].Points.AddXY("Quý 2", txtQuy2.Text);
            chart1.Series["Money"].Points.AddXY("Quý 3", txtQuy3.Text);
            chart1.Series["Money"].Points.AddXY("Quý 4", txtQuy4.Text);
        }

        private void cbNam_SelectedIndexChanged(object sender, EventArgs e)
        {
            int kq = ThongKeBUS.thongKeTheoNam(cbNam.SelectedItem + "");
            txtTongThu.Text = kq.ToString();
        }

    }
}
