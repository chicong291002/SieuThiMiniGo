using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SieuThiMini.DTO
{
    internal class CTHoaDon
    {
        private string invoice_id,product_id,product_name;
        private int amount;
        private float unitPrice, intoMoney;

        public CTHoaDon(string invoice_id, string product_id, string product_name, int amount, float unitPrice, float intoMoney)
        {
            this.Invoice_id = invoice_id;
            this.Product_id = product_id;
            this.Product_name = product_name;
            this.Amount = amount;
            this.UnitPrice = unitPrice;
            this.IntoMoney = intoMoney;
        }

        public string Invoice_id { get => invoice_id; set => invoice_id = value; }
        public string Product_id { get => product_id; set => product_id = value; }
        public string Product_name { get => product_name; set => product_name = value; }
        public int Amount { get => amount; set => amount = value; }
        public float UnitPrice { get => unitPrice; set => unitPrice = value; }
        public float IntoMoney { get => intoMoney; set => intoMoney = value; }
    }
}
