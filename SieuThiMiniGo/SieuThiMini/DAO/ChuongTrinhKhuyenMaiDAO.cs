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
    internal class ChuongTrinhKhuyenMaiDAO
    {
        public static DataTable getAllChuongTrinhKhuyenMai()
        {
            SqlConnection Conn = Connection.GetSqlConnection();
            Conn.Open();

            string query = "select * from ChuongTrinhKhuyenMai";
            SqlCommand command = new SqlCommand(query, Conn);
            SqlDataAdapter dataAdapter = new SqlDataAdapter();
            dataAdapter.SelectCommand = command;

            DataTable dt = new DataTable();
            dataAdapter.Fill(dt);
            return dt;
        }

        public static void insertCTKM(ChuongTrinhKhuyenMai ctkm)
        {
            SqlConnection Conn = Connection.GetSqlConnection();
            Conn.Open();
            string query = "INSERT INTO ChuongTrinhKhuyenMai(MaChuongTrinh,TenChuongTrinh,NgayBatDau,NgayKetThuc)"
                + " VALUES (@MaChuongTrinh,@TenChuongTrinh,@NgayBatDau,@NgayKetThuc)";
            SqlCommand command = new SqlCommand(query, Conn);
            command.Parameters.Add("@MaChuongTrinh", SqlDbType.NVarChar).Value = ctkm.MaChuongTrinh;
            command.Parameters.Add("@TenChuongTrinh", SqlDbType.NVarChar).Value = ctkm.TenChuongTrinh;
            command.Parameters.Add("@NgayBatDau", SqlDbType.NVarChar).Value = ctkm.NgayBatDau;
            command.Parameters.Add("@NgayKetThuc", SqlDbType.NVarChar).Value = ctkm.NgayKetThuc;

            command.ExecuteNonQuery();
            Conn.Close();
        }

        public static void updateCTKM(ChuongTrinhKhuyenMai ctkm)
        {
            SqlConnection Conn = Connection.GetSqlConnection();
            Conn.Open();
            string query = "Update ChuongTrinhKhuyenMai Set TenChuongTrinh = @TenChuongTrinh," +
                "NgayBatDau=@NgayBatDau,@NgayKetThuc=@NgayKetThuc" +
                " where MaChuongTrinh = @MaChuongTrinh";
            SqlCommand command = new SqlCommand(query, Conn);
            command.Parameters.Add("@MaChuongTrinh", SqlDbType.NVarChar).Value = ctkm.MaChuongTrinh;
            command.Parameters.Add("@TenChuongTrinh", SqlDbType.NVarChar).Value = ctkm.TenChuongTrinh;
            command.Parameters.Add("@NgayBatDau", SqlDbType.NVarChar).Value = ctkm.NgayBatDau;
            command.Parameters.Add("@NgayKetThuc", SqlDbType.NVarChar).Value = ctkm.NgayKetThuc;
            command.ExecuteNonQuery();
            Conn.Close();
        }

        public static void deleteCTKM(string ma)
        {
            SqlConnection Conn = Connection.GetSqlConnection();
            Conn.Open();
            string query = "delete from ChuongTrinhKhuyenMai where MaChuongTrinh=@MaChuongTrinh";
            SqlCommand command = new SqlCommand(query, Conn);
            command.ExecuteNonQuery();
            Conn.Close();
        }
    }
}
