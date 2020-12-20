namespace Dukan.Core.Models.Sale
{
    public class SaleDetailReportModel
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public double ProductSell { get; set; }
        public int Qte { get; set; }
        public double Total { get; set; }
        public double Discount { get; set; }
        public double TotalAfterDiscount { get; set; }
        public bool IsReturned { get; set; }
    }
}