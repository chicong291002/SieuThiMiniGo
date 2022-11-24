using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SieuThiMini.DTO;
using System.Data.Common;

namespace SieuThiMini.DAO
{
    internal class NhanVienDAO
    {
        public static DataTable laytoanboNhanVien()
        {
            SqlConnection Conn = Connection.GetSqlConnection();
            Conn.Open();

            string query = "select * from NhanVien ORDER BY MaNV ASC";

            SqlCommand command = new SqlCommand(query, Conn);
            SqlDataAdapter dataAdapter = new SqlDataAdapter();
            dataAdapter.SelectCommand = command;
            DataTable dt = new DataTable();
            dataAdapter.Fill(dt);
            Conn.Close();
            return dt;
        }


        public static List<NhanVien> getAllNhanVien()
        {
            List<NhanVien> nhanViens = new List<NhanVien>();
            SqlConnection Conn = Connection.GetSqlConnection();
            Conn.Open();
            string query = "select * from NhanVien ORDER BY MaNV ASC";
            SqlCommand command = new SqlCommand(query, Conn);
            SqlDataReader dataReader = command.ExecuteReader();
            if (dataReader != null)
            {
                while (dataReader.Read())
                {
                    NhanVien nv1 = new NhanVien(
                        dataReader.GetString(dataReader.GetOrdinal("MaNV")),
                        dataReader.GetString(dataReader.GetOrdinal("HoNV")),
                        dataReader.GetString(dataReader.GetOrdinal("TenNV")),
                        dataReader.GetString(dataReader.GetOrdinal("SDT")),
                        dataReader.GetString(dataReader.GetOrdinal("CMND")),
                        dataReader.GetString(dataReader.GetOrdinal("Email")),
                        dataReader.GetDateTime(dataReader.GetOrdinal("NgaySinh")),
                        dataReader.GetString(dataReader.GetOrdinal("GioiTinh")),
                        dataReader.GetString(dataReader.GetOrdinal("Luong")),
                        dataReader.GetString(dataReader.GetOrdinal("ViTri")),
                        dataReader.GetDateTime(dataReader.GetOrdinal("NgayVaoLam"))
                        );
                    nhanViens.Add(nv1);

                }
            }
            dataReader.Close();
            Conn.Close();
            return nhanViens;
        }


        [Obsolete]
        public static void insertnv(NhanVien nv)
        {
            SqlConnection Conn = Connection.GetSqlConnection();
            Conn.Open();
            string query = "INSERT INTO NhanVien(Manv,Honv,Tennv,Cmnd," +
                "Sdt,Email,NgaySinh,GioiTinh,Luong,ViTri,NgayVaoLam) VALUES (@Manv,@Honv,@Tennv,@Cmnd,@Sdt,@Email,@NgaySinh,@GioiTinh,@Luong,@ViTri,@NgayVaoLam)";

            SqlCommand command = new SqlCommand(query, Conn);
            command.Parameters.Add("@Manv", SqlDbType.NVarChar).Value = nv.MaNV;
            command.Parameters.Add("@Honv", SqlDbType.NVarChar).Value = nv.HoNV;
            command.Parameters.Add("@Tennv", SqlDbType.NVarChar).Value = nv.TenNV;
            command.Parameters.Add("@Cmnd", SqlDbType.NVarChar).Value = nv.CMND;
            command.Parameters.Add("@Sdt", SqlDbType.NVarChar).Value = nv.SDT;
            command.Parameters.Add("@Email", SqlDbType.NVarChar).Value = nv.Email;
            command.Parameters.Add("@NgaySinh", SqlDbType.NVarChar).Value = nv.NgaySinh;
            command.Parameters.Add("@GioiTinh", SqlDbType.NVarChar).Value = nv.GioiTinh;
            command.Parameters.Add("@Luong", SqlDbType.NVarChar).Value = nv.Luong;
            command.Parameters.Add("@ViTri", SqlDbType.NVarChar).Value = nv.ViTri;
            command.Parameters.Add("@NgayVaoLam", SqlDbType.NVarChar).Value = nv.NgayVaoLam;

            command.ExecuteNonQuery();
            Conn.Close();
        }

        [Obsolete]
        public static void updatenv(NhanVien nv)
        {
            SqlConnection Conn = Connection.GetSqlConnection();
            Conn.Open();
            string query = "Update NhanVien Set Honv = @Honv,Tennv=@Tennv,Cmnd = @Cmnd," +
                "Sdt = @Sdt,Email = @Email,NgaySinh = @NgaySinh,GioiTinh = @GioiTinh,Luong = @Luong,ViTri = @ViTri,NgayVaoLam = @NgayVaoLam where Manv = @Manv";
            
            SqlCommand command = new SqlCommand(query, Conn);

            command.Parameters.Add("@Manv", SqlDbType.NVarChar).Value = nv.MaNV;
            command.Parameters.Add("@Honv", SqlDbType.NVarChar).Value = nv.HoNV;
            command.Parameters.Add("@Tennv", SqlDbType.NVarChar).Value = nv.TenNV;
            command.Parameters.Add("@Cmnd", SqlDbType.NVarChar).Value = nv.CMND;
            command.Parameters.Add("@Sdt", SqlDbType.NVarChar).Value = nv.SDT;
            command.Parameters.Add("@Email", SqlDbType.NVarChar).Value = nv.Email;
            command.Parameters.Add("@NgaySinh", SqlDbType.NVarChar).Value = nv.NgaySinh;
            command.Parameters.Add("@GioiTinh", SqlDbType.NVarChar).Value = nv.GioiTinh;
            command.Parameters.Add("@Luong", SqlDbType.NVarChar).Value = nv.Luong;
            command.Parameters.Add("@ViTri", SqlDbType.NVarChar).Value = nv.ViTri;
            command.Parameters.Add("@NgayVaoLam", SqlDbType.NVarChar).Value = nv.NgayVaoLam;

            command.ExecuteNonQuery();
            Conn.Close();
        }

        public static void deletenv(string ma)
        {
            SqlConnection Conn = Connection.GetSqlConnection();
            Conn.Open();
           
            string query = "delete from NhanVien where Manv = @Manv";
            SqlCommand command = new SqlCommand(query, Conn);
            command.Parameters.Add("@Manv", SqlDbType.NVarChar).Value = ma;
            command.ExecuteNonQuery();
            Conn.Close();
        }
        
        public static DataTable searchnv(string tuKhoa)
        {
            SqlConnection Conn = Connection.GetSqlConnection();
            Conn.Open();
            string query = "select * from NhanVien where MaNV like '%" + tuKhoa + "%' or HoNV like '%" + tuKhoa + "%'" +
                "or Email like '%" + tuKhoa + "%' or CMND like '%" + tuKhoa + "%'";      
            SqlCommand command = new SqlCommand(query, Conn);
            SqlDataAdapter dataAdapter = new SqlDataAdapter();  
            dataAdapter.SelectCommand = command;
            DataTable dt = new DataTable();
            dataAdapter.Fill(dt);
            Conn.Close();
            return dt;
        }
    }
}
