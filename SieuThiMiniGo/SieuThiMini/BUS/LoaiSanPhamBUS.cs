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
    internal class LoaiSanPhamBUS
    {
        public static DataTable getAllSanPham()
        {
            return LoaiSanPhamDAO.laytoanboSanPham();
        }

        [Obsolete]
        public static void insertSanPham(loaiSanPham sp)
        {
            LoaiSanPhamDAO.insert_SP(sp);
        }

        [Obsolete]
        public static void updateSanPham(loaiSanPham sp)
        {
            LoaiSanPhamDAO.update_sp(sp);
        }

        public static void deleteSanPham(string ma)
        {
            LoaiSanPhamDAO.delete_sp(ma);
        }

        public static void searchSanPham(string tuKhoa)
        {
            LoaiSanPhamDAO.search_sp(tuKhoa);
        }
    }
}
