using System;
using System.ComponentModel;

namespace Dukan.Core.Models.Sale
{
    public class SaleDetailGridModel
    {
        [Browsable(false)]
        public int Id { get; set; }

        [DisplayName("المنتج")]
        public string ProductName { get; set; }

        [DisplayName("سعر الشراء")]
        public decimal ProductBuy { get; set; }

        [DisplayName("سعر البيع")]
        public decimal ProductSell { get; set; }

        [DisplayName("الكمية")]
        public int Qte { get; set; }

        [DisplayName("إجمالي سعر البيع")]
        public decimal Total => ProductSell * (Qte - ReturnedQte);

        [DisplayName("الخصم")]
        public decimal Discount { get; set; }

        [DisplayName("الكمية المرتجعة")]
        public int ReturnedQte { get; set; }

        [DisplayName(" الإجمالي بعد الخصم والمرتجع")]
        public decimal TotalAfterDiscount => Math.Round(ProductSell * (Qte - ReturnedQte) * (1 - Discount), 2);

        [DisplayName("إجمالي سعر الشراء")]
        public decimal TotalBuy => Math.Round(ProductBuy * (Qte - ReturnedQte), 2);

        [DisplayName("صافي الربح")]
        public decimal Profit => Math.Round(TotalAfterDiscount - TotalBuy, 2);
    }
}