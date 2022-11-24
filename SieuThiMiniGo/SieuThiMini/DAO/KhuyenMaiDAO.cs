using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SieuThiMini.DTO;
using System.Windows.Forms;

namespace SieuThiMini.DAO
{
    internal class KhuyenMaiDAO
    {
        public static DataTable docDSKM()
        {
            SqlConnection conn = Connection.GetSqlConnection();
            conn.Open();
            string query = "select * from ChuongTrinhKhuyenMai ORDER BY MaChuongTrinh ASC";

            SqlCommand sqlCommand = new SqlCommand(query, conn);

            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);

            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            conn.Close();
            return dataTable;
        }

        public static void insertCTKM(KhuyenMaiDTO ctkm)
        {
            try
            {
                SqlConnection Conn = Connection.GetSqlConnection();
                Conn.Open();
                string query = "INSERT INTO ChuongTrinhKhuyenMai(MaChuongTrinh,TenChuongTrinh,MaKH,NgayBatDau,NgayKetThuc)"
                    + " VALUES (@MaChuongTrinh,@TenChuongTrinh,@MaKH,@NgayBatDau,@NgayKetThuc)";
                SqlCommand command = new SqlCommand(query, Conn);
                command.Parameters.Add("@MaChuongTrinh", SqlDbType.NVarChar).Value = ctkm.MaCT;
                command.Parameters.Add("@TenChuongTrinh", SqlDbType.NVarChar).Value = ctkm.TenCT;
                command.Parameters.Add("@MaKH", SqlDbType.NVarChar).Value = ctkm.MaKH;
                command.Parameters.Add("@NgayBatDau", SqlDbType.NVarChar).Value = ctkm.NgayBatDau;
                command.Parameters.Add("@NgayKetThuc", SqlDbType.NVarChar).Value = ctkm.NgayKetThuc;

                command.ExecuteNonQuery();
                Conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
        }

        public static void updateCTKM(KhuyenMaiDTO ctkm)
        {
            SqlConnection Conn = Connection.GetSqlConnection();
            Conn.Open();
            string query = "Update ChuongTrinhKhuyenMai Set TenChuongTrinh = @TenChuongTrinh," +
                "MaKH = @MaKH,NgayBatDau=@NgayBatDau,@NgayKetThuc=@NgayKetThuc" +
                " where MaChuongTrinh = @MaChuongTrinh";
            SqlCommand command = new SqlCommand(query, Conn);
            command.Parameters.Add("@MaChuongTrinh", SqlDbType.NVarChar).Value = ctkm.MaCT;
            command.Parameters.Add("@TenChuongTrinh", SqlDbType.NVarChar).Value = ctkm.TenCT;
            command.Parameters.Add("@MaKH", SqlDbType.NVarChar).Value = ctkm.MaKH;
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
            command.Parameters.Add("@MaChuongTrinh", SqlDbType.NVarChar).Value = ma;
            int x = command.ExecuteNonQuery();
            Conn.Close();
        }
    }
}
