using System;
using System.ComponentModel;

namespace Dukan.Core.Models.Sale
{

    public class SalePaymentModel
    {
        [Browsable(false)]
        public int Id { get; set; }

        [DisplayName("التاريخ")]
        public DateTime? Date { get; set; }

        [DisplayName("رقم الفاتورة")]
        public int Number { get; set; }

        [DisplayName("المدفوع")]
        public double Paid { get; set; }

        [DisplayName("نوع السداد")]
        public string Type { get; set; }

    }
}
