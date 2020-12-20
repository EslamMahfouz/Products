﻿using System.ComponentModel;

namespace Dukan.Core.Models.Customer
{
    public class CustomerComboModel
    {
        [DisplayName("م")]
        public int Id { get; set; }

        [DisplayName("الاسم")]
        public string Name { get; set; }
    }
}