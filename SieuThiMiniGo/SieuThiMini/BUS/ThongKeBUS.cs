using SieuThiMini.DAO;
using SieuThiMini.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SieuThiMini.BUS
{
    internal class ThongKeBUS
    {
        public static List<ThongKeDTO> dstk;
        public static List<ThongKeDTO> dstk1;
        public static int thongKeTheoNam(string nam)
        {
            int year = int.Parse(nam);
            return ThongKeDAO.thongKeTheoNam(year);
        }

        public static void getTongDoanhChiQuy(int nam, int thangtruoc, int thangsau)
        {
            ThongKeDAO data = new ThongKeDAO();
            if (dstk == null)
                dstk = new List<ThongKeDTO>();
            dstk = data.tongThuQuy(nam,thangtruoc, thangsau);
        }

        public static void getTongThuThang(int nam, int thang)
        {
            ThongKeDAO data = new ThongKeDAO();
            if (dstk1 == null)
                dstk1 = new List<ThongKeDTO>();
            dstk1 = data.tongThuThang(nam, thang);
        }
    }
}
