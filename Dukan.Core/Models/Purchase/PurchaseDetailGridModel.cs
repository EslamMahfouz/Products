using System;
using System.ComponentModel;

namespace Dukan.Core.Models.Purchase
{
    public class PurchaseDetailGridModel
    {
        [Browsable(false)]
        public int Id { get; set; }

        [DisplayName("المنتج")]
        public string ProductName { get; set; }

        [DisplayName("السعر")]
        public decimal ProductBuy { get; set; }

        [DisplayName("الكمية")]
        public int Qte { get; set; }

        [DisplayName("الإجمالي")]
        public decimal Total => Math.Round(ProductBuy * Qte, 2);

        [DisplayName("الخصم")]
        public decimal Discount { get; set; }

        [DisplayName("الكمية المرتجعة")]
        public int ReturnedQte { get; set; }

        [DisplayName(" الإجمالي بعد الخصم والمرتجع")]
        public decimal TotalAfterDiscount => Math.Round(ProductBuy * (Qte - ReturnedQte) * (1 - Discount), 2);
    }
}