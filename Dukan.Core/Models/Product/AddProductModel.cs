namespace Dukan.Core.Models.Product
{
    public class AddProductModel
    {
        public int? CategoryId { get; set; }
        public string Barcode { get; set; }
        public string Name { get; set; }
        public decimal Buy { get; set; }
        public decimal Sell { get; set; }
        public int Qte { get; set; }
        public int Minimum { get; set; }
    }
}