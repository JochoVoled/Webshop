using BestOfBrands.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BestOfBrands.Entities
{
    public class Customer : Person, ICustomer
    {
        public int ID { get; set; }

        Customer(string address, string email, string name, string password, string phoneNumber, string username)
        {
            Address = address;
            Email = email;
            Name = name;
            Password = password;
            PhoneNumber = phoneNumber;
            Username = username;
            //todo add ID w/ counter
        }

        public bool EditOrder()
        {
            throw new NotImplementedException();
        }
    }
}