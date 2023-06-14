using KpopZstation.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KpopZstation.Handler
{
    public class UpdateCustomerHandler
    {
        public static void handle(int CustomerID, string CustomerName, string CustomerEmail, string CustomerGender, string CustomerAddress, string CustomerPassword)
        {
            CustomerRepository.update(CustomerID, CustomerName, CustomerEmail, CustomerGender, CustomerAddress, CustomerPassword);
        }
    }
}