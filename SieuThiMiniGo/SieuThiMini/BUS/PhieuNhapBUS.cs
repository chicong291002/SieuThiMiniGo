using SieuThiMini.DAO;
using SieuThiMini.DTO;
using SieuThiMini.GUI;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SieuThiMini.BUS
{
    internal class PhieuNhapBUS
    {
        
        public static DataTable layToanBoDanhSach()
        {
            return  PhieuNhapDAO.layToanBoPhieuNhap();
        }

        [Obsolete]
        public static void insert(string[] nhaCungCap, string[] nhanVien,DateTime ngayLap, float tongTien)
        {
            string NhaCungCap = nhaCungCap[0];
            string NhanVien = nhanVien[0];
            PhieuNhapHang pnh = new PhieuNhapHang();
            pnh.MaNCC = NhaCungCap;
            pnh.MaNV = NhanVien;
            pnh.TongTien = tongTien;
            pnh.NgayLap = ngayLap;
            PhieuNhapDAO.insert_PN(pnh);
        }

        public int getLastID()
        {
            PhieuNhapDAO phieuNhap = new PhieuNhapDAO();
            return phieuNhap.getLastID();
        }
    }

}
