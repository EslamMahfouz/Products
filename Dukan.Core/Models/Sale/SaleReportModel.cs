using System;
using System.Collections.Generic;

namespace Dukan.Core.Models.Sale
{
    public class SaleReportModel
    {
        public int Id { get; set; }
        public int Number { get; set; }
        public string CustomerName { get; set; }
        public string CustomerPhone { get; set; }

        public DateTime? Date { get; set; }
        public decimal Total { get; set; }
        public decimal Discount { get; set; }
        public decimal TotalAfterDiscount { get; set; }
        public decimal Charge { get; set; }

        public List<SaleDetailReportModel> SaleDetails { get; set; }

    }
}
