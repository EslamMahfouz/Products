using Dukan.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace Dukan.Core.Models
{
    public class SaleModel
    {
        [Browsable(false)]
        public int Id { get; set; }

        [DisplayName("رقم الفاتورة")]
        public int Number { get; set; }

        [DisplayName("التاريخ")]
        public DateTime? Date { get; set; }

        [DisplayName("الإجمالي")]
        public double Total { get; set; }

        [DisplayName("الخصم")]
        public double Discount { get; set; }

        [DisplayName("الإجمالي بعد الخصم")]
        public double TotalAfterDiscount { get; set; }

        [DisplayName("المدفوع")]
        public double Paid { get; set; }

        [DisplayName("المتبقي")]
        public double Charge { get; set; }

    }

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

        [DisplayName("الإجمالي")]
        public double Total => SaleDetails.Sum(s => s.TotalAfterDiscount);

        [DisplayName("الخصم")]
        public double Discount { get; set; }

        [DisplayName("الإجمالي بعد الخصم")]
        public double TotalAfterDiscount => Total * (1 - Discount);

        [DisplayName("المدفوع")]
        public double? Paid => SalePayments.Where(p => p.Type == "إيراد").Sum(p => p.Paid)
                                                        - SalePayments.Where(p => p.Type == "مرتجع").Sum(p => p.Paid);

        [DisplayName("المتبقي")]
        public double? Charge => TotalAfterDiscount - Paid;
    }

    public class SaleReportModel
    {
        public int Id { get; set; }
        public int Number { get; set; }
        public string CustomerName { get; set; }
        public string CustomerPhone { get; set; }

        public DateTime? Date { get; set; }
        public double Total { get; set; }
        public double Discount { get; set; }
        public double TotalAfterDiscount { get; set; }
        public double Charge { get; set; }

        public List<SaleDetailReportModel> SaleDetails { get; set; }

    }
}
