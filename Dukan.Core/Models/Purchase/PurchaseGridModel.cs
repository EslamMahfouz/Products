﻿using Dukan.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace Dukan.Core.Models.Purchase
{
    public class PurchaseGridModel
    {
        [Browsable(false)]
        public IEnumerable<PurchaseDetailGridModel> PurchaseDetails { get; set; }

        [Browsable(false)]
        public IEnumerable<PurchasePayment> PurchasePayments { get; set; }

        [Browsable(false)]
        public int Id { get; set; }

        [DisplayName("رقم الفاتورة")]
        public int Number { get; set; }

        [DisplayName("التاريخ")]
        public DateTime? Date { get; set; }

        [DisplayName("المورد")]
        public string SupplierName { get; set; }

        [DisplayName("الإجمالي")]
        public decimal Total => PurchaseDetails.Sum(s => s.TotalAfterDiscount);

        [DisplayName("الخصم")]
        public decimal Discount { get; set; }

        [DisplayName("الإجمالي بعد الخصم")]
        public decimal TotalAfterDiscount => Total * (1 - Discount);

        [DisplayName("المدفوع")]
        public decimal? Paid => PurchasePayments.Where(p => p.Type == "مصروف").Sum(p => p.Paid)
                               - PurchasePayments.Where(p => p.Type == "مرتجع").Sum(p => p.Paid);

        [DisplayName("المتبقي")]
        public decimal? Charge => TotalAfterDiscount - Paid;
    }
}