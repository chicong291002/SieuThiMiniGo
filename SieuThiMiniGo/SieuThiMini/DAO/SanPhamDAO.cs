using SieuThiMini.DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Xml;
using SieuThiMini.BUS;


namespace SieuThiMini.DAO
{
    internal class SanPhamDAO
    {
        
        public static DataTable laytoanboSanPham()
        {
            SqlConnection Conn = Connection.GetSqlConnection();
            Conn.Open();
            string query = "select * from SanPham ORDER BY MaSP ASC";
            SqlCommand command = new SqlCommand(query, Conn);
            SqlDataAdapter dataAdapter = new SqlDataAdapter();
            dataAdapter.SelectCommand = command;

            DataTable dt = new DataTable();
            dataAdapter.Fill(dt);
            return dt;
        }
        
       

        [Obsolete]
        public static void insert_SP(SanPham sp)
        {
            SqlConnection Conn = Connection.GetSqlConnection();
            Conn.Open();
            string query = "INSERT INTO SanPham(MaSP,TenSP,DonGia,DonViTinh," +
                "SoLuong,MaLoai,MaNhaCungCap,Image) VALUES (@MaSP,@TenSP,@DonGia,@DonViTinh,@SoLuong,@MaLoai,@MaNhaCungCap,@Image)";
            SqlCommand command = new SqlCommand(query, Conn);
            command.Parameters.Add("@MaSP", SqlDbType.NVarChar).Value = sp.MaSP;
            command.Parameters.Add("@TenSP", SqlDbType.NVarChar).Value = sp.TenSP;
            command.Parameters.Add("@DonGia", SqlDbType.NVarChar).Value = sp.DonGia;
            command.Parameters.Add("@DonViTinh", SqlDbType.NVarChar).Value = sp.DonViTinh;
            command.Parameters.Add("@SoLuong", SqlDbType.NVarChar).Value = sp.SoLuong;
            command.Parameters.Add("@MaLoai", SqlDbType.NVarChar).Value = sp.MaLoai;
            command.Parameters.Add("@MaNhaCungCap", SqlDbType.NVarChar).Value = sp.MaNCC;
            command.Parameters.Add("@Image", SqlDbType.Image).Value = sp.Anh;

            command.ExecuteNonQuery();
            Conn.Close();
        }

        public static int laySoLuong(string ma)
        {
            SqlConnection Conn = Connection.GetSqlConnection();
            Conn.Open();
            string query = "Select SoLuong from SanPham where MaSP ='" + ma + "'";
            SqlCommand command = new SqlCommand(query, Conn);
            command.Parameters.Add("@MaSP", SqlDbType.NVarChar).Value = ma;
            SqlDataReader reader = command.ExecuteReader();
            int kq1;
            while (reader.Read())
            {
                kq1 = reader.GetInt32(reader.GetOrdinal("SoLuong"));
                return kq1;
            }
            Conn.Close();
            return 1;
        }

        [Obsolete]
        public static void update_sp(SanPham sp)
        {
            SqlConnection Conn = Connection.GetSqlConnection();
            Conn.Open();
            string query = "Update SanPham Set  TenSP = @TenSP,DonGia=@DonGia,DonViTinh = @DonViTinh," +
                "SoLuong = @SoLuong,MaLoai = @MaLoai,MaNhaCungCap = @MaNhaCungCap,Image = @Image where MaSP = @MaSP";
            SqlCommand command = new SqlCommand(query, Conn);
            command.Parameters.Add("@MaSP", SqlDbType.NVarChar).Value = sp.MaSP;
            command.Parameters.Add("@TenSP", SqlDbType.NVarChar).Value = sp.TenSP;
            command.Parameters.Add("@DonGia", SqlDbType.NVarChar).Value = sp.DonGia;
            command.Parameters.Add("@DonViTinh", SqlDbType.NVarChar).Value = sp.DonViTinh;
            command.Parameters.Add("@SoLuong", SqlDbType.NVarChar).Value = sp.SoLuong;
            command.Parameters.Add("@MaLoai", SqlDbType.NVarChar).Value = sp.MaLoai;
            command.Parameters.Add("@MaNhaCungCap", SqlDbType.NVarChar).Value = sp.MaNCC;
            command.Parameters.Add("@Image", SqlDbType.Image).Value = sp.Anh;
            command.ExecuteNonQuery();
            Conn.Close();
        }

        public static void delete_sp(string ma)
        {
            SqlConnection Conn = Connection.GetSqlConnection();
            Conn.Open();
            string query = "delete from SanPham where MaSP = @MaSP";
            SqlCommand command = new SqlCommand(query, Conn);
            command.Parameters.Add("@MaSP", SqlDbType.NVarChar).Value = ma;
            command.ExecuteNonQuery();
            Conn.Close();
        }

        public static DataTable search_sp(string tuKhoa)
        {
            SqlConnection Conn = Connection.GetSqlConnection();
            Conn.Open();
            string query = "select * from SanPham where MaSP like '%" + tuKhoa + "%' or TenSP like '%"
                + tuKhoa + "%' or DonGia like '%" + tuKhoa + "%' or DonViTinh like '%" + tuKhoa + "%' or MaNhaCungCap like '%" + tuKhoa + "%'";
            SqlCommand command = new SqlCommand(query, Conn);
            SqlDataAdapter dataAdapter = new SqlDataAdapter();
            dataAdapter.SelectCommand = command;
            DataTable dt = new DataTable();
            dataAdapter.Fill(dt);
            Conn.Close();
            return dt;
        }

        public static DataTable locSPTheoLoai(string maLoai)
        {
            SqlConnection sqlConnection = Connection.GetSqlConnection();
            sqlConnection.Open();
            string qry = "Select * from SanPham where MaLoai = '" + maLoai + "'";

            SqlCommand command = new SqlCommand(qry, sqlConnection);
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = command;
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);

            sqlConnection.Close();
            return dataTable;
        }

        public static DataTable locSPTheoGia(float gia1,float gia2)
        {
            SqlConnection sqlConnection = Connection.GetSqlConnection();
            sqlConnection.Open();
            String query = "SELECT * from SanPham where DonGia >= " + gia1 + " and DonGia <= " + gia2 + "";

            SqlCommand command = new SqlCommand(query, sqlConnection);
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = command;
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);

            sqlConnection.Close();
            return dataTable;
        }

        public static DataTable timNhanhSPTheoLoai(string tuKhoa, string maLoai)
        {
            SqlConnection sqlConnection = Connection.GetSqlConnection();
            string qry = "select * from SanPham where  MaLoai='" + maLoai + "' and (MaSP like '%" + tuKhoa + "%' or TenSP like '%" + tuKhoa + "%' or DonGia like '%" + tuKhoa + "%' or DonViTinh like '%" + tuKhoa + "%' or SoLuong like '%" + tuKhoa + "%' or MaNhaCungCap like '%" + tuKhoa + "%')";
            sqlConnection.Open();

            SqlCommand sqlCommand = new SqlCommand(qry, sqlConnection);
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            sqlDataAdapter.SelectCommand = sqlCommand;
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            sqlConnection.Close();
            return dataTable;
        }


    }
}
