using KpopZstation.Handler;
using KpopZstation.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KpopZstation.Controller
{
    public class CustomerController
    {
        public static Customer login(string email, string password)
        {
            return GetCustomerHandler.handle(email, password);
        }

        public static void register(string CustomerName, string CustomerEmail, string CustomerPassword, string CustomerGender, string CustomerAddress, string CustomerRole)
        {
            AddCustomerHandler.handle(CustomerName, CustomerEmail, CustomerPassword, CustomerGender, CustomerAddress, CustomerRole);
        }
    }
}