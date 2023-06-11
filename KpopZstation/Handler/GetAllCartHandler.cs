using KpopZstation.Model;
using KpopZstation.Validator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KpopZstation.Handler
{
    public class GetAllCartHandler
    {
        public static List<Cart> handle(int CustomerID)
        {
            return CartRepository.getAllChart(CustomerID);
        }

    }
}