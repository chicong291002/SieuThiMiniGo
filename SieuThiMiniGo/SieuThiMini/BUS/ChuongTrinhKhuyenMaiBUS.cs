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
    internal class ChuongTrinhKhuyenMaiBUS
    {
        public static DataTable getAllChuongTrinhKhuyenMai()
        {
            return ChuongTrinhKhuyenMaiDAO.getAllChuongTrinhKhuyenMai();
        }

        [Obsolete]
        public static void insertChuongTrinhKhuyenMai(ChuongTrinhKhuyenMai ctkm)
        {
            ChuongTrinhKhuyenMaiDAO.insertCTKM(ctkm);
        }

        [Obsolete]
        public static void updateChuongTrinhKhuyenMai(ChuongTrinhKhuyenMai ctkm)
        {
            ChuongTrinhKhuyenMaiDAO.updateCTKM(ctkm);
        }

        public static void deleteChuongTrinhKhuyenMai(string ma)
        {
            ChuongTrinhKhuyenMaiDAO.deleteCTKM(ma);
        }
    }
}
