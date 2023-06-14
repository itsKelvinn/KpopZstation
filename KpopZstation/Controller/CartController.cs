using KpopZstation.Handler;
using KpopZstation.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
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
        
        public static bool updateCart(int CustomerID, int AlbumID , int Quantity)
        {
            return UpdateCartHandler.handle(CustomerID, AlbumID , Quantity);
        }

        public static bool removeCart(int CustomerID, int AlbumID)
        {
            return RemoveCartHandler.handle(CustomerID,AlbumID);
        }

        public static bool removeAllCart(int CustomerID)
        {
            return RemoveAllCartHandle.handle(CustomerID);
        }

        public static Cart checkCart(int CustomerID, int AlbumID)
        {
            return GetCartHandler.handle(CustomerID,AlbumID);
        }

    }
}