using Microsoft.ReportingServices.DataProcessing;
using SieuThiMini.BUS;
using SieuThiMini.DTO;
using SieuThiMini.GUI;
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
    internal class TaiKhoanDAO
    {
        /*
        public static DataTable getAllTaiKhoan()
        {
            SqlConnection conn = Connection.GetSqlConnection();
            conn.Open();
            string query = "select * from TaiKhoan ORDER BY MaTK ASC";

            SqlCommand sqlCommand = new SqlCommand(query, conn);

            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);

            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            conn.Close();
            return dataTable;
        }
        */

        public static List<TaiKhoan> getAllTaiKhoan()
        {
            List<TaiKhoan> taiKhoans = new List<TaiKhoan>();
            SqlConnection Conn = Connection.GetSqlConnection();
            Conn.Open();
            string query = "select * from TaiKhoan ORDER BY MaTK ASC";
            SqlCommand command = new SqlCommand(query, Conn);
            SqlDataReader dataReader = command.ExecuteReader();
            if (dataReader != null)
            {
                while (dataReader.Read())
                {
                    TaiKhoan tk1 = new TaiKhoan(
                        dataReader.GetString(dataReader.GetOrdinal("MaTK")),
                        dataReader.GetString(dataReader.GetOrdinal("TenTK")),
                        dataReader.GetString(dataReader.GetOrdinal("MatKhau")), 
                        dataReader.GetString(dataReader.GetOrdinal("Email")),
                        dataReader.GetString(dataReader.GetOrdinal("MaNV")),
                        dataReader.GetString(dataReader.GetOrdinal("PhanQuyen")),
                        dataReader.GetString(dataReader.GetOrdinal("TrangThai"))
                        );
                    taiKhoans.Add(tk1);

                }
            }
            dataReader.Close();
            Conn.Close();
            return taiKhoans;
        }

        /*
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
        */

        public static string quyen;

        public static string DangNhap(string usr, string pass)
        {
            try
            {
                SqlConnection Conn = Connection.GetSqlConnection();
                Conn.Open();
                string query = "Select MaNV,PhanQuyen from TaiKhoan where TenTK='" + usr + "' and MatKhau='" + pass + "' and TrangThai='true'";
                SqlCommand command = new SqlCommand(query, Conn);
                SqlDataReader reader = command.ExecuteReader();

                string kq1;
                while (reader.Read())
                {
                    kq1 = reader.GetString(reader.GetOrdinal("MaNV"));
                    quyen = reader.GetString(reader.GetOrdinal("PhanQuyen"));
                    return kq1;
                }
                Conn.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Lỗi kết nối");
            }
            return "";
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
            try
            {
                SqlConnection Conn = Connection.GetSqlConnection();
                Conn.Open();
                string query = "INSERT INTO TaiKhoan(MaTK,TenTK,MatKhau,Email,MaNV," +
                    "PhanQuyen,TrangThai) VALUES (@MaTK,@TenTK,@MatKhau,@Email,@MaNV,@PhanQuyen,@TrangThai)";
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
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

        public static void deleteTaikhoanNV(string ma)
        {
            SqlConnection Conn = Connection.GetSqlConnection();
            Conn.Open();
            string query = "Delete from TaiKhoan where MaNV=@MaNV";
            SqlCommand command = new SqlCommand(query, Conn);
            command.Parameters.Add("@MaNV", SqlDbType.NVarChar).Value = ma;

            command.ExecuteNonQuery();
            Conn.Close();
        }

        public static DataTable searchnv(string tuKhoa)
        {
            SqlConnection Conn = Connection.GetSqlConnection();
            Conn.Open();
            string query = "select * from TaiKhoan where MaTK like '%" + tuKhoa + "%' or TenTK like '%" + tuKhoa + "%'" +
                "or Email like '%" + tuKhoa + "%' or MatKhau like '%" + tuKhoa + "%'";
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
