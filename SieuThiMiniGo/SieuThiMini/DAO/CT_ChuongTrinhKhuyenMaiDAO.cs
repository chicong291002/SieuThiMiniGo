using SieuThiMini.DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SieuThiMini.DAO
{
    internal class CT_ChuongTrinhKhuyenMaiDAO
    {
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

        public static void insertCT_CTKM(CTChuongTrinhKhuyenMai ct_ctkm)
        {
            SqlConnection Conn = Connection.GetSqlConnection();
            Conn.Open();
            string query = "INSERT INTO CT_ChuongTrinhKhuyenMai(MaChuongTrinh,PhanTramGiamGia)"
                + " VALUES (@MaChuongTrinh,@PhanTramGiamGia)";
            SqlCommand command = new SqlCommand(query, Conn);
            command.Parameters.Add("@MaChuongTrinh", SqlDbType.NVarChar).Value = ct_ctkm.MaChuongTrinh;
            command.Parameters.Add("@PhanTramGiamGia", SqlDbType.NVarChar).Value = ct_ctkm.PhanTramGiamGia;
           
            command.ExecuteNonQuery();
            Conn.Close();
        }

        public static void updateCT_CTKM(CTChuongTrinhKhuyenMai ct_ctkm)
        {
            SqlConnection Conn = Connection.GetSqlConnection();
            Conn.Open();
            string query = "Update CT_ChuongTrinhKhuyenMai Set PhanTramGiamGia = @PhanTramGiamGia " +
                "where MaChuongTrinh = @MaChuongTrinh";
            SqlCommand command = new SqlCommand(query, Conn);
            command.Parameters.Add("@MaChuongTrinh", SqlDbType.NVarChar).Value = ct_ctkm.MaChuongTrinh;
            command.Parameters.Add("@PhanTramGiamGia", SqlDbType.NVarChar).Value = ct_ctkm.PhanTramGiamGia;

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
    }
}
