using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OfficeOpenXml.FormulaParsing.Excel.Functions.Finance.Implementations;
using SieuThiMini.DTO;

namespace SieuThiMini.DAO
{
    internal class ThongKeDAO
    {
        public static int thongKeTheoNam(int nam)
        {
            SqlConnection Conn = Connection.GetSqlConnection();
            Conn.Open();
            string query = "Select sum(TongTien) From HoaDon WHERE Year(NgayLap) = '" + nam + "'";
            SqlCommand sqlCommand = new SqlCommand(query, Conn);
            sqlCommand.Parameters.Add("@nam", SqlDbType.Int).Value = nam;
            SqlDataReader dataReader = sqlCommand.ExecuteReader();
            int kq = 0;

            if (dataReader.HasRows)
            {
                while (dataReader.Read())
                {
                    if (dataReader.IsDBNull(0).ToString() == null)
                    {
                        kq = dataReader.GetInt32(0);
                        return kq;
                    }
                    else if (dataReader.IsDBNull(0) + "" != null)
                    {
                        kq = dataReader.GetInt32(0);
                        return kq;
                    }
                }
            }
            else
            {
                return 0;
            }
            sqlCommand.ExecuteNonQuery();
            Conn.Close();
            return -1;
        }

        public List<ThongKeDTO> tongThuQuy(int nam, int thangtruoc, int thangsau)
        {
            List<ThongKeDTO> dshd = new List<ThongKeDTO>();

            SqlConnection Conn;
            SqlDataReader dataReader;
            SqlCommand sqlCommand;
            Conn = Connection.GetSqlConnection();
            Conn.Open();
            string query = "Select TongTien From HoaDon WHERE Year(NgayLap) ='" + nam + "' and Month(NgayLap) >'" + thangtruoc + "'" +
                "and Month(NgayLap) <'" + thangsau + "'";
            sqlCommand = new SqlCommand(query, Conn);
            dataReader = sqlCommand.ExecuteReader();
            if (dataReader != null)
            {
                while (dataReader.Read())
                {
                    ThongKeDTO tk = new ThongKeDTO();
                    tk.TongTien = dataReader.GetInt32(dataReader.GetOrdinal("TongTien"));
                    dshd.Add(tk);
                }
            }
            Conn.Close();
            return dshd;
        }

        public List<ThongKeDTO> tongThuThang(int nam, int thang)
        {
            List<ThongKeDTO> dshd = new List<ThongKeDTO>();

            SqlConnection Conn;
            SqlDataReader dataReader;
            SqlCommand sqlCommand;
            Conn = Connection.GetSqlConnection();
            Conn.Open();
            string query = "Select TongTien From HoaDon WHERE Year(NgayLap) ='" + nam + "' and Month(NgayLap) ='" + thang +  "'";
            sqlCommand = new SqlCommand(query, Conn);
            dataReader = sqlCommand.ExecuteReader();
            if (dataReader != null)
            {
                while (dataReader.Read())
                {
                    ThongKeDTO tk = new ThongKeDTO();
                    tk.TongTien = dataReader.GetInt32(dataReader.GetOrdinal("TongTien"));
                    dshd.Add(tk);
                }
            }
            Conn.Close();
            return dshd;
        }
    }
}
