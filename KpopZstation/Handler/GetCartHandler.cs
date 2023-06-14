using KpopZstation.Model;
using KpopZstation.Validator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KpopZstation.Handler
{
    public class GetCartHandler
    {
        public static Cart handle(int CustomerID, int AlbumID)
        {
            return CartRepository.getCart(CustomerID, AlbumID);
        }
    }
}