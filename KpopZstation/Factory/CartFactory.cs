using KpopZstation.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KpopZstation.Factory
{
    public class CartFactory
    {
        public static Cart createCart(int CustomerID , int AlbumID , int Qunatity)
        {
            Cart cart = new Cart();
            cart.CustomerID = CustomerID;
            cart.AlbumID = AlbumID; 
            cart.Qty = Qunatity;
            return cart;
        }

    }
}