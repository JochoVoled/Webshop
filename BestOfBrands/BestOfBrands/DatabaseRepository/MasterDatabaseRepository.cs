using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BestOfBrands.Interfaces;

namespace BestOfBrands.DatabaseRepository
{
    public static class MasterDatabaseRepository
    {
        static MasterDatabaseRepository()
        {
            ProductDatabaseRepository = new DatabaseRepository<IProduct>("Products");
        }

        public static DatabaseRepository<IProduct> ProductDatabaseRepository { get; private set; }
    }
}