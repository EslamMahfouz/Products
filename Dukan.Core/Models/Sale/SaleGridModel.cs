using Dukan.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace Dukan.Core.Models.Sale
{
    public class SaleGridModel
    {
        [Browsable(false)]
        public IEnumerable<SaleDetailGridModel> SaleDetails { get; set; }

        [Browsable(false)]
        public IEnumerable<SalePayment> SalePayments { get; set; }

        [Browsable(false)]
        public int Id { get; set; }

        [DisplayName("رقم الفاتورة")]
        public int Number { get; set; }

        [DisplayName("التاريخ")]
        public DateTime? Date { get; set; }

        [DisplayName("العميل")]
        public string CustomerName { get; set; }

        [DisplayName("الإجمالي")]
        public decimal Total => SaleDetails.Sum(s => s.TotalAfterDiscount);

        [DisplayName("الخصم")]
        public decimal Discount { get; set; }

        [DisplayName("الإجمالي بعد الخصم")]
        public decimal TotalAfterDiscount => Total * (1 - Discount);

        [DisplayName("المدفوع")]
        public decimal? Paid => SalePayments.Where(p => p.Type == "إيراد").Sum(p => p.Paid)
                               - SalePayments.Where(p => p.Type == "مرتجع").Sum(p => p.Paid);

        [DisplayName("المتبقي")]
        public decimal? Charge => TotalAfterDiscount - Paid;
    }
}