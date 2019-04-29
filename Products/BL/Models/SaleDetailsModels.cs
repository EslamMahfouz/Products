using System.ComponentModel;

namespace Products.BL.Models
{
    public class AddSaleDetailGridModel
    {
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

    public class ProductReturnModel
    {
        [DisplayName("م")]
        public int Id { get; set; }

        [DisplayName("المنتج")]
        public string Name { get; set; }

        [DisplayName("الكمية المباعة")]
        public int? Qte { get; set; }
    }


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
        public double TotalAfterDiscount => ProductSell * (Qte - ReturnedQte) * (1 - Discount);
    }


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