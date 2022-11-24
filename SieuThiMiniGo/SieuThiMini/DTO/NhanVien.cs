using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SieuThiMini.DTO
{
    internal class NhanVien
    {
        private string maNV;
        private string hoNV;
        private string tenNV;
        private string sDT;
        private string cMND;
        private string email;
        private DateTime ngaySinh;
        private string gioiTinh;
        private string luong;
        private string viTri;
        private DateTime ngayVaoLam;

        public NhanVien()
        {
        }

        public NhanVien(string maNV, string hoNV, string tenNV, string sDT, string cMND, string email, DateTime ngaySinh, string gioiTinh, string luong, string viTri, DateTime ngayVaoLam)
        {
            this.MaNV = maNV;
            this.HoNV = hoNV;
            this.TenNV = tenNV;
            this.SDT = sDT;
            this.CMND = cMND;
            this.Email = email;
            this.NgaySinh = ngaySinh;
            this.GioiTinh = gioiTinh;
            this.Luong = luong;
            this.ViTri = viTri;
            this.NgayVaoLam = ngayVaoLam;
        }

        public string MaNV { get => maNV; set => maNV = value; }
        public string HoNV { get => hoNV; set => hoNV = value; }
        public string TenNV { get => tenNV; set => tenNV = value; }
        public string SDT { get => sDT; set => sDT = value; }
        public string CMND { get => cMND; set => cMND = value; }
        public string Email { get => email; set => email = value; }
        public DateTime NgaySinh { get => ngaySinh; set => ngaySinh = value; }
        public string GioiTinh { get => gioiTinh; set => gioiTinh = value; }
        public string Luong { get => luong; set => luong = value; }
        public string ViTri { get => viTri; set => viTri = value; }
        public DateTime NgayVaoLam { get => ngayVaoLam; set => ngayVaoLam = value; }
    }
}
