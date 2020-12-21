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
        public double ProductSell { get; set; }

        [DisplayName("الكمية")]
        public int Qte { get; set; }

        [DisplayName("الإجمالي")]
        public double Total => ProductSell * Qte;

        [DisplayName("الخصم")]
        public double Discount { get; set; }

        [DisplayName("الكمية المرتجعة")]
        public int ReturnedQte { get; set; }

        [DisplayName(" الإجمالي بعد الخصم والمرتجع")]
        public double TotalAfterDiscount => ProductSell * (Qte - ReturnedQte) * (1 - Math.Round(Discount, 2));
    }
}