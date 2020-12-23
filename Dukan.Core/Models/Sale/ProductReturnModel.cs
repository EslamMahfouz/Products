using System.ComponentModel;

namespace Dukan.Core.Models.Sale
{
    public class ProductReturnModel
    {
        [Browsable(false)]
        public int Id { get; set; }

        [DisplayName("المنتج")]
        public string Name { get; set; }

        [DisplayName("الكمية")]
        public int? Qte { get; set; }
    }
}