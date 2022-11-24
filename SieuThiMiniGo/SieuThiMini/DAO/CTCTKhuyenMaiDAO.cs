using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SieuThiMini.DTO;

namespace SieuThiMini.DAO
{
    internal class CTCTKhuyenMaiDAO
    {
        /*
        public static DataTable getAllCT_ChuongTrinhKhuyenMai()
        {
            SqlConnection Conn = Connection.GetSqlConnection();
            Conn.Open();

            string query = "select * from CT_ChuongTrinhKhuyenMai";
            SqlCommand command = new SqlCommand(query, Conn);
            SqlDataAdapter dataAdapter = new SqlDataAdapter();
            dataAdapter.SelectCommand = command;

            DataTable dt = new DataTable();
            dataAdapter.Fill(dt);
            return dt;
        }
        */

        public static List<CTCTKhuyenMaiDTO> getAllChiTiet()
        {
            List<CTCTKhuyenMaiDTO> cTCTKhuyenMaiDTOs = new List<CTCTKhuyenMaiDTO>();
            SqlConnection Conn = Connection.GetSqlConnection();
            Conn.Open();
            string query = "select * from CT_ChuongTrinhKhuyenMai ORDER BY MaChuongTrinh ASC";
            SqlCommand command = new SqlCommand(query, Conn);
            SqlDataReader dataReader = command.ExecuteReader();
            if (dataReader != null)
            {
                while (dataReader.Read())
                {
                    CTCTKhuyenMaiDTO ctct = new CTCTKhuyenMaiDTO(
                        dataReader.GetString(dataReader.GetOrdinal("MaChuongTrinh")),
                        dataReader.GetString(dataReader.GetOrdinal("PhanTramKhuyenMai")));
                    cTCTKhuyenMaiDTOs.Add(ctct);
                }
            }
            dataReader.Close();
            Conn.Close();
            return cTCTKhuyenMaiDTOs;
        }
        public static void insertCT_CTKM(CTCTKhuyenMaiDTO ct_ctkm)
        {
            SqlConnection Conn = Connection.GetSqlConnection();
            Conn.Open();
            string query = "INSERT INTO CT_ChuongTrinhKhuyenMai(MaChuongTrinh,PhanTramKhuyenMai)"
                + " VALUES (@MaChuongTrinh,@PhanTramKhuyenMai)";
            SqlCommand command = new SqlCommand(query, Conn);
            command.Parameters.Add("@MaChuongTrinh", SqlDbType.NVarChar).Value = ct_ctkm.MaCT;
            command.Parameters.Add("@PhanTramKhuyenMai", SqlDbType.NVarChar).Value = ct_ctkm.PtKM;

            command.ExecuteNonQuery();
            Conn.Close();
        }

        public static void updateCT_CTKM(CTCTKhuyenMaiDTO ct_ctkm)
        {
            SqlConnection Conn = Connection.GetSqlConnection();
            Conn.Open();
            string query = "Update CT_ChuongTrinhKhuyenMai Set PhanTramKhuyenMai = @PhanTramKhuyenMai " +
                "where MaChuongTrinh = @MaChuongTrinh";
            SqlCommand command = new SqlCommand(query, Conn);
            command.Parameters.Add("@MaChuongTrinh", SqlDbType.NVarChar).Value = ct_ctkm.MaCT;
            command.Parameters.Add("@PhanTramKhuyenMai", SqlDbType.NVarChar).Value = ct_ctkm.PtKM;

            command.ExecuteNonQuery();
            Conn.Close();
        }

        public static void deleteCT_CTKM(string ma)
        {
            SqlConnection Conn = Connection.GetSqlConnection();
            Conn.Open();
            string query = "delete from CT_ChuongTrinhKhuyenMai where MaChuongTrinh=@MaChuongTrinh";
            SqlCommand command = new SqlCommand(query, Conn);
            command.Parameters.Add("@MaChuongTrinh", SqlDbType.NVarChar).Value = ma;
            command.ExecuteNonQuery();
            Conn.Close();
        }

        public static DataTable locTheoCTKM(string maKM)
        {
            SqlConnection sqlConnection = Connection.GetSqlConnection();
            sqlConnection.Open();
            string qry = "Select * from CT_ChuongTrinhKhuyenMai where MaChuongTrinh = '" + maKM + "'";

            SqlCommand command = new SqlCommand(qry, sqlConnection);
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = command;
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);

            sqlConnection.Close();
            return dataTable;
        }

        public static int layPTKM(string maKM)
        {
            SqlConnection Conn = Connection.GetSqlConnection();
            Conn.Open();
            string query = "Select PhanTramKhuyenMai from CT_ChuongTrinhKhuyenMai where MaChuongTrinh ='" + maKM + "'";
            SqlCommand command = new SqlCommand(query, Conn);
            command.Parameters.Add("@MaChuongTrinh", SqlDbType.NVarChar).Value = maKM;
            SqlDataReader reader = command.ExecuteReader();
            int kq1;

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    kq1 = int.Parse(reader.GetString(reader.GetOrdinal("PhanTramKhuyenMai")));
                    return kq1;
                }
            }

            Conn.Close();
            return 0;
        }

        public static DataTable getMaKH(string maKM)
        {
            SqlConnection Conn = Connection.GetSqlConnection();
            Conn.Open();
            string query = "select * from CT_ChuongTrinhKhuyenMai where MaChuongTrinh=@MaChuongTrinh";

            SqlCommand command = new SqlCommand(query, Conn);
            command.Parameters.Add("@MaChuongTrinh", SqlDbType.NVarChar).Value = maKM;
            SqlDataAdapter dataAdapter = new SqlDataAdapter();
            dataAdapter.SelectCommand = command;
            DataTable dt = new DataTable();
            dataAdapter.Fill(dt);
            Conn.Close();
            return dt;
        }
    }
}
