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
    internal class TaiKhoanBUS
    {
       
        public static DataTable getAllTaiKhoan()
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

        
        public static List<TaiKhoan> loginAccount(string tk,string mk)
        {
            return TaiKhoanDAO.loginAccount(tk, mk);
        }
       
        public static string checkPassWord(string email)
        {
            return TaiKhoanDAO.checkPassWord(email);
        }
    }
}
