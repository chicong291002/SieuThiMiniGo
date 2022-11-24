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
    internal class TaiKhoanBUS
    {
        public static List<TaiKhoan> getAllTaiKhoan()
        {
            return TaiKhoanDAO.getAllTaiKhoan();
        }

        [Obsolete]
        public static void insertTaiKhoan(TaiKhoan tk)
        {
            TaiKhoanDAO.insertTaiKhoan(tk);
        }

        [Obsolete]
        public static void updateTaiKhoan(TaiKhoan tk)
        {
            TaiKhoanDAO.updateTaiKhoan(tk);
        }

        public static void deleteTaiKhoan(string ma)
        {
            TaiKhoanDAO.deleteTaikhoan(ma);
        }

        public static void deleteTaiKhoanNV(string ma)
        {
            TaiKhoanDAO.deleteTaikhoanNV(ma);
        }

        /*
        public static List<TaiKhoan> loginAccount(string tk,string mk)
        {
            return TaiKhoanDAO.loginAccount(tk, mk);
        }
       */

        public static string login(string tk, string mk)
        {
            return TaiKhoanDAO.DangNhap(tk, mk);
        }
        public static string quyen()
        {
            return TaiKhoanDAO.quyen;
        }

        public static string checkPassWord(string email)
        {
            return TaiKhoanDAO.checkPassWord(email);
        }

        public static DataTable search(string tuKhoa)
        {
            return TaiKhoanDAO.searchnv(tuKhoa);
        }
    }
}
