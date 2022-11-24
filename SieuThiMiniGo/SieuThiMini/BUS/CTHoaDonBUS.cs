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
    internal class CTHoaDonBUS
    {
        public static List<CTHoaDonDTO> docCTHD()
        {
            return CTHoaDonDAO.docHD();
        }
        public static void themCTHD(CTHoaDonDTO cthd)
        {
            CTHoaDonDAO.themCTHD(cthd);
        }

        public static int laySLSP_old(string maSP)
        {
            return CTHoaDonDAO.laySoLuongSP(maSP);
        }
        public static void suaSLSP(string maSP, int soLuongCon)
        {
            CTHoaDonDAO.suaCTHD(maSP, soLuongCon);  
        }

        public static void xoaCTHD(string maHD)
        {
            CTHoaDonDAO.xoaCTHD(maHD);
        }
        public static DataTable locTheoHD(string maHD)
        {
            return CTHoaDonDAO.locTheoMaHD(maHD);
        }
        public static DataTable timCTHD(string tuKhoa)
        {
            return CTHoaDonDAO.timCTHD(tuKhoa);
        }
    }
}
