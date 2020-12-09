namespace Dukan.Core.Models.Product
{
    public class AddProductModel
    {
        public int? CategoryId { get; set; }
        public string Name { get; set; }
        public double Buy { get; set; }
        public double Sell { get; set; }
        public int Qte { get; set; }
        public int Minimum { get; set; }
    }
}