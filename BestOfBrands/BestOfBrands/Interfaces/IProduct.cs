using BestOfBrands.Enums;

namespace BestOfBrands.Interfaces
{
    public interface IProduct
    {
        int StockAmount { get; set; }
        string Name { get; set; }
        decimal Price { get; set; }
        IProductCategory Category { get; set; }
        EGender TargetConsumer { get; set; }
        bool IsChild { get; set; }
        string ProductNumber { get; set; }
        string Size { get; set; }
        string Description { get; set; }
    }
}