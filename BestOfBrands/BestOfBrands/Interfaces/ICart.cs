namespace BestOfBrands.Interfaces
{
    interface ICart
    {

        System.Collections.Generic.List<IProduct> productList { get; set; }
        void CountPrice();
        void Remove(IProduct product);
        void Add(IProduct product);
        bool CheckOut();
        bool PlaceOrder();
        bool Clear();
    }
}
