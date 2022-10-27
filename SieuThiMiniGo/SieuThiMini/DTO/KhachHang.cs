using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SieuThiMini.DTO
{
    internal class KhachHang
    {
        private string maKH, hoKH,tenKH,sDT, cMND,gioiTinh;
        private DateTime ngaySinh;

        public KhachHang(string maKH, string hoKH, string tenKH, string sDT, string cMND, string gioiTinh, DateTime ngaySinh)
        {
            this.MaKH = maKH;
            this.HoKH = hoKH;
            this.TenKH = tenKH;
            this.SDT = sDT;
            this.CMND = cMND;
            this.GioiTinh = gioiTinh;
            this.NgaySinh = ngaySinh;
        }

        public string MaKH { get => maKH; set => maKH = value; }
        public string HoKH { get => hoKH; set => hoKH = value; }
        public string TenKH { get => tenKH; set => tenKH = value; }
        public string SDT { get => sDT; set => sDT = value; }
        public string CMND { get => cMND; set => cMND = value; }
        public string GioiTinh { get => gioiTinh; set => gioiTinh = value; }
        public DateTime NgaySinh { get => ngaySinh; set => ngaySinh = value; }
    }
}
