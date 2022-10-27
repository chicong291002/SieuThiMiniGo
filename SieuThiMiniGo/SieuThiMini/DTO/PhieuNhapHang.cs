using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SieuThiMini.DTO
{
    internal class PhieuNhapHang
    {
        private string maPhieu, maNV,maNCC;
        private DateTime ngayLap;
        private float tongTien;

        public PhieuNhapHang()
        {
        }

        public PhieuNhapHang(string maPhieu, string maNV, string maNCC, DateTime ngayLap, float tongTien)
        {
            this.MaPhieu = maPhieu;
            this.MaNV = maNV;
            this.MaNCC = maNCC;
            this.NgayLap = ngayLap;
            this.TongTien = tongTien;
        }

        public string MaPhieu { get => maPhieu; set => maPhieu = value; }
        public string MaNV { get => maNV; set => maNV = value; }
        public string MaNCC { get => maNCC; set => maNCC = value; }
        public DateTime NgayLap { get => ngayLap; set => ngayLap = value; }
        public float TongTien { get => tongTien; set => tongTien = value; }
    }
}
