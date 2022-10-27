using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SieuThiMini.DAO;
using SieuThiMini.DTO;

namespace SieuThiMini.BUS
{
    internal class NhanVienBUS
    {
        public static DataTable GetAllNhanVien()
        {
            return NhanVienDAO.laytoanboNhanVien();
        }
        
        [Obsolete]
        public static void insertNhanVien(NhanVien nv)
        {
             NhanVienDAO.insertnv(nv);
            
        }

        [Obsolete]
        public static void updateNhanVien(NhanVien nv)
        {
           NhanVienDAO.updatenv(nv);
        }

        public static void deleteNhanVien(string maNV)
        {
            NhanVienDAO.deletenv(maNV);
        }

        public static DataTable searchNhanVien(string tuKhoa)
        {            
            return NhanVienDAO.searchnv(tuKhoa);
        }
    }
}
