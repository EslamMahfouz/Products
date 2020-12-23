using System;
using System.Collections.Generic;
using System.Linq;

namespace Dukan.Core.Models.Sale
{
    public class SaleReportModel
    {
        public List<SaleDetailReportModel> SaleDetails { get; set; }

        public int Id { get; set; }
        public int Number { get; set; }
        public string CustomerName { get; set; }
        public string CustomerPhone { get; set; }

        public DateTime? Date { get; set; }
        public decimal Total => Math.Round(SaleDetails.Sum(s => s.TotalAfterDiscount), 2);
        public decimal Discount { get; set; }
        public decimal TotalAfterDiscount => Math.Round(Total * (1 - Discount), 2);
        public decimal Charge { get; set; }


    }
}
