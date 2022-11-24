using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SieuThiMini.DTO
{
    internal class KhachHangDTO
    {
        string MaKH, HoKH, TenKH, CMND, SoDT, GioiTinh, Ngaysinh;
        public KhachHangDTO()
        {

        }
        public string MaKH1 { get => MaKH; set => MaKH = value; }
        public string HoKH1 { get => HoKH; set => HoKH = value; }
        public string TenKH1 { get => TenKH; set => TenKH = value; }
        public string CMND1 { get => CMND; set => CMND = value; }
        public string SoDT1 { get => SoDT; set => SoDT = value; }
        public string GioiTinh1 { get => GioiTinh; set => GioiTinh = value; }
        public string Ngaysinh1 { get => Ngaysinh; set => Ngaysinh = value; }
    }
}
