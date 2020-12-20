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
        public double ProductBuy { get; set; }

        [DisplayName("الكمية")]
        public int Qte { get; set; }

        [DisplayName("الإجمالي")]
        public double Total => ProductBuy * Qte;

        [DisplayName("الخصم")]
        public double Discount { get; set; }

        [DisplayName("الكمية المرتجعة")]
        public int ReturnedQte { get; set; }

        [DisplayName(" الإجمالي بعد الخصم والمرتجع")]
        public double TotalAfterDiscount => ProductBuy * (Qte - ReturnedQte) * (1 - Discount);
    }
}