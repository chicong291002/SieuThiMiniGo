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
    internal class SanPhamBUS
    {
        public static DataTable getAllSanPham()
        {
            return SanPhamDAO.laytoanboSanPham();
        }

        [Obsolete]
        public static void insertSanPham(SanPham sp)
        {
            SanPhamDAO.insert_SP(sp);
        }

        [Obsolete]
        public static void updateSanPham(SanPham sp)
        {
            SanPhamDAO.update_sp(sp);
        }

        public static void deleteSanPham(string ma)
        {
            SanPhamDAO.delete_sp(ma);
        }

        public static void searchSanPham(string tuKhoa)
        {
            SanPhamDAO.search_sp(tuKhoa);
        }

        public static DataTable locSPTheoloai(string maLoai)
        {
            return SanPhamDAO.locSPTheoLoai(maLoai);
        }
        public static DataTable timNhanhSPTheoLoai(string tuKhoa, string maLoai)
        {
            return SanPhamDAO.timNhanhSPTheoLoai(tuKhoa, maLoai);
        }

        public static int laySoLuong(string ma)
        {
            return SanPhamDAO.laySoLuong(ma);
        }
    }

}
