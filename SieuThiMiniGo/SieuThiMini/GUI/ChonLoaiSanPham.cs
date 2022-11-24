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
    public partial class ChonLoaiSanPham : Form
    {
        public static string maLoaiSP = "";
        public ChonLoaiSanPham()
        {
            InitializeComponent();
            tableChonLoaiSP.DataSource = LoaiSanPhamBUS.getAllSanPham();
            tableChonLoaiSP.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void btnChonLoaiSP_Click(object sender, EventArgs e)
        {
            int i;
            if (tableChonLoaiSP.Rows.Count < 0)
            {
                MessageBox.Show("Không có dữ liệu cút");
            }

            else
            {
                i = tableChonLoaiSP.CurrentRow.Index;
                if (i >= 0)
                {
                    maLoaiSP = tableChonLoaiSP.Rows[i].Cells[0].Value.ToString().Trim();
                    this.Visible = false;
                }
                else
                {
                    MessageBox.Show("Chưa chọn hàng");
                }
            }
        }
    }
}
