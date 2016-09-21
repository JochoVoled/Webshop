using System.Collections.Generic;

namespace BestOfBrands.Interfaces
{
    interface IOrder
    {
        List<IProduct> orderedProducts { get; set; }
        int customerID { get; }
    }
}
