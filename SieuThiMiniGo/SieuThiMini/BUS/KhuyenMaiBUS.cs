using SieuThiMini.DAO;
using SieuThiMini.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SieuThiMini.BUS
{
    internal class KhuyenMaiBUS
    {
        public static DataTable docDSKM()
        {
            return KhuyenMaiDAO.docDSKM();
        }

        public static void insert(KhuyenMaiDTO khuyenMai)
        {
            KhuyenMaiDAO.insertCTKM(khuyenMai);
        }

        public static void update(KhuyenMaiDTO khuyenMai)
        {
            KhuyenMaiDAO.updateCTKM(khuyenMai);
        }

        public static void delete(string ma)
        {
            KhuyenMaiDAO.deleteCTKM(ma);
        }
    }
}
