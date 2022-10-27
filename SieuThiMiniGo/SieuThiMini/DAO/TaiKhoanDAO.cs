using SieuThiMini.DTO;
using SieuThiMini.GUI;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SieuThiMini.DAO
{
    internal class TaiKhoanDAO
    {
        public static DataTable getAllTaiKhoan()
        {
            SqlConnection Conn = Connection.GetSqlConnection();
            Conn.Open();
            string query = "select * from TaiKhoan";
            SqlCommand command = new SqlCommand(query, Conn);
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            sqlDataAdapter.SelectCommand = command;

            DataTable dt = new DataTable();
            sqlDataAdapter.Fill(dt);
            Conn.Close();
            return dt;
        }

        public static List<TaiKhoan> loginAccount(string tk, string mk)
        {

            List<TaiKhoan> taiKhoans = new List<TaiKhoan>();
            SqlConnection Conn = Connection.GetSqlConnection();
            Conn.Open();
            string query = "select * from TaiKhoan where TenTK='" + tk + "'and MatKhau='" + mk + "'";
            SqlCommand command = new SqlCommand(query, Conn);
            SqlDataReader dataReader = command.ExecuteReader();
            if (dataReader != null)
            {
                while (dataReader.Read())
                {
                    TaiKhoan tk1 = new TaiKhoan(dataReader.GetString(1), dataReader.GetString(2));
                    taiKhoans.Add(tk1);

                }
            }
            dataReader.Close();
            dataReader.Dispose();
            Conn.Close();
            return taiKhoans;
        }

        public static string checkPassWord(string email)
        {
            SqlConnection Conn = Connection.GetSqlConnection();
            Conn.Open();
            string query = "select MatKhau from TaiKhoan where Email='" + email + "'";
            SqlCommand command = new SqlCommand(query, Conn);
            SqlDataReader dataReader = command.ExecuteReader();
            if (dataReader != null)
            {
                while (dataReader.Read())
                {
                      return dataReader.GetString(dataReader.GetOrdinal("MatKhau"));
                }
            }
            dataReader.Close();
            Conn.Close();
            return "Sai Email";
        }

        public static void insertTaiKhoan(TaiKhoan tk)
        {
            SqlConnection Conn = Connection.GetSqlConnection();
            Conn.Open();
            string query = "INSERT INTO TaiKhoan(MaTK,TenTK,MatKhau,Email,MaNV," +
                "PhanQuyen,TrangThai) VALUES (@MaTK,@TenTK,@MatKhau,@Email,@MaNV,@PhanQuyen,@TrangThai)";
            SqlCommand command = new SqlCommand(query, Conn);
            command.Parameters.Add("@MaTK", SqlDbType.NVarChar).Value = tk.MaTK;
            command.Parameters.Add("@TenTK", SqlDbType.NVarChar).Value = tk.TenTK;
            command.Parameters.Add("@MatKhau", SqlDbType.NVarChar).Value = tk.MatKhau;
            command.Parameters.Add("@MaNV", SqlDbType.NVarChar).Value = tk.MaNV;
            command.Parameters.Add("@Email", SqlDbType.NVarChar).Value = tk.Email;
            command.Parameters.Add("@PhanQuyen", SqlDbType.NVarChar).Value = tk.PhanQuyen;
            command.Parameters.Add("@TrangThai", SqlDbType.NVarChar).Value = tk.TrangThai;
            command.ExecuteNonQuery();
            Conn.Close();
        }

        public static void updateTaiKhoan(TaiKhoan tk)
        {
            SqlConnection Conn = Connection.GetSqlConnection();
            Conn.Open();
            string query = "Update TaiKhoan Set TenTK = @TenTK,MatKhau=@MatKhau,Email=@Email," +
                "MaNV = @MaNV,PhanQuyen = @PhanQuyen,TrangThai = @TrangThai where MaTK = @MaTK";
            SqlCommand command = new SqlCommand(query, Conn);
            command.Parameters.Add("@MaTK", SqlDbType.NVarChar).Value = tk.MaTK;
            command.Parameters.Add("@TenTK", SqlDbType.NVarChar).Value = tk.TenTK;
            command.Parameters.Add("@MatKhau", SqlDbType.NVarChar).Value = tk.MatKhau;
            command.Parameters.Add("@Email", SqlDbType.NVarChar).Value = tk.Email;
            command.Parameters.Add("@MaNV", SqlDbType.NVarChar).Value = tk.MaNV;
            command.Parameters.Add("@PhanQuyen", SqlDbType.NVarChar).Value = tk.PhanQuyen;
            command.Parameters.Add("@TrangThai", SqlDbType.NVarChar).Value = tk.TrangThai;
            command.ExecuteNonQuery();
            Conn.Close();
        }

        public static void deleteTaikhoan(string ma)
        {
            SqlConnection Conn = Connection.GetSqlConnection();
            Conn.Open();
            string query = "Delete from TaiKhoan where MaTK=@MaTK";
            SqlCommand command = new SqlCommand(query, Conn);
            command.Parameters.Add("@MaTK", SqlDbType.NVarChar).Value = ma;

            command.ExecuteNonQuery();
            Conn.Close();
        }
        
    }
}
