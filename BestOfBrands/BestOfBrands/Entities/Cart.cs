using BestOfBrands.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BestOfBrands.Entities
{
    public class Cart : ICart
    {
        public List<IProduct> productList { get; set; }

        public bool Add(IProduct product)
        {
            try
            {
                productList.Add(product);
                return true;
            }
            catch (Exception)
            {
                return false;
            }            
        }

        public bool CheckOut()
        {
            try
            {
                // todo open CheckOut view, open this list
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool Clear()
        {
            try
            {
                productList.Clear();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public decimal CountPrice()
        {
            return productList.Sum(x => x.PriceSell);
        }

        public bool PlaceOrder()
        {
            try
            {
                Order newOrder = new Order() {
                    orderedProducts = productList,
                    /*todo find customer ID so it can be set*/
                };
                Clear();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool Remove(IProduct product)
        {
            try
            {
                productList.Remove(product);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}