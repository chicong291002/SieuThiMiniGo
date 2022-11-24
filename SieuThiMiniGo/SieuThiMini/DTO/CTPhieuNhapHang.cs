using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SieuThiMini.DTO
{
    internal class CTPhieuNhapHang
    {
        private string maSP;
        private int maPhieu,soLuong;
        private float donGia, thanhTien;
        
        public CTPhieuNhapHang()
        {

        }

        public CTPhieuNhapHang(int maPhieu, string maSP, int soLuong, float donGia, float thanhTien)
        {
            this.MaPhieu = maPhieu;
            this.MaSP = maSP;
            this.SoLuong = soLuong;
            this.DonGia = donGia;
            this.ThanhTien = thanhTien;
        }
        public int MaPhieu { get => maPhieu; set => maPhieu = value; }
        public string MaSP { get => maSP; set => maSP = value; }
        public int SoLuong { get => soLuong; set => soLuong = value; }
        public float DonGia { get => donGia; set => donGia = value; }
        public float ThanhTien { get => thanhTien; set => thanhTien = value; }
    }
}
