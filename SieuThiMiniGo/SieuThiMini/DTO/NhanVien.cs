using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SieuThiMini.DTO
{
    internal class NhanVien
    {
        private string email;
        private string manv;
        private string honv;
        private string tennv;
        private string cmnd;
        private string sdt;
        private DateTime ngaySinh;
        private string gioiTinh;
        private float luong;
        private string viTri;
        private DateTime ngayVaoLam;

        public NhanVien()
        {
        }

        public NhanVien(string manv, string honv, string tennv, string cmnd, string sdt, string email, DateTime ngaySinh, string gioiTinh, float luong, string viTri, DateTime ngayVaoLam)
        {
            this.Manv = manv;
            this.Honv = honv;
            this.Tennv = tennv;
            this.Cmnd = cmnd;
            this.Sdt = sdt;
            this.Email = email;
            this.NgaySinh = ngaySinh;
            this.GioiTinh = gioiTinh;
            this.Luong = luong;
            this.ViTri = viTri;
            this.NgayVaoLam = ngayVaoLam;
        }

        public string Email { get => email; set => email = value; }
        public string Manv { get => manv; set => manv = value; }
        public string Honv { get => honv; set => honv = value; }
        public string Tennv { get => tennv; set => tennv = value; }
        public string Cmnd { get => cmnd; set => cmnd = value; }
        public string Sdt { get => sdt; set => sdt = value; }
        public DateTime NgaySinh { get => ngaySinh; set => ngaySinh = value; }
        public string GioiTinh { get => gioiTinh; set => gioiTinh = value; }
        public float Luong { get => luong; set => luong = value; }
        public string ViTri { get => viTri; set => viTri = value; }
        public DateTime NgayVaoLam { get => ngayVaoLam; set => ngayVaoLam = value; }
    }
}
