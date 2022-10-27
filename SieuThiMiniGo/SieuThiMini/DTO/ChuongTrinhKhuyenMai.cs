using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SieuThiMini.DTO
{
    internal class ChuongTrinhKhuyenMai
    {
        private string maChuongTrinh,tenChuongTrinh,maKH;
        private DateTime ngayBatDau, ngayKetThuc;

        public ChuongTrinhKhuyenMai(string maChuongTrinh, string tenChuongTrinh, string maKH, DateTime ngayBatDau, DateTime ngayKetThuc)
        {
            this.MaChuongTrinh = maChuongTrinh;
            this.TenChuongTrinh = tenChuongTrinh;
            this.MaKH = maKH;
            this.NgayBatDau = ngayBatDau;
            this.NgayKetThuc = ngayKetThuc;
        }

        public string MaChuongTrinh { get => maChuongTrinh; set => maChuongTrinh = value; }
        public string TenChuongTrinh { get => tenChuongTrinh; set => tenChuongTrinh = value; }
        public string MaKH { get => maKH; set => maKH = value; }
        public DateTime NgayBatDau { get => ngayBatDau; set => ngayBatDau = value; }
        public DateTime NgayKetThuc { get => ngayKetThuc; set => ngayKetThuc = value; }
    }
}
