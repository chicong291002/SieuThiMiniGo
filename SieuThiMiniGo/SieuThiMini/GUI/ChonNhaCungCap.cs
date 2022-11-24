using SieuThiMini.BUS;
using SieuThiMini.DTO;
using SieuThiMini.GUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SieuThiMini
{
    public partial class ChonNhaCungCap : Form
    {
        public static string maSP = "";
        public static string tenSP = "";

        public static string maNCC;
        public static string tenNCC;
        public static string sdt;
        public static string diaChi;
        public static string email;

        public ChonNhaCungCap()
        {
            InitializeComponent();
            tableChonNV.DataSource = NhaCungCapBUS.getAllNhaCungCap();
            tableChonNV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
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

        private void btnThem_Click(object sender, EventArgs e)
        {
            ThemNhaCungCap themNhaCungCap = new ThemNhaCungCap();
            themNhaCungCap.ShowDialog();
            tableChonNV.DataSource = NhaCungCapBUS.getAllNhaCungCap();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            int i = tableChonNV.CurrentRow.Index;
            MessageBox.Show(i + "");
            if (i < 0)
            {
                MessageBox.Show("Vui lòng chọn hàng trước khi sửa");
            }
            else
            {
                maNCC = tableChonNV.Rows[i].Cells[0].Value.ToString();
                tenNCC = tableChonNV.Rows[i].Cells[1].Value.ToString();
                sdt = tableChonNV.Rows[i].Cells[2].Value.ToString();
                diaChi = tableChonNV.Rows[i].Cells[3].Value.ToString();
                email = tableChonNV.Rows[i].Cells[4].Value.ToString();
                SuaNhaCungCap suaNhaCungCap = new SuaNhaCungCap();
                suaNhaCungCap.ShowDialog();
                tableChonNV.DataSource = NhaCungCapBUS.getAllNhaCungCap();
            }
        }

        private void tableChonNV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow data = new DataGridViewRow();
                data = tableChonNV.Rows[e.RowIndex];
                txtMaNCC.Text = data.Cells[0].Value.ToString();
                txtTenNCC.Text = data.Cells[1].Value.ToString();
                txtSDT.Text = data.Cells[2].Value.ToString();
                txtDiaChi.Text = data.Cells[3].Value.ToString();
                txtEmail.Text = data.Cells[4].Value.ToString();

            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
