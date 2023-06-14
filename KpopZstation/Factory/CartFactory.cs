using KpopZstation.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KpopZstation.Factory
{
    public class CartFactory
    {
        public static Cart createCart(int CustomerID, int AlbumID, int Quantity)
        {
            Cart cart = new Cart
            {
                CustomerID = CustomerID,
                AlbumID = AlbumID,
                Qty = Quantity
            };
            return cart;
        }

    }
}