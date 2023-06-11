using KpopZstation.Validator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KpopZstation.Handler
{
    public class RemoveAllCartHandle
    {
        public static bool handle(int CustomerID)
        {
            return CartRepository.removeAllCart(CustomerID);
        }
    }
}