using BestOfBrands.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BestOfBrands.Entities
{
    public class Counter : ICounter
    {
        public int CustomerNumber { get; set; }
        public int OrderNumber { get; set; }
        public int ProductNumber { get; set; }

        public Counter()
        {
            //todo fetch all numbers from the database
        } 

        public int NewCustomerNumber()
        {
            int toReturn = CustomerNumber;
            CustomerNumber++;
            //todo write new number to database

            return toReturn;
        }

        public int NewOrderNumber()
        {
            int toReturn = OrderNumber;
            OrderNumber++;
            //todo write new number to database

            return toReturn;
        }

        public int NewProductNumber()
        {
            int toReturn = ProductNumber;
            ProductNumber++;
            //todo write new number to database

            return toReturn;
        }
    }
}