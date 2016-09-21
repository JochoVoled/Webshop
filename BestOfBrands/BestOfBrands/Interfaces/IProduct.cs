namespace BestOfBrands.Interfaces
{
    public interface IProduct
    {
        int inStock { get; set; }
        string name { get; set; }
        int price { get; set; }
        //ProductCategory category;
        //TargetConsumer;
        bool isChild { get; set; }
        string productNumber { get; set; }
        string size { get; set; }
        string description { get; set; }
    }
}