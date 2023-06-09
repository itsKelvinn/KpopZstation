using KpopZstation.Factory;
using KpopZstation.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KpopZstation.Handler
{
    public class AddCustomerHandler
    {
        public static void handle(string CustomerName, string CustomerEmail, string CustomerPassword, string CustomerGender, string CustomerAddress, string CustomerRole)
        {
            CustomerRepository.createCustomer(CustomerFactory.createCustomer(CustomerName, CustomerEmail, CustomerPassword, CustomerGender, CustomerAddress, CustomerRole));
        }
    }
}