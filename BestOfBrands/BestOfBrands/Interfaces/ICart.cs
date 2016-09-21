namespace BestOfBrands.Interfaces
{
    interface ICart
    {
        System.Collections.Generic.List<IProduct> productList { get; set; }
        decimal CountPrice();
        void Remove(IProduct product);
        void Add(IProduct product);
        void CheckOut();
        void PlaceOrder();
        void Clear();
    }
}
