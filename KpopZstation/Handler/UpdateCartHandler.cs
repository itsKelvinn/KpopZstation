using KpopZstation.Validator;
using KpopZstation.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KpopZstation.Handler
{
    public class UpdateCartHandler
    {
        public static bool handle(int CustomerID, int AlbumID , int Quantity)
        {
           return CartRepository.updateCart(CustomerID,AlbumID, Quantity);
        }
    }
}