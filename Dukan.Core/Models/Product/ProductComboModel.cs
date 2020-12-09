using System.ComponentModel;

namespace Dukan.Core.Models.Product
{
    public class ProductComboModel
    {
        [DisplayName("م")]
        public int Id { get; set; }

        [DisplayName("المنتج")]
        public string Name { get; set; }

        [DisplayName("الكمية المتوفرة")]
        public int Qte { get; set; }
    }
}