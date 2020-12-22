namespace Dukan.Core.Models.Sale
{
    public class SaleDetailReportModel
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public decimal ProductSell { get; set; }
        public int Qte { get; set; }
        public decimal Total { get; set; }
        public decimal Discount { get; set; }
        public decimal TotalAfterDiscount { get; set; }
        public bool IsReturned { get; set; }
    }
}