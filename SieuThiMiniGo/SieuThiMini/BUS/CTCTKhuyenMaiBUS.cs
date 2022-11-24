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
    internal class CTCTKhuyenMaiBUS
    {
        public static List<CTCTKhuyenMaiDTO> getAllCT_ChuongTrinhKhuyenMai()
        {
            return CTCTKhuyenMaiDAO.getAllChiTiet();
        }

        [Obsolete]
        public static void insertCT_ChuongTrinhKhuyenMai(CTCTKhuyenMaiDTO ct_ctkm)
        {
            CTCTKhuyenMaiDAO.insertCT_CTKM(ct_ctkm);
        }

        [Obsolete]
        public static void updateCT_ChuongTrinhKhuyenMai(CTCTKhuyenMaiDTO ct_ctkm)
        {
            CTCTKhuyenMaiDAO.updateCT_CTKM(ct_ctkm);
        }

        public static void deleteCT_ChuongTrinhKhuyenMai(string ma)
        {
            CTCTKhuyenMaiDAO.deleteCT_CTKM(ma);
        }
        public static DataTable locTheoKM(string maKH)
        {
            return CTCTKhuyenMaiDAO.locTheoCTKM(maKH);
        }
        public static int layPTKM(string maKM)
        {
            return CTCTKhuyenMaiDAO.layPTKM(maKM);
        }

        public static DataTable getKM(string maKM)
        {
           return CTCTKhuyenMaiDAO.getMaKH(maKM);
        }
    }
}
