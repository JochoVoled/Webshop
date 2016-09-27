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
            AdminDatabaseRepository = new DatabaseRepository<IAdmin>("Admins");
            ProductDatabaseRepository = new DatabaseRepository<IProduct>("Products");
        }

        public static DatabaseRepository<IAdmin> AdminDatabaseRepository { get; private set; }
        public static DatabaseRepository<IProduct> ProductDatabaseRepository { get; private set; }
    }
}