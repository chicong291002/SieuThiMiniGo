using SieuThiMini.DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace SieuThiMini.DAO
{
    internal class CTPhieuNhapDAO
    {
        /*
        public static DataTable layToanBoPhieuNhap()
        {
            SqlConnection Conn = Connection.GetSqlConnection();
            Conn.Open();

            string query = "select * from CT_PhieuNhapHang ORDER BY MaPhieu ASC";
            SqlCommand command = new SqlCommand(query, Conn);
            SqlDataAdapter dataAdapter = new SqlDataAdapter();
            dataAdapter.SelectCommand = command;
            DataTable dt = new DataTable();
            dataAdapter.Fill(dt);
            Conn.Close();
            return dt;
        }
        */

        public static List<CTPhieuNhapHang> layToanBoPhieuNhap()
        {
            List<CTPhieuNhapHang> cTPhieuNhapHangs = new List<CTPhieuNhapHang>();
            SqlConnection Conn = Connection.GetSqlConnection();
            Conn.Open();
            string query = "select * from CT_PhieuNhapHang ORDER BY MaPhieu ASC";
            SqlCommand command = new SqlCommand(query, Conn);
            SqlDataReader dataReader = command.ExecuteReader();
            if (dataReader != null)
            {
                while (dataReader.Read())
                {
                    CTPhieuNhapHang ctpnh = new CTPhieuNhapHang();
                    ctpnh.MaPhieu = dataReader.GetInt32(dataReader.GetOrdinal("MaPhieu"));
                    ctpnh.MaSP = dataReader.GetString(1);
                    ctpnh.SoLuong = dataReader.GetInt32(dataReader.GetOrdinal("SoLuong"));
                    ctpnh.DonGia = (float)dataReader.GetDouble(dataReader.GetOrdinal("DonGia"));
                    ctpnh.ThanhTien = (float)dataReader.GetDouble(dataReader.GetOrdinal("ThanhTien"));
                    cTPhieuNhapHangs.Add(ctpnh);
                }
            }
            dataReader.Close();
            Conn.Close();
            return cTPhieuNhapHangs;
        }

        public static DataTable getPhieuNhap(string MaPN)
        {
            SqlConnection Conn = Connection.GetSqlConnection();
            Conn.Open();
            string query = "select * from CT_PhieuNhapHang where MaPhieu='" + MaPN + "'";
            SqlCommand command = new SqlCommand(query, Conn);
            SqlDataAdapter dataAdapter = new SqlDataAdapter();
            dataAdapter.SelectCommand = command;
            DataTable dt = new DataTable();
            dataAdapter.Fill(dt);
            Conn.Close();
            return dt;
        }

        public static void insert_CTPN(CTPhieuNhapHang ctpn)
        {
            SqlConnection Conn = Connection.GetSqlConnection();
            Conn.Open();
            string query = "INSERT INTO CT_PhieuNhapHang(MaSP,SoLuong,DonGia,ThanhTien) VALUES (@MaSP,@SoLuong,@DonGia,@ThanhTien)";
            SqlCommand command = new SqlCommand(query, Conn);
            command.Parameters.Add("@MaSP", SqlDbType.NVarChar).Value = ctpn.MaSP;
            command.Parameters.Add("@SoLuong", SqlDbType.Int).Value = ctpn.SoLuong;
            command.Parameters.Add("@DonGia", SqlDbType.Float).Value = ctpn.DonGia;
            command.Parameters.Add("@ThanhTien", SqlDbType.Float).Value = ctpn.ThanhTien;
            command.ExecuteNonQuery();
            Conn.Close();
        }

        public static void addCTPhieuNhap(CTPhieuNhapHang ctpn)
        {

            SqlConnection Conn = Connection.GetSqlConnection();
            Conn.Open();

            
            // Phải Update số lượng SP trong kho
            String query = "UPDATE SanPham SET SoLuong += '" + ctpn.SoLuong + "' WHERE MaSP = '" + ctpn.MaSP + "'";
            SqlCommand command = new SqlCommand(query, Conn);
            command.Parameters.Add("@SoLuong", SqlDbType.Int).Value = ctpn.SoLuong;
            command.Parameters.Add("@MaSP", SqlDbType.NVarChar).Value = ctpn.MaSP;
            command.ExecuteNonQuery();
            

            String sql = "INSERT INTO CT_PhieuNhapHang(MaPhieu,MaSP,SoLuong,DonGia,ThanhTien) VALUES(@MaPhieu,@MaSP,@SoLuong,@DonGia,@ThanhTien)";
            SqlCommand server = new SqlCommand(sql, Conn);
            server.Parameters.Add("@MaPhieu", SqlDbType.Int).Value = ctpn.MaPhieu;
            server.Parameters.Add("@MaSP", SqlDbType.NVarChar).Value = ctpn.MaSP;
            server.Parameters.Add("@SoLuong", SqlDbType.Int).Value = ctpn.SoLuong;
            server.Parameters.Add("@DonGia", SqlDbType.Float).Value = ctpn.DonGia;
            server.Parameters.Add("@ThanhTien", SqlDbType.Float).Value = ctpn.ThanhTien;

            server.ExecuteNonQuery();
        }
    }
}
