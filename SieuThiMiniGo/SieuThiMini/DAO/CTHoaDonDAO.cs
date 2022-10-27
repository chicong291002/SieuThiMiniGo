using SieuThiMini.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SieuThiMini.DAO
{
    internal class CTHoaDonDAO
    {
        public static bool flag = false;

        public static DataTable docCTHD()
        {
            SqlConnection conn = Connection.GetSqlConnection();
            conn.Open();
            string query = "select * from HoaDon";

            SqlCommand sqlCommand = new SqlCommand(query, conn);

            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);

            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            conn.Close();
            return dataTable;
        }
        public static void themCTHD(CTHoaDonDTO cthd)
        {
            try
            {
                SqlConnection conn = Connection.GetSqlConnection();
                conn.Open();
                string qry = "INSERT INTO CT_HoaDon(MaHD,MaSP,TenSP,SoLuong,DonGia,ThanhTien) VALUES (@MaHD,@MaSP,@TenSP,@SoLuong,@DonGia,@ThanhTien)";
                SqlCommand sqlCommand = new SqlCommand(qry, conn);
                sqlCommand.Parameters.Add("@MaHD", SqlDbType.NVarChar).Value = cthd.MaHD;
                sqlCommand.Parameters.Add("@MaSP", SqlDbType.NVarChar).Value = cthd.MaSP;
                sqlCommand.Parameters.Add("@TenSP", SqlDbType.NVarChar).Value = cthd.TenSP;
                sqlCommand.Parameters.Add("@SoLuong", SqlDbType.Int).Value = cthd.SoLuong;
                sqlCommand.Parameters.Add("@DonGia", SqlDbType.Float).Value = cthd.DonGia;
                sqlCommand.Parameters.Add("@ThanhTien", SqlDbType.Float).Value = cthd.Thanhtien;
                sqlCommand.ExecuteNonQuery();
                conn.Close();

                flag = true;
            }
            catch (SqlException)
            {
                flag = false;
                MessageBox.Show("Xác nhận thất bại!");
            }
        }
        public static void suaCTHD(string maSP, int soLuongCon)
        {
            SqlConnection conn = Connection.GetSqlConnection();
            conn.Open();
            string qry = "UPDATE SanPham SET SoLuong=@SoLuong where MaSP=@MaSP";
            SqlCommand sqlCommand = new SqlCommand(qry, conn);
            sqlCommand.Parameters.Add("@MaSP", SqlDbType.NVarChar).Value = maSP;
            sqlCommand.Parameters.Add("@SoLuong", SqlDbType.Int).Value = soLuongCon;

            sqlCommand.ExecuteNonQuery();

            conn.Close();
        }
    }
}
