using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SieuThiMini.DTO
{
    internal class CTHoaDonDTO
    {
        private string maHD, maSP, tenSP;
        private int soLuong;
        private float donGia, thanhtien;
        //ctrl R+E
        public CTHoaDonDTO()
        {

        }
        public string MaSP { get => maSP; set => maSP = value; }
        public string TenSP { get => tenSP; set => tenSP = value; }
        public string MaHD { get => maHD; set => maHD = value; }
        public float DonGia { get => donGia; set => donGia = value; }
        public float Thanhtien { get => thanhtien; set => thanhtien = value; }
        public int SoLuong { get => soLuong; set => soLuong = value; }
    }
}
