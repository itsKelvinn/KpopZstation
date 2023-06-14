using KpopZstation.Factory;
using KpopZstation.Model;
using KpopZstation.Validator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KpopZstation.Handler
{
    public class AddCartHandler
    {
        public static bool handle(int CustomerID , int AlbumID , int Quantity)
        {
            Cart cart = CartFactory.createCart(CustomerID, AlbumID, Quantity);
            return CartRepository.addChart(cart);
        }
    }
}