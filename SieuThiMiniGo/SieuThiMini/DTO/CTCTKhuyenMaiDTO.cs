using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SieuThiMini.DTO
{
    internal class CTCTKhuyenMaiDTO
    {
        private string maCT;
        private string ptKM;

        public CTCTKhuyenMaiDTO(string maCT, string ptKM)
        {
            this.MaCT = maCT;
            this.PtKM = ptKM;
        }

        public string MaCT { get => maCT; set => maCT = value; }
        public string PtKM { get => ptKM; set => ptKM = value; }
    }
}
