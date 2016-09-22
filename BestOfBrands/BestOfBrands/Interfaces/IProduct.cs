using BestOfBrands.Enums;

namespace BestOfBrands.Interfaces
{
    public interface IProduct
    {
        int StockAmount { get; set; }
        string Name { get; set; }
        decimal PriceSell { get; set; }
        decimal PriceBuy { get; set; }
        string Category { get; set; }
        string Gender { get; set; }
        bool IsChild { get; set; }
        string ProductNumber { get; set; }
        string Size { get; set; }
        string Description { get; set; }
    }
}