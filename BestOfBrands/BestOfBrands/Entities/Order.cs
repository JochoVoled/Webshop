using BestOfBrands.Interfaces;
using System.Collections.Generic;

namespace BestOfBrands.Entities
{
    public class Order : IOrder
    {
        public int customerID { get; }
        public List<IProduct> orderedProducts { get; set; }
    }
}