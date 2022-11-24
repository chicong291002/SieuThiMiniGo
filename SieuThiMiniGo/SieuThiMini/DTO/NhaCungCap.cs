using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SieuThiMini.DTO
{
    internal class NhaCungCap
    {
        private string maNCC, tenNCC, sdt, diaChi, email;

        public NhaCungCap()
        {

        }

        public NhaCungCap(string maNCC, string tenNCC, string sdt, string diaChi, string email)
        {
            this.MaNCC = maNCC;
            this.TenNCC = tenNCC;
            this.Sdt = sdt;
            this.DiaChi = diaChi;
            this.Email = email;
        }

        public string MaNCC { get => maNCC; set => maNCC = value; }
        public string TenNCC { get => tenNCC; set => tenNCC = value; }
        public string Sdt { get => sdt; set => sdt = value; }
        public string DiaChi { get => diaChi; set => diaChi = value; }
        public string Email { get => email; set => email = value; }
    }
}
