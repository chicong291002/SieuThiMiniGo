using SieuThiMini.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SieuThiMini.DAO
{
    internal class NhaCungCapDAO
    {       
        public static DataTable getAllNhaCungCap()
        {
            SqlConnection Conn = Connection.GetSqlConnection();
            Conn.Open();
            string query = "select * from NhaCungCap";
            SqlCommand command = new SqlCommand(query, Conn);
            SqlDataAdapter dataAdapter = new SqlDataAdapter();
            dataAdapter.SelectCommand = command;

            DataTable dt = new DataTable();
            dataAdapter.Fill(dt);
            return dt;
        }

        public static void insertNhaCungCap(NhaCungCap nhaCungCap)
        {
            SqlConnection Conn = Connection.GetSqlConnection();
            Conn.Open();
            string query = "INSERT INTO NhaCungCap(MaNhaCungCap,TenNhaCungCap,SDT,DiaChi,Email)" +
                " VALUES (@MaNhaCungCap,@TenNhaCungCap,@SDT,@DiaChi,@Email)";
            SqlCommand command = new SqlCommand(query, Conn);
            command.Parameters.Add("@MaNhaCungCap", SqlDbType.NVarChar).Value = nhaCungCap.MaNCC;
            command.Parameters.Add("@TenNhaCungCap", SqlDbType.NVarChar).Value = nhaCungCap.TenNCC;
            command.Parameters.Add("@SDT", SqlDbType.NVarChar).Value = nhaCungCap.Sdt;
            command.Parameters.Add("@DiaChi", SqlDbType.NVarChar).Value = nhaCungCap.DiaChi;
            command.Parameters.Add("@Email", SqlDbType.NVarChar).Value = nhaCungCap.Email;
            command.ExecuteNonQuery();
            Conn.Close();
        }

        public static void updateNhaCungCap(NhaCungCap nhaCungCap)
        {
            SqlConnection Conn = Connection.GetSqlConnection();
            Conn.Open();
            string query = "Update NhaCungCap Set TenNCC = @TenNCC,SDT=@SDT,@DiaChi=@DiaChi,Email=@Email" +
                " where MaNCC = @MaNCC";
            SqlCommand command = new SqlCommand(query, Conn);
            command.Parameters.Add("@MaNhaCungCap", SqlDbType.NVarChar).Value = nhaCungCap.MaNCC;
            command.Parameters.Add("@TenNhaCungCap", SqlDbType.NVarChar).Value = nhaCungCap.TenNCC;
            command.Parameters.Add("@SDT", SqlDbType.NVarChar).Value = nhaCungCap.Sdt;
            command.Parameters.Add("@DiaChi", SqlDbType.NVarChar).Value = nhaCungCap.DiaChi;
            command.Parameters.Add("@Email", SqlDbType.NVarChar).Value = nhaCungCap.Email;
            command.ExecuteNonQuery();
            Conn.Close();
        }

        public static void deleteNhaCungCap(string ma)
        {
            SqlConnection Conn = Connection.GetSqlConnection();
            Conn.Open();
            string query = "delete from NhaCungCap where MaNCC=@MaNCC";
            SqlCommand command = new SqlCommand(query, Conn);
            command.ExecuteNonQuery();
            Conn.Close();
        }

        public static DataTable seachNCC(string tuKhoa)
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
