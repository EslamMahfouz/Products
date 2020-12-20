using System.ComponentModel;

namespace Dukan.Core.Models.Supplier
{
    public class SupplierComoModel
    {
        [DisplayName("م")]
        public int Id { get; set; }

        [DisplayName("الاسم")]
        public string Name { get; set; }
    }
}
