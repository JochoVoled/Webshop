using BestOfBrands.Interfaces;

namespace BestOfBrands.Entities
{
    public class Product : IProduct
    {
        public string Name { get; set; }
        public string Category { get; set; }
        public string Description { get; set; }
        public bool IsChild { get; set; }
        public decimal PriceSell { get; set; }
        public decimal PriceBuy { get; set; }
        public string ProductNumber { get; set; }
        public string Size { get; set; }
        public int StockAmount { get; set; }
        public string Gender { get; set; }

        public Product(string Name, string Category, string Description, bool IsChild = false, decimal SellPrice = 0, decimal PurchedPrice = 0, string Size = "M", int StockAmount = 1, string Gender = "Unisex")
        {
            this.Name = Name;
            this.Category = Category; /* osv */
            this.Description = Description;
            this.IsChild = IsChild;
            PriceSell = SellPrice;
            PriceBuy = PurchedPrice;
            this.Size = Size;
            this.StockAmount = StockAmount;
            this.Gender = Gender;
        }
    }
}