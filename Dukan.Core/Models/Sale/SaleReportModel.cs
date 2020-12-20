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
        public double Total { get; set; }
        public double Discount { get; set; }
        public double TotalAfterDiscount { get; set; }
        public double Charge { get; set; }

        public List<SaleDetailReportModel> SaleDetails { get; set; }

    }
}
