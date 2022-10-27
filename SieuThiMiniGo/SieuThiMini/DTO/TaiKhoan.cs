using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SieuThiMini.DTO
{
    internal class TaiKhoan
    {
        private string maTK, tenTK, matKhau, maNV, phanQuyen, trangThai,email;

        public TaiKhoan(string email)
        {
            this.email = email;
        }

        public TaiKhoan(string tenTK, string matKhau)
        {
            this.tenTK = tenTK;
            this.matKhau = matKhau;
        }

        public TaiKhoan(string maTK, string tenTK, string matKhau, string maNV, string phanQuyen, string trangThai, string email)
        {
            this.maTK = maTK;
            this.tenTK = tenTK;
            this.matKhau = matKhau;
            this.maNV = maNV;
            this.phanQuyen = phanQuyen;
            this.trangThai = trangThai;
            this.email = email;
        }

        public string MaTK { get => maTK; set => maTK = value; }
        public string TenTK { get => tenTK; set => tenTK = value; }
        public string MatKhau { get => matKhau; set => matKhau = value; }
        public string MaNV { get => maNV; set => maNV = value; }
        public string PhanQuyen { get => phanQuyen; set => phanQuyen = value; }
        public string TrangThai { get => trangThai; set => trangThai = value; }
        public string Email { get => email; set => email = value; }
    }
}
