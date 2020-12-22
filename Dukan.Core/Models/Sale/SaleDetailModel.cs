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
        public decimal ProductSell { get; set; }

        [DisplayName("الكمية")]
        public int Qte { get; set; }

        [DisplayName("الإجمالي")]
        public decimal Total { get; set; }

        [DisplayName("الخصم")]
        public decimal Discount { get; set; }

        [DisplayName("الإجمالي بعد الخصم")]
        public decimal TotalAfterDiscount { get; set; }

        [DisplayName("مرتجع")]
        public bool IsReturned { get; set; }
    }
}