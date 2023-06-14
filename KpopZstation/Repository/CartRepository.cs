using KpopZstation.Data;
using KpopZstation.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KpopZstation.Validator
{
    public class CartRepository
    {
        public static DatabaseEntities DB = DatabaseConnector.Connect();

        public static bool addChart(Cart cart)
        {
                DB.Carts.Add(cart);
                DB.SaveChanges();
                return true;
        }

        public static Cart getCart(int CustomerID, int AlbumID)
        {
            Cart cart = DB.Carts.Find(CustomerID,AlbumID);
            return cart;
        }


        public static List<Cart> getAllChart(int CustomerID)
        {
            List<Cart> carts = DB.Carts.Where(cart => cart.CustomerID == CustomerID).ToList();
            if(carts == null)
            {
                return null; 
            }

            return carts;
        }

        public static bool deleteCart(int CustomerID, int AlbumID)
        {
            Cart cart = DB.Carts.Find(AlbumID,CustomerID);
            DB.Carts.Remove(cart);
            DB.SaveChanges();
            return true;
        }

        public static bool removeAllCart(int CustomerID)
        {
            var cartsToRemove = DB.Carts.Where(cart => cart.CustomerID == CustomerID);
            DB.Carts.RemoveRange(cartsToRemove);
            DB.SaveChanges();
            return true;
        }

        public static bool updateCart(int CustomerID, int AlbumID , int Quantity)
        {
            Cart cart = getCart(CustomerID, AlbumID);

            if(cart != null)
            {
                cart.Qty = cart.Qty + Quantity;
                DB.SaveChanges();
                return true;
            }

            return false;
        }

    }
}