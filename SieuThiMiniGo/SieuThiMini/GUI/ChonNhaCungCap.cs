using SieuThiMini.BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SieuThiMini
{
    public partial class ChonNhaCungCap : Form
    {
        public static string maSP = "";
        public static string tenSP = "";
        public ChonNhaCungCap()
        {
            InitializeComponent();
            tableChonNV.DataSource = NhaCungCapBUS.getAllNhaCungCap();
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
                    maSP = tableChonNV.Rows[i].Cells[0].Value.ToString();
                    maSP = maSP.Trim();
                    tenSP = tableChonNV.Rows[i].Cells[1].Value.ToString();
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
