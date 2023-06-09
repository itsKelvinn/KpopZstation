using KpopZstation.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KpopZstation.Factory
{
    public class CustomerFactory
    {
        public static Customer createCustomer(string CustomerName, string CustomerEmail, string CustomerPassword, string CustomerGender, string CustomerAddress, string CustomerRole)
        {
            Customer customer = new Customer();
            customer.CustomerName = CustomerName;
            customer.CustomerEmail = CustomerEmail;
            customer.CustomerPassword = CustomerPassword;
            customer.CustomerGender = CustomerGender;
            customer.CustomerAddress = CustomerAddress;
            customer.CustomerRole = CustomerRole;

            return customer;

        }
    }
}