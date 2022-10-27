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
        public static DataTable docCTHD()
        {
            return CTHoaDonDAO.docCTHD();
        }
        public static void themCTHD(CTHoaDonDTO cthd)
        {
            CTHoaDonDAO.themCTHD(cthd);
        }
        public static void suaSLSP(string maSP, int soLuongCon)
        {
            CTHoaDonDAO.suaCTHD(maSP, soLuongCon);  
        }
    }
}
