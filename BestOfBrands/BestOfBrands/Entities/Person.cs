using BestOfBrands.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BestOfBrands.Entities
{
    public abstract class Person : IPerson
    {
        public string Address { get; set; }

        public string Email { get; set; }

        public string Name { get; set; }

        public string Password { get; set; }

        public string PhoneNumber { get; set; }

        public string Username { get; set; }

        public bool LogIn(string username, string password)
        {
            //todo login function
            throw new NotImplementedException();
        }

        public bool LogOut()
        {
            //todo add logout function
            throw new NotImplementedException();
        }
    }
}