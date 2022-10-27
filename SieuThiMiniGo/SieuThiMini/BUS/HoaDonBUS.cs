using SieuThiMini.DAO;
using SieuThiMini.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SieuThiMini.BUS
{
    internal class HoaDonBUS
    {
        public static DataTable docDSHoaDon()
        {
            return HoaDonDAO.layToanBoHoaDon();
        }

        public static void themHD(HoaDonDTO hd)
        {
            HoaDonDAO.themHD(hd);
        }
        public static void suaHD(HoaDonDTO hd)
        {
            HoaDonDAO.suaHD(hd);
        }
        public static void xoaHD(string maHD)
        {
            HoaDonDAO.xoaHD(maHD);
        }
        public static DataTable timHD(string tuKhoa)
        {
            return HoaDonDAO.timHD(tuKhoa);
        } 
    }
}
