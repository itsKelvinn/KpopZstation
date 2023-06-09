using KpopZstation.Model;
using KpopZstation.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KpopZstation.Handler
{
    public class GetCustomerHandler
    {
        public static Customer handle(string email, string password)
        {
            return CustomerRepository.find(email, password);
        }
    }
}