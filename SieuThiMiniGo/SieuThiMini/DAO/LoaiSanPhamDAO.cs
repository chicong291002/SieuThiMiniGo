using SieuThiMini.DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SieuThiMini.DAO
{
    internal class LoaiSanPhamDAO
    {
        public static List<loaiSanPham> GetAllLoaiSanPhams()
        {
            List<loaiSanPham> loaiSanPhams = new List<loaiSanPham>();
            SqlConnection Conn = Connection.GetSqlConnection();
            Conn.Open();
            string query = "select * from LoaiSanPham ORDER BY MaLoai ASC";
            SqlCommand command = new SqlCommand(query, Conn);
            SqlDataReader dataReader = command.ExecuteReader();
            if (dataReader != null)
            {
                while (dataReader.Read())
                {
                    loaiSanPham tk1 = new loaiSanPham(
                        dataReader.GetString(dataReader.GetOrdinal("MaLoai")),
                        dataReader.GetString(dataReader.GetOrdinal("TenLoai"))
                        );
                    loaiSanPhams.Add(tk1);

                }
            }
            dataReader.Close();
            Conn.Close();
            return loaiSanPhams;
        }

        [Obsolete]
        public static void insert_SP(loaiSanPham lsp)
        {
            SqlConnection Conn = Connection.GetSqlConnection();
            Conn.Open();
            string query = "INSERT INTO LoaiSanPham(MaLoai,TenLoai) VALUES (@MaLoai,@TenLoai)";
            SqlCommand command = new SqlCommand(query, Conn);
            command.Parameters.Add("@MaLoai", SqlDbType.NVarChar).Value = lsp.MaLoai;
            command.Parameters.Add("@TenLoai", SqlDbType.NVarChar).Value = lsp.TenLoai;
            command.ExecuteNonQuery();
            Conn.Close();
        }

        [Obsolete]
        public static void update_sp(loaiSanPham lsp)
        {
            try
            {
                SqlConnection Conn = Connection.GetSqlConnection();
                Conn.Open();
                string query = "Update LoaiSanPham Set TenLoai = @TenLoai where MaLoai = @MaLoai";
                SqlCommand command = new SqlCommand(query, Conn);
                command.Parameters.Add("@MaLoai", SqlDbType.NVarChar).Value = lsp.MaLoai;
                command.Parameters.Add("@TenLoai", SqlDbType.NVarChar).Value = lsp.TenLoai;
                command.ExecuteNonQuery();
                Conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
        }

        public static void delete_sp(string ma)
        {
            SqlConnection Conn = Connection.GetSqlConnection();
            Conn.Open();
            string query = "delete from LoaiSanPham where MaLoai = @MaLoai";
            SqlCommand command = new SqlCommand(query, Conn);
            command.Parameters.Add("@MaLoai", SqlDbType.NVarChar).Value = ma;
            command.ExecuteNonQuery();
            Conn.Close();
        }

        public static DataTable search_sp(string tennv)
        {
            SqlConnection Conn = Connection.GetSqlConnection();
            Conn.Open();
            string query = "select * from LoaiSanPham where TenLoai like '%" + tennv + "%'";
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
