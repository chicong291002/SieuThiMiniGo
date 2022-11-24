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
    internal class KhachHangBUS
    {
        public static DataTable docDSKH()
        {
            return KhachHangDAO.docDSKH();
        }
        public static void themKH(KhachHangDTO kh)
        {
            KhachHangDAO.themKH(kh);
        }
        public static void suaKH(KhachHangDTO kh)
        {
            KhachHangDAO.suaKH(kh);
        }
        public static void xoaKH(string maKH)
        {
            KhachHangDAO.xoaKH(maKH);
        }
        public static DataTable timHD(string tuKhoa)
        {
            return KhachHangDAO.timKH(tuKhoa);
        }
    }
}
