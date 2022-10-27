using SieuThiMini.DAO;
using SieuThiMini.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SieuThiMini.BUS
{
    internal class CTPhieuNhapBUS
    {
      
        public static DataTable layToanBoDanhSach()
        {
            return CTPhieuNhapDAO.layToanBoPhieuNhap();
            
        }

        public static DataTable getCTPhieuNhap(string maPN)
        {
            return CTPhieuNhapDAO.getPhieuNhap(maPN);   
        }

        public static void luuCTPhieuNhap(string maSP, int soluong, float dongia, float thanhTien)
        {
            PhieuNhapBUS pn = new PhieuNhapBUS();
            int maPhieu = pn.getLastID();
            CTPhieuNhapHang ctpn = new CTPhieuNhapHang();
            ctpn.MaPhieu = maPhieu;
            ctpn.MaSP = maSP;
            ctpn.SoLuong = soluong;
            ctpn.DonGia = dongia;
            ctpn.ThanhTien = thanhTien;

            CTPhieuNhapDAO.addCTPhieuNhap(ctpn);
        }
    }
}
