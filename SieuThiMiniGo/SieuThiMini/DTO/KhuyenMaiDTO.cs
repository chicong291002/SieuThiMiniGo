using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SieuThiMini.DTO
{
    internal class KhuyenMaiDTO
    {
        string maCT, tenCT, maKH;
        private DateTime ngayBatDau;
        private DateTime ngayKetThuc;

        public KhuyenMaiDTO(string maCT, string tenCT, string maKH, DateTime ngayBatDau, DateTime ngayKetThuc)
        {
            this.MaCT = maCT;
            this.TenCT = tenCT;
            this.MaKH = maKH;
            this.NgayBatDau = ngayBatDau;
            this.NgayKetThuc = ngayKetThuc;
        }

        public string MaCT { get => maCT; set => maCT = value; }
        public string TenCT { get => tenCT; set => tenCT = value; }
        public string MaKH { get => maKH; set => maKH = value; }
        public DateTime NgayBatDau { get => ngayBatDau; set => ngayBatDau = value; }
        public DateTime NgayKetThuc { get => ngayKetThuc; set => ngayKetThuc = value; }
    }
}
