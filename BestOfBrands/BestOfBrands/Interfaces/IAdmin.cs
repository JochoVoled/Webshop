using System.Collections.Generic;

namespace BestOfBrands.Interfaces
{
    interface IAdmin
    {
        bool EditOrder();
        bool AddProduct();
        bool RemoveProduct();
        List<IProduct> ViewInventory();
        bool SetPrice(IProduct product);
        decimal GetProfit();
    }
}
