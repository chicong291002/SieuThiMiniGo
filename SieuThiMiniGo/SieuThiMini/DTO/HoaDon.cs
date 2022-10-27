using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SieuThiMini.DTO
{
    internal class HoaDon
    {
        private string maHD, maNV, maKH;
        private DateTime ngayLap;
        private float tongTien;

        public HoaDon(string maHD, string maNV, string maKH, DateTime ngayLap, float tongTien)
        {
            this.MaHD = maHD;
            this.MaNV = maNV;
            this.MaKH = maKH;
            this.NgayLap = ngayLap;
            this.TongTien = tongTien;
        }

        public string MaHD { get => maHD; set => maHD = value; }
        public string MaNV { get => maNV; set => maNV = value; }
        public string MaKH { get => maKH; set => maKH = value; }
        public DateTime NgayLap { get => ngayLap; set => ngayLap = value; }
        public float TongTien { get => tongTien; set => tongTien = value; }
    }
}
