using BestOfBrands.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BestOfBrands.Enums;

namespace BestOfBrands.Entities
{
    public class Product : IProduct
    {
        public string Category { get; set; }
        public string Description { get; set; }
        public bool IsChild { get; set; }
        public string Name { get; set; }
        public decimal PriceSell { get; set; }
        public decimal PriceBuy { get; set; }
        public string ProductNumber { get; set; }
        public string Size { get; set; }
        public int StockAmount { get; set; }
        public string Gender { get; set; }

        // todo Product constructor
    }
}