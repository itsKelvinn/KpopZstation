using KpopZstation.Model;
using KpopZstation.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KpopZstation.Handler
{
    public class CheckCustomerEmailHandler
    {
        public static Customer handle(string customerEmail)
        {
            return CustomerRepository.getCustomerByEmail(customerEmail);
        }
    }
}