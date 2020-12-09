using System.ComponentModel;

namespace Dukan.Core.Models.Product
{
    public class ProductGridModel
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

        [DisplayName("الحد الأدني للطلب")]
        public int Minimum { get; set; }

        [DisplayName("الصنف")]
        public string CategoryName { get; set; }
    }
}
