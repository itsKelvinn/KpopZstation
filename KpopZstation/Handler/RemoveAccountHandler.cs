using KpopZstation.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KpopZstation.Handler
{
    public class RemoveAccountHandler
    {
        public static void handle(int CustomerID)
        {
            CustomerRepository.delete(CustomerID);
        }
    }
}