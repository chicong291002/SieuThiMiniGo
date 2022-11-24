using SieuThiMini.DTO;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SieuThiMini.DAO
{
    internal class HoaDonDAO
    {
        public static bool flag = false;

        
        public static DataTable docHD()
        {
            SqlConnection conn = Connection.GetSqlConnection();
            conn.Open();
            string query = "select * from HoaDon ORDER BY MaHD ASC";

            SqlCommand sqlCommand = new SqlCommand(query, conn);    

            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);

            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable); 
            conn.Close();
            return dataTable;
        }
        
        /*
        public static List<HoaDonDTO> docHD()
        {
            List<HoaDonDTO> hoaDonDTOs = new List<HoaDonDTO>();
            SqlConnection Conn = Connection.GetSqlConnection();
            Conn.Open();
            string query = "select * from HoaDon ORDER BY MaHD ASC";
            SqlCommand command = new SqlCommand(query, Conn);
            SqlDataReader dataReader = command.ExecuteReader();
            if (dataReader != null)
            {
                while (dataReader.Read())
                {
                    HoaDonDTO hd = new HoaDonDTO(
                        dataReader.GetString(dataReader.GetOrdinal("MaHD")),
                        dataReader.GetString(dataReader.GetOrdinal("MaNV")),
                        dataReader.GetString(dataReader.GetOrdinal("MaKH")),
                        dataReader.GetString(dataReader.GetOrdinal("NgayLap")),
                        dataReader.GetString(dataReader.GetOrdinal("TongTien"))
                        );
                    hoaDonDTOs.Add(hd);

                }
            }
            dataReader.Close();
            Conn.Close();
            return hoaDonDTOs;
        }
        */
        public static void themHD(HoaDonDTO hd)
        {
            try
            {
                SqlConnection conn = Connection.GetSqlConnection();
                conn.Open();
                string qry = "INSERT INTO HoaDon(MaHD,MaNV,MaKH,NgayLap,TongTien) VALUES (@MaHD,@MaNV,@MaKH,@NgayLap,@TongTien)";
                SqlCommand sqlCommand = new SqlCommand(qry, conn);
                sqlCommand.Parameters.Add("@MaHD", SqlDbType.NVarChar).Value = hd.Invoice_id;
                sqlCommand.Parameters.Add("@MaNV", SqlDbType.NVarChar).Value = hd.Employee_id;
                sqlCommand.Parameters.Add("@MaKH", SqlDbType.NVarChar).Value = hd.Customer_id;
                sqlCommand.Parameters.Add("@NgayLap", SqlDbType.DateTime).Value = hd.DateFounded;
                sqlCommand.Parameters.Add("@TongTien", SqlDbType.Float).Value = hd.TotalMoney;

                sqlCommand.ExecuteNonQuery();
                conn.Close();

                flag = true;
            }
            catch (SqlException ex)
            {
                flag = false;
                MessageBox.Show("Thêm hóa đơn thất bại!"+ex.Message);
            }
        }

        public static void suaHD(HoaDonDTO hd)
        {
            SqlConnection conn = Connection.GetSqlConnection();
            conn.Open();
            string qry = "UPDATE HoaDon SET MaNV=@MaNV,MaKH=@MaKH,NgayLap=@NgayLap,TongTien=@TongTien where MaHD=@MaHD";
            SqlCommand sqlCommand = new SqlCommand(qry, conn);
            sqlCommand.Parameters.Add("@MaHD", SqlDbType.NVarChar).Value = hd.Invoice_id;
            sqlCommand.Parameters.Add("@MaNV", SqlDbType.NVarChar).Value = hd.Employee_id;
            sqlCommand.Parameters.Add("@MaKH", SqlDbType.NVarChar).Value = hd.Customer_id;
            sqlCommand.Parameters.Add("@NgayLap", SqlDbType.DateTime).Value = hd.DateFounded;
            sqlCommand.Parameters.Add("@TongTien", SqlDbType.Float).Value = hd.TotalMoney;

            sqlCommand.ExecuteNonQuery();

            conn.Close();
        }
        public static void xoaHD(string maHD)
        {
            SqlConnection conn = Connection.GetSqlConnection();
            conn.Open();
            string qry = "DELETE FROM HoaDon where MaHD=@MaHD";
            SqlCommand sqlCommand = new SqlCommand(qry, conn);
            sqlCommand.Parameters.Add("@MaHD", SqlDbType.NVarChar).Value = maHD;
            sqlCommand.ExecuteNonQuery();
            conn.Close();
        }

        public static DataTable timHD(string tuKhoa)
        {
            SqlConnection conn = Connection.GetSqlConnection();
            conn.Open();
            string qry = "select * from HoaDon where MaHD like '%" + tuKhoa + "%' or MaNV like '%" + tuKhoa + "%' or MaKH like '%"+tuKhoa + "%' or NgayLap like '%" + tuKhoa + "%' or TongTien like '%" + tuKhoa + "%'";
            SqlCommand command = new SqlCommand(qry, conn);


            SqlDataAdapter dataAdapter = new SqlDataAdapter();
            dataAdapter.SelectCommand = command;
            DataTable dt = new DataTable();
            dataAdapter.Fill(dt);
            conn.Close();
            return dt;
        }

        public static void xoaKH(string maKH)
        {
            SqlConnection conn = Connection.GetSqlConnection();
            conn.Open();
            string qry = "DELETE FROM HoaDon where MaKH=@MaKH";
            SqlCommand sqlCommand = new SqlCommand(qry, conn);
            sqlCommand.Parameters.Add("@MaHD", SqlDbType.NVarChar).Value = maKH;
            sqlCommand.ExecuteNonQuery();
            conn.Close();
        }
    }
}
