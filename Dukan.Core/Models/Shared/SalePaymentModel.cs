using System;
using System.ComponentModel;

namespace Dukan.Core.Models.Shared
{

    public class PaymentModel
    {
        [Browsable(false)]
        public int Id { get; set; }

        [DisplayName("التاريخ")]
        public DateTime? Date { get; set; }

        [DisplayName("رقم الفاتورة")]
        public int Number { get; set; }

        [DisplayName("المدفوع")]
        public decimal Paid { get; set; }

        [DisplayName("نوع السداد")]
        public string Type { get; set; }

    }
}
