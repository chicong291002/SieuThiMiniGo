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
    public partial class ChonNhanVien : Form
    {
        public static string maNCC = "";
        public ChonNhanVien()
        {
            InitializeComponent();
            tableChonNV.DataSource = NhanVienBUS.GetAllNhanVien();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            //Application.Exit();
        }

        private void btnChonNV_Click(object sender, EventArgs e)
        {
            int i;
            if (tableChonNV.Rows.Count < 0)
            {
                MessageBox.Show("Không có dữ liệu cút");
            }

            else
            {
                i = tableChonNV.CurrentRow.Index;
                if (i >= 0)
                {
                    maNCC = tableChonNV.Rows[i].Cells[0].Value.ToString().Trim();
                    this.Visible = false;
                }
                else
                {
                    MessageBox.Show("Chưa chọn hàng");
                }
            }

        }

        private void tableChonNV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
