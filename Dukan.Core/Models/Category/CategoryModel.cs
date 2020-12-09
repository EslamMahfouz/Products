using System.ComponentModel;

namespace Dukan.Core.Models.Category
{
    /// <summary>
    /// Applies for combo and grid
    /// </summary>
    public class CategoryModel
    {
        [Browsable(false)]
        public int Id { get; set; }

        [DisplayName("الصنف")]
        public string Name { get; set; }
    }

}
