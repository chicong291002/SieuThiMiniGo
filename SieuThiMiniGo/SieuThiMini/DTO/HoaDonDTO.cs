using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SieuThiMini.DTO
{
    internal class HoaDonDTO
    {
        private string invoice_id, employee_id, customer_id;
        private DateTime dateFounded;
        private float totalMoney;

        public HoaDonDTO()
        {

        }

        public HoaDonDTO(string invoice_id, string employee_id, string customer_id, DateTime dateFounded, float totalMoney)
        {
            this.Invoice_id = invoice_id;
            this.Employee_id = employee_id;
            this.Customer_id = customer_id;
            this.DateFounded = dateFounded;
            this.TotalMoney = totalMoney;
        }

        public string Invoice_id { get => invoice_id; set => invoice_id = value; }
        public string Employee_id { get => employee_id; set => employee_id = value; }
        public string Customer_id { get => customer_id; set => customer_id = value; }
        public DateTime DateFounded { get => dateFounded; set => dateFounded = value; }
        public float TotalMoney { get => totalMoney; set => totalMoney = value; }
    }
}
