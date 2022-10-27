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
    internal class NhaCungCapBUS
    {
        public static DataTable getAllNhaCungCap()
        {
            return NhaCungCapDAO.getAllNhaCungCap();
        }

        public static void insertNhaCungCap(NhaCungCap ncc)
        {
            NhaCungCapDAO.insertNhaCungCap(ncc);
        }

        public static void updateNhaCungCap(NhaCungCap ncc)
        {
            NhaCungCapDAO.updateNhaCungCap(ncc);
        }

        public static void deleteNhaCungCap(string ma)
        {
            NhaCungCapDAO.deleteNhaCungCap(ma);
        }
    }

}
