namespace BestOfBrands.Interfaces
{
    interface IAdmin
    {
        void EditOrder();
        void AddProduct();
        void RemoveProduct();
        void ViewInventory();
        void SetPrice(IProduct product);
        void GetProfit();
    }
}
