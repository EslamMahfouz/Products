using System.ComponentModel;

namespace Dukan.Core.Models.Sale
{
    public class SaleDetailModel
    {
        [Browsable(false)]
        public int Id { get; set; }

        [DisplayName("المنتج")]
        public string ProductName { get; set; }

        [DisplayName("السعر")]
        public double ProductSell { get; set; }

        [DisplayName("الكمية")]
        public int Qte { get; set; }

        [DisplayName("الإجمالي")]
        public double Total { get; set; }

        [DisplayName("الخصم")]
        public double Discount { get; set; }

        [DisplayName("الإجمالي بعد الخصم")]
        public double TotalAfterDiscount { get; set; }

        [DisplayName("مرتجع")]
        public bool IsReturned { get; set; }
    }
}