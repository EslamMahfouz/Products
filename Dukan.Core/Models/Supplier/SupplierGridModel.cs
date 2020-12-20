using System.ComponentModel;

namespace Dukan.Core.Models.Supplier
{
    public class SupplierGridModel
    {
        public int SupplierId { get; set; }

        [DisplayName("الإسم")]
        public string SupplierName { get; set; }

        [DisplayName("الموبايل")]
        public string SupplierPhone { get; set; }

        [DisplayName("التليفون")]
        public string SupplierTel { get; set; }

        [DisplayName("العنوان")]
        public string SupplierAddress { get; set; }

        [DisplayName("المتبقى")]
        public double? SupplierCharge { get; set; }
    }
}
