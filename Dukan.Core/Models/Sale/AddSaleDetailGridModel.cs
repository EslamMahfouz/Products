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
        public double ProductSell { get; set; }

        [Browsable(false)]
        public double ProductBuy { get; set; }

        [DisplayName("الكمية")]
        public int? Qte { get; set; }

        [DisplayName("الإجمالي")]
        public double Total { get; set; }

        [DisplayName("الخصم")]
        public double Discount { get; set; }

        [DisplayName("الإجمالي بعد الخصم")]
        public double TotalAfterDiscount { get; set; }
    }
}