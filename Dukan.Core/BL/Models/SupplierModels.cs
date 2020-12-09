using System.ComponentModel;

namespace Dukan.Core.BL.Models
{
    public class AddSupplierModel
    {
        public string SupplierName { get; set; }
        public string SupplierPhone { get; set; }
        public string SupplierTel { get; set; }
        public string SupplierAddress { get; set; }
    }

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
