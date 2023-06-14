using KpopZstation.Model;
using KpopZstation.Validator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KpopZstation.Handler
{
    public class RemoveCartHandler
    {
        public static bool handle(int CustomerID, int AlbumID)
        {
            return CartRepository.deleteCart(CustomerID, AlbumID);
        }
    }
}