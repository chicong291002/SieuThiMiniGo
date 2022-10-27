using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SieuThiMini.DTO
{
    internal class SanPhamDTO
    {
        private string maSP, donViTinh, maLoai, tenSP, maNCC;
        private float donGia;
        private int soLuong;

        public SanPhamDTO()
        {
        }

        public SanPhamDTO(string masp, string tensp, float dongia, string donvitinh, int soluong, string maloai, string mancc)
        {
            maSP = masp;
            tenSP = tensp;
            donGia = dongia;
            donViTinh = donvitinh;
            soLuong = soluong;
            maLoai = maloai;
            maNCC = mancc;
        }

        public string MaSP { get => maSP; set => maSP = value; }
        public string TenSP { get => tenSP; set => tenSP = value; }
        public string DonViTinh { get => donViTinh; set => donViTinh = value; }
        public string MaLoai { get => maLoai; set => maLoai = value; }
        public float DonGia { get => donGia; set => donGia = value; }
        public int SoLuong { get => soLuong; set => soLuong = value; }

        public string MaNCC { get => maNCC; set => maNCC = value; }
    }
}
