using System.ComponentModel;

namespace Dukan.Core.BL.Models
{
    public class EditCustomerModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Tel { get; set; }
        public string Address { get; set; }
    }

    public class CustomerComboModel
    {
        [DisplayName("م")]
        public int Id { get; set; }

        [DisplayName("العميل")]
        public string Name { get; set; }
    }

    public class CustomerGridModel
    {
        [Browsable(false)]
        public int Id { get; set; }

        [DisplayName("الإسم")]
        public string Name { get; set; }

        [DisplayName("الموبايل")]
        public string Phone { get; set; }

        [DisplayName("التليفون")]
        public string Tel { get; set; }

        [DisplayName("العنوان")]
        public string Address { get; set; }

        [DisplayName("المديونية")]
        public string Charge { get; set; }
    }
}
