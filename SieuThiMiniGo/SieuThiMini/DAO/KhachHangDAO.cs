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
    internal class KhachHangDAO
    {
        public static DataTable docDSKH()
        {
            SqlConnection conn = Connection.GetSqlConnection();
            conn.Open();
            string query = "select * from KhachHang ORDER BY MaKH ASC";

            SqlCommand sqlCommand = new SqlCommand(query, conn);

            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);

            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            conn.Close();
            return dataTable;
        }
        public static void themKH(KhachHangDTO kh)
        {
            try
            {
                SqlConnection conn = Connection.GetSqlConnection();
                conn.Open();
                string qry = "INSERT INTO KhachHang(MaKH,HoKH,TenKH,SDT,CMND,NgaySinh,GioiTinh) VALUES (@MaKH,@HoKH,@TenKH,@SDT,@CMND,@NgaySinh,@GioiTinh)";
                SqlCommand sqlCommand = new SqlCommand(qry, conn);
                sqlCommand.Parameters.Add("@MaKH", SqlDbType.NVarChar).Value = kh.MaKH1;
                sqlCommand.Parameters.Add("@HoKH", SqlDbType.NVarChar).Value = kh.HoKH1;
                sqlCommand.Parameters.Add("@TenKH", SqlDbType.NVarChar).Value = kh.TenKH1;
                sqlCommand.Parameters.Add("@SDT", SqlDbType.NVarChar).Value = kh.SoDT1;
                sqlCommand.Parameters.Add("@CMND", SqlDbType.NVarChar).Value = kh.CMND1;
                sqlCommand.Parameters.Add("@NgaySinh", SqlDbType.DateTime).Value = kh.Ngaysinh1;
                sqlCommand.Parameters.Add("@GioiTinh", SqlDbType.NVarChar).Value = kh.GioiTinh1;

                sqlCommand.ExecuteNonQuery();
               
                conn.Close();

            }
            catch (SqlException)
            {
                MessageBox.Show("Thêm Khách Hàng thất bại!");
            }
        }
        public static void suaKH(KhachHangDTO kh)
        {
            SqlConnection conn = Connection.GetSqlConnection();
            conn.Open();
            string qry = "UPDATE KhachHang SET HoKH=@HoKH,TenKH=@TenKH,SDT=@SDT,CMND=@CMND,NgaySinh=@NgaySinh,GioiTinh=@GioiTinh where MaKH=@MaKH";
            SqlCommand sqlCommand = new SqlCommand(qry, conn);
            sqlCommand.Parameters.Add("@MaKH", SqlDbType.NVarChar).Value = kh.MaKH1;
            sqlCommand.Parameters.Add("@HoKH", SqlDbType.NVarChar).Value = kh.HoKH1;
            sqlCommand.Parameters.Add("@TenKH", SqlDbType.NVarChar).Value = kh.TenKH1;
            sqlCommand.Parameters.Add("@SDT", SqlDbType.NVarChar).Value = kh.SoDT1;
            sqlCommand.Parameters.Add("@CMND", SqlDbType.NVarChar).Value = kh.CMND1;
            sqlCommand.Parameters.Add("@NgaySinh", SqlDbType.Date).Value = kh.Ngaysinh1;
            sqlCommand.Parameters.Add("@GioiTinh", SqlDbType.NVarChar).Value = kh.GioiTinh1;

            sqlCommand.ExecuteNonQuery();

            conn.Close();
        }
        public static void xoaKH(string maKH)
        {
            SqlConnection conn = Connection.GetSqlConnection();
            conn.Open();
            string qry = "DELETE FROM KhachHang where MaKH=@MaKH";
            SqlCommand sqlCommand = new SqlCommand(qry, conn);
            sqlCommand.Parameters.Add("@MaKH", SqlDbType.NVarChar).Value = maKH;
            sqlCommand.ExecuteNonQuery();
            conn.Close();
        }

        public static DataTable timKH(string tuKhoa)
        {
            SqlConnection conn = Connection.GetSqlConnection();
            conn.Open();
            string qry = "select * from KhachHang where MaKH like '%" + tuKhoa + "%' or HoKH like '%" + tuKhoa + "%' or TenKH like '%" + tuKhoa + "%' or SDT like '%" + tuKhoa + "%' or CMND like '%" + tuKhoa + "%' or NgaySinh like '%"+ tuKhoa+ "%' or GioiTinh like '%" + tuKhoa + "%'";
            SqlCommand command = new SqlCommand(qry, conn);


            SqlDataAdapter dataAdapter = new SqlDataAdapter();
            dataAdapter.SelectCommand = command;
            DataTable dt = new DataTable();
            dataAdapter.Fill(dt);
            conn.Close();
            return dt;
        }
    }
}
