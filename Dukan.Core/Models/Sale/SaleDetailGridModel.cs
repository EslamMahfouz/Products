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

        [DisplayName("السعر")]
        public decimal ProductSell { get; set; }

        [DisplayName("الكمية")]
        public int Qte { get; set; }

        [DisplayName("الإجمالي")]
        public decimal Total => ProductSell * Qte;

        [DisplayName("الخصم")]
        public decimal Discount { get; set; }

        [DisplayName("الكمية المرتجعة")]
        public int ReturnedQte { get; set; }

        [DisplayName(" الإجمالي بعد الخصم والمرتجع")]
        public decimal TotalAfterDiscount => Math.Round(ProductSell * (Qte - ReturnedQte) * (1 - Discount), 2);
    }
}