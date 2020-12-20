using System.ComponentModel;

namespace Dukan.Core.Models.Sale
{
    public class ProductReturnModel
    {
        [DisplayName("م")]
        public int Id { get; set; }

        [DisplayName("المنتج")]
        public string Name { get; set; }

        [DisplayName("الكمية المباعة")]
        public int? Qte { get; set; }
    }
}