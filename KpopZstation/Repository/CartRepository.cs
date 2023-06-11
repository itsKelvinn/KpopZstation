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
            try
            {
                DB.Carts.Add(cart);
                DB.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
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

        public static bool deleteCart(Cart cart)
        {
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

    }
}