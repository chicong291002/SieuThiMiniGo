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
    public partial class ChonKhuyenMai : Form
    {
        private string maKH;
        public static float ptKM;
        public static bool daApDung = false;
        public ChonKhuyenMai()
        {
            InitializeComponent();
            tableChiTietKM.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            tableCTKM.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        public object UIParent
        {
            set;
            get;
        }

        private void tableCTKM_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow dataGridViewRow = new DataGridViewRow();
            dataGridViewRow = tableCTKM.Rows[e.RowIndex];

            tableChiTietKM.DataSource = CTCTKhuyenMaiBUS.locTheoKM(dataGridViewRow.Cells[0].Value.ToString());
            maKH = dataGridViewRow.Cells[2].Value.ToString().Trim();
            ptKM = CTCTKhuyenMaiBUS.layPTKM(dataGridViewRow.Cells[0].Value.ToString());
        }

        private void ChonKhuyenMai_Load(object sender, EventArgs e)
        {
            tableCTKM.DataSource = KhuyenMaiBUS.docDSKM();
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            int i = tableCTKM.CurrentRow.Index;
            if (i >= 0)
            {
                if(BanHang.maKH_inHD.Trim().Equals("KH0") && maKH.Trim().Equals("KH0"))
                {
                    float sum = BanHang.tongTienKM;
                    sum = sum - (ptKM / 100) * sum;

                    if (UIParent is BanHang)
                    {
                        BanHang frm = UIParent as BanHang;
                        frm.apDungKM(sum);
                    }
                    MessageBox.Show("Đã áp dụng mã khuyễn mãi");
                    daApDung = true;
                }
                else if (BanHang.maKH_inHD.Trim().Equals("KH0") && maKH != "KH0")
                {
                    MessageBox.Show("Không thể áp dụng khuyến mãi này cho khách hàng vãng lai!");
                }
                else
                {
                    float sum = BanHang.tongTienKM;
                    sum = sum - (ptKM / 100) * sum;

                    if (UIParent is BanHang)
                    {
                        BanHang frm = UIParent as BanHang;
                        frm.apDungKM(sum);
                    }
                    MessageBox.Show("Đã áp dụng mã khuyễn mãi");
                    daApDung = true;
                }

                this.Visible = false;
            }
            else MessageBox.Show("Hãy chọn khuyến mãi trước khi xác nhận!");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }
    }
}