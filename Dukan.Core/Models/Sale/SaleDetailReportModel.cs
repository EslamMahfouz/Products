using System;

namespace Dukan.Core.Models.Sale
{
    public class SaleDetailReportModel
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public decimal ProductSell { get; set; }
        public int Qte { get; set; }
        public decimal Total => ProductSell * Qte;
        public decimal Discount { get; set; }
        public decimal TotalAfterDiscount => Math.Round(Total * (1 - Discount), 2);
        public bool IsReturned { get; set; }
    }
}