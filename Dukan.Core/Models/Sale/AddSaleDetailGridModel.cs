using System.ComponentModel;

namespace Dukan.Core.Models.Sale
{
    public class AddSaleDetailGridModel
    {
        [Browsable(false)]
        public int ProductId { get; set; }

        [DisplayName("المنتج")]
        public string Name { get; set; }

        [DisplayName("السعر")]
        public decimal ProductSell { get; set; }

        [Browsable(false)]
        public decimal ProductBuy { get; set; }

        [DisplayName("الكمية")]
        public int? Qte { get; set; }

        [DisplayName("الإجمالي")]
        public decimal Total { get; set; }

        [DisplayName("الخصم")]
        public decimal Discount { get; set; }

        [DisplayName("الإجمالي بعد الخصم")]
        public decimal TotalAfterDiscount { get; set; }
    }
}