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

        /*
        public static DataTable docCTHD()
        {
            SqlConnection conn = Connection.GetSqlConnection();
            conn.Open();
            string query = "select * from CT_HoaDon ORDER BY MaHD ASC";

            SqlCommand sqlCommand = new SqlCommand(query, conn);

            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);

            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            conn.Close();
            return dataTable;
        }
        */

        public static List<CTHoaDonDTO> docHD()
        {
            List<CTHoaDonDTO> cthoaDonDTOs = new List<CTHoaDonDTO>();
            SqlConnection Conn = Connection.GetSqlConnection();
            Conn.Open();
            string query = "select * from CT_HoaDon ORDER BY MaHD ASC";
            SqlCommand command = new SqlCommand(query, Conn);
            SqlDataReader dataReader = command.ExecuteReader();
            if (dataReader != null)
            {
                while (dataReader.Read())
                {
                    CTHoaDonDTO cthd = new CTHoaDonDTO();
                    cthd.MaHD = dataReader.GetString(0);
                    cthd.MaSP = dataReader.GetString(1);
                    cthd.TenSP = dataReader.GetString(2);
                    cthd.SoLuong = dataReader.GetInt32(dataReader.GetOrdinal("SoLuong"));
                    cthd.DonGia = (float)dataReader.GetDouble(dataReader.GetOrdinal("DonGia"));
                    cthd.Thanhtien = (float)dataReader.GetDouble(dataReader.GetOrdinal("ThanhTien"));
                    cthoaDonDTOs.Add(cthd);
                }
            }
            dataReader.Close();
            Conn.Close();
            return cthoaDonDTOs;
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

        public static int laySoLuongSP(string ma)
        {
            SqlConnection Conn = Connection.GetSqlConnection();
            Conn.Open();
            string query = "Select SoLuong from SanPham where MaSP ='" + ma + "'";
            SqlCommand command = new SqlCommand(query, Conn);
            command.Parameters.Add("@MaSP", SqlDbType.NVarChar).Value = ma;
            SqlDataReader reader = command.ExecuteReader();
            int kq1;
            while (reader.Read())
            {
                kq1 = reader.GetInt32(reader.GetOrdinal("SoLuong"));
                return kq1;
            }
            Conn.Close();
            return 0;
        }

        public static void suaCTHD(string maSP, int soLuongCon)
        {
            try
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
            catch (Exception)
            {
                MessageBox.Show("Sửa thất bại, vui lòng kiểm tra lại!");
                throw;
            }
        }
        public static DataTable locTheoMaHD(string maHD)
        {
            SqlConnection sqlConnection = Connection.GetSqlConnection();
            sqlConnection.Open();
            string qry = "Select * from CT_HoaDon where MaHD = '" + maHD + "'";

            SqlCommand command = new SqlCommand(qry, sqlConnection);
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = command;
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);

            sqlConnection.Close();
            return dataTable;
        }
        public static void xoaCTHD(string maHD)
        {
            SqlConnection conn = Connection.GetSqlConnection();
            conn.Open();
            string qry = "DELETE FROM CT_HoaDon where MaHD=@MaHD";
            SqlCommand sqlCommand = new SqlCommand(qry, conn);
            sqlCommand.Parameters.Add("@MaHD", SqlDbType.NVarChar).Value = maHD;
            sqlCommand.ExecuteNonQuery();
            conn.Close();
        }
        public static DataTable timCTHD(string tuKhoa)
        {
            SqlConnection conn = Connection.GetSqlConnection();
            conn.Open();
            string qry = "select * from CT_HoaDon where MaHD like '%" + tuKhoa + "%' or MaSP like '%" + tuKhoa + "%' or TenSP like '%" + tuKhoa + "%' or SoLuong like '%" + tuKhoa + "%' or DonGia like '%" + tuKhoa + "%' or ThanhTien like '%" + tuKhoa + "%'";
            SqlCommand command = new SqlCommand(qry, conn);

            SqlDataAdapter dataAdapter = new SqlDataAdapter();
            dataAdapter.SelectCommand = command;
            DataTable dt = new DataTable();
            dataAdapter.Fill(dt);
            conn.Close();
            return dt;
        }

    }
}
