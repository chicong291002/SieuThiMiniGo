using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SieuThiMini.DTO
{
    internal class SanPham
    {
        private string maSP,donViTinh,maLoai,tenSP,maNCC;
        private float donGia;
        private int soLuong;
        private byte[] anh;

        public SanPham(string maSP, string tenSP, float donGia, string donViTinh, int soLuong, string maLoai, string maNCC, byte[] anh)
        {
            this.maSP = maSP;
            this.tenSP = tenSP;
            this.donGia = donGia;
            this.donViTinh = donViTinh;
            this.soLuong = soLuong;
            this.maLoai = maLoai;
            this.maNCC = maNCC;
            this.anh = anh;
        }

        public string MaSP { get => maSP; set => maSP = value; }
        public string DonViTinh { get => donViTinh; set => donViTinh = value; }
        public string MaLoai { get => maLoai; set => maLoai = value; }
        public string TenSP { get => tenSP; set => tenSP = value; }
        public string MaNCC { get => maNCC; set => maNCC = value; }
        public float DonGia { get => donGia; set => donGia = value; }
        public int SoLuong { get => soLuong; set => soLuong = value; }
        public byte[] Anh { get => anh; set => anh = value; }
    }
}
