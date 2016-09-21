using System.Collections.Generic;

namespace BestOfBrands.Interfaces
{
    interface IAdmin
    {
        void EditOrder();
        void AddProduct();
        void RemoveProduct();
        List<IProduct> ViewInventory();
        void SetPrice(IProduct product);
        decimal GetProfit();
    }
}
