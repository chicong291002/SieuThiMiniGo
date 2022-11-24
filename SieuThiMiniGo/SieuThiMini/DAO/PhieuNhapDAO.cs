using Microsoft.Office.Interop.Excel;
using SieuThiMini.DTO;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataTable = System.Data.DataTable;

namespace SieuThiMini.DAO
{
    internal class PhieuNhapDAO
    {
        public static DataTable layToanBoPhieuNhap()
        {
            SqlConnection Conn = Connection.GetSqlConnection();
            Conn.Open();
            List<PhieuNhapHang> dspn = new List<PhieuNhapHang>();
            string query = "select * from PhieuNhapHang ORDER BY MaPhieu ASC";
            SqlCommand command = new SqlCommand(query, Conn);
            SqlDataAdapter dataAdapter = new SqlDataAdapter();
            dataAdapter.SelectCommand = command;
            DataTable dt = new DataTable();
            dataAdapter.Fill(dt);
            Conn.Close();
            return dt;
        }


        [Obsolete]
        public static void insert_PN(PhieuNhapHang pnh)
        {
            SqlConnection Conn = Connection.GetSqlConnection();
            Conn.Open();
            string query = "INSERT INTO PhieuNhapHang(MaNV,MaNhaCungCap,NgayLap,TongTien) VALUES (@MaNV,@MaNhaCungCap,@NgayLap,@TongTien)";
            SqlCommand command = new SqlCommand(query, Conn);
            command.Parameters.Add("@MaNV", SqlDbType.NVarChar).Value = pnh.MaNV;
            command.Parameters.Add("@MaNhaCungCap", SqlDbType.NVarChar).Value = pnh.MaNCC;
            command.Parameters.Add("@NgayLap", SqlDbType.Date).Value = pnh.NgayLap;
            command.Parameters.Add("@TongTien", SqlDbType.Float).Value = pnh.TongTien;
            command.ExecuteNonQuery();
            Conn.Close();
        }

        public int getLastID()
        {
            try
            {
                SqlConnection Conn = Connection.GetSqlConnection();
                Conn.Open();
                String query = "SELECT TOP 1 MaPhieu FROM PhieuNhapHang ORDER BY MaPhieu DESC";
                SqlCommand command = new SqlCommand(query, Conn);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    return reader.GetInt32(reader.GetOrdinal("MaPhieu"));
                }

            }
            catch (Exception)
            {
                throw;
            }
            return -1;
        }


    }
}
