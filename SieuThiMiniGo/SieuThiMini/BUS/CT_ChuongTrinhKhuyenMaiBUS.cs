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
    internal class CT_ChuongTrinhKhuyenMaiBUS
    {
        public static DataTable getAllCT_ChuongTrinhKhuyenMai()
        {
            return CT_ChuongTrinhKhuyenMaiDAO.getAllCT_ChuongTrinhKhuyenMai();
        }

        [Obsolete]
        public static void insertCT_ChuongTrinhKhuyenMai(CTChuongTrinhKhuyenMai ct_ctkm)
        {
            CT_ChuongTrinhKhuyenMaiDAO.insertCT_CTKM(ct_ctkm);
        }

        [Obsolete]
        public static void updateCT_ChuongTrinhKhuyenMai(CTChuongTrinhKhuyenMai ct_ctkm)
        {
            CT_ChuongTrinhKhuyenMaiDAO.updateCT_CTKM(ct_ctkm);
        }

        public static void deleteCT_ChuongTrinhKhuyenMai(string ma)
        {
            CT_ChuongTrinhKhuyenMaiDAO.deleteCT_CTKM(ma);
        }

        
    }
}
