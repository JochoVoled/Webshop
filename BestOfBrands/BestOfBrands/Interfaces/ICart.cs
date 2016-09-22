namespace BestOfBrands.Interfaces
{
    interface ICart
    {
        System.Collections.Generic.List<IProduct> productList { get; set; }
        decimal CountPrice();
        bool Remove(IProduct product);
        bool Add(IProduct product);
        bool CheckOut();
        bool PlaceOrder();
        bool Clear();
    }
}
