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
    internal class LoaiSanPhamDAO
    {
        public static DataTable laytoanboSanPham()
        {
            SqlConnection Conn = Connection.GetSqlConnection();
            Conn.Open();
            string query = "select * from LoaiSanPham";
            SqlCommand command = new SqlCommand(query, Conn);
            SqlDataAdapter dataAdapter = new SqlDataAdapter();
            dataAdapter.SelectCommand = command;
            DataTable dt = new DataTable();
            dataAdapter.Fill(dt);
            Conn.Close();
            return dt;
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
            SqlConnection Conn = Connection.GetSqlConnection();
            Conn.Open();
            string query = "Update SanPham Set TenLoai = @TenLoai where MaLoai = @MaLoai";
            SqlCommand command = new SqlCommand(query, Conn);
            command.Parameters.Add("@MaLoai", SqlDbType.NVarChar).Value = lsp.MaLoai;
            command.Parameters.Add("@TenLoai", SqlDbType.NVarChar).Value = lsp.TenLoai;
            command.ExecuteNonQuery();
            Conn.Close();
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
