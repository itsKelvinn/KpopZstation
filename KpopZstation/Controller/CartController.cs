using KpopZstation.Handler;
using KpopZstation.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KpopZstation.Controller
{
    public class CartController
    {
        public static bool addCart(int CustomerID , int AlbumID , int Quantity)
        {
            return AddCartHandler.handle(CustomerID, AlbumID, Quantity);   
        }

        public static List<Cart> getAllCart(int CustomerID)
        {
            return GetAllCartHandler.handle(CustomerID);
        }

        public static bool removeCart(Cart cart)
        {
            return RemoveCartHandler.handle(cart);
        }

        public static bool removeAllCart(int CustomerID)
        {
            return RemoveAllCartHandle.handle(CustomerID);
        }

    }
}