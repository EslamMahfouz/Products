using System.ComponentModel;

namespace Dukan.Core.Models.Customer
{
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
