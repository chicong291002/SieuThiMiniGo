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
    public partial class ChonKhachHang : Form
    {
        public static string maKH = "";
        public ChonKhachHang()
        {
            InitializeComponent();
            tableChonKH.DataSource = KhachHangBUS.docDSKH();
            tableChonKH.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void btnChonKH_Click(object sender, EventArgs e)
        {
            int i;
            if (tableChonKH.Rows.Count < 0)
            {
                MessageBox.Show("Không có dữ liệu cút");
            }

            else
            {
                i = tableChonKH.CurrentRow.Index;
                if (i >= 0)
                {
                    maKH = tableChonKH.Rows[i].Cells[0].Value.ToString().Trim();
                    this.Visible = false;
                }
                else
                {
                    MessageBox.Show("Chưa chọn hàng");
                }
            }
        }

        private void tableChonKH_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
