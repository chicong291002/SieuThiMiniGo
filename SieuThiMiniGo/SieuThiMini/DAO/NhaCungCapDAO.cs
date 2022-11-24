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
    internal class NhaCungCapDAO
    {
        /*
        public static DataTable getAllNhaCungCap()
        {
            SqlConnection Conn = Connection.GetSqlConnection();
            Conn.Open();
            string query = "select * from NhaCungCap ORDER BY MaNhaCungCap ASC";
            SqlCommand command = new SqlCommand(query, Conn);
            SqlDataAdapter dataAdapter = new SqlDataAdapter();
            dataAdapter.SelectCommand = command;

            DataTable dt = new DataTable();
            dataAdapter.Fill(dt);
            return dt;
        }
        */
        public static List<NhaCungCap> getAllNhaCungCap()
        {
            List<NhaCungCap> nhaCungCaps = new List<NhaCungCap>();
            SqlConnection Conn = Connection.GetSqlConnection();
            Conn.Open();
            string query = "select * from  NhaCungCap ORDER BY MaNhaCungCap ASC";
            SqlCommand command = new SqlCommand(query, Conn);
            SqlDataReader dataReader = command.ExecuteReader();
            if (dataReader != null)
            {
                while (dataReader.Read())
                {
                    NhaCungCap nhaCungCap = new NhaCungCap(
                        dataReader.GetString(dataReader.GetOrdinal("MaNhaCungCap")),
                        dataReader.GetString(dataReader.GetOrdinal("TenNhaCungCap")),
                        dataReader.GetString(dataReader.GetOrdinal("SDT")),
                        dataReader.GetString(dataReader.GetOrdinal("DiaChi")),
                        dataReader.GetString(dataReader.GetOrdinal("Email"))
                        );
                    nhaCungCaps.Add(nhaCungCap);

                }
            }
            dataReader.Close();
            Conn.Close();
            return nhaCungCaps;
        }

        public static void insertNhaCungCap(NhaCungCap nhaCungCap)
        {
            try
            {
                SqlConnection Conn = Connection.GetSqlConnection();
                Conn.Open();
                string query = "INSERT INTO NhaCungCap(MaNhaCungCap,TenNhaCungCap,SDT,DiaChi,Email) VALUES (@MaNCC,@TenNCC,@SDT,@DiaChi,@Email)";
                SqlCommand command = new SqlCommand(query, Conn);
                command.Parameters.Add("@MaNCC", SqlDbType.NVarChar).Value = nhaCungCap.MaNCC;
                command.Parameters.Add("@TenNCC", SqlDbType.NVarChar).Value = nhaCungCap.TenNCC;
                command.Parameters.Add("@SDT", SqlDbType.NVarChar).Value = nhaCungCap.Sdt;
                command.Parameters.Add("@DiaChi", SqlDbType.NVarChar).Value = nhaCungCap.DiaChi;
                command.Parameters.Add("@Email", SqlDbType.NVarChar).Value = nhaCungCap.Email;
                command.ExecuteNonQuery();
                Conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
        }

        public static void updateNhaCungCap(NhaCungCap nhaCungCap)
        {
            try
            {
                SqlConnection Conn = Connection.GetSqlConnection();
                Conn.Open();
                string query = "Update NhaCungCap Set TenNhaCungCap=@TenNhaCungCap,SDT=@SDT,DiaChi=@DiaChi,Email=@Email where MaNhaCungCap=@MaNhaCungCap";
                SqlCommand command = new SqlCommand(query, Conn);
                command.Parameters.Add("@MaNhaCungCap", SqlDbType.NVarChar).Value = nhaCungCap.MaNCC;
                command.Parameters.Add("@TenNhaCungCap", SqlDbType.NVarChar).Value = nhaCungCap.TenNCC;
                command.Parameters.Add("@SDT", SqlDbType.NVarChar).Value = nhaCungCap.Sdt;
                command.Parameters.Add("@DiaChi", SqlDbType.NVarChar).Value = nhaCungCap.DiaChi;
                command.Parameters.Add("@Email", SqlDbType.NVarChar).Value = nhaCungCap.Email;
                command.ExecuteNonQuery();
                Conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
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
