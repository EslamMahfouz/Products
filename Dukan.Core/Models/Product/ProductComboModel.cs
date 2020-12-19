using System.ComponentModel;

namespace Dukan.Core.Models.Product
{
    public class ProductComboModel
    {
        [Browsable(false)]
        public int Id { get; set; }

        [DisplayName("المنتج")]
        public string Name { get; set; }

        [DisplayName("سعر الشراء")]
        public double Buy { get; set; }

        [DisplayName("سعر البيع")]
        public double Sell { get; set; }

        [DisplayName("الكمية المتوفرة")]
        public int Qte { get; set; }
    }
}