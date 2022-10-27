using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SieuThiMini.DTO
{
    internal class CTChuongTrinhKhuyenMai
    {
        private string maChuongTrinh;
        private float phanTramGiamGia;

        public CTChuongTrinhKhuyenMai(string maChuongTrinh, float phanTramGiamGia)
        {
            this.MaChuongTrinh = maChuongTrinh;
            this.PhanTramGiamGia = phanTramGiamGia;
        }

        public string MaChuongTrinh { get => maChuongTrinh; set => maChuongTrinh = value; }
        public float PhanTramGiamGia { get => phanTramGiamGia; set => phanTramGiamGia = value; }
    }
}
