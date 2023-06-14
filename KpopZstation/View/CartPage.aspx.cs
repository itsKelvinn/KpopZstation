using KpopZstation.Controller;
using KpopZstation.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace KpopZstation.View
{
    public partial class CartPage : System.Web.UI.Page
    {
        public static List<Cart> cart;
        public Customer customer;
        public int total;

        protected void Page_Load(object sender, EventArgs e)
        {
            total = 0;

            customer = AuthController.checkSession();

            if (customer == null || customer.CustomerRole.Equals("Admin"))
            {
                Response.Redirect("/View/Home.aspx");
            }

            cart = CartController.getAllCart(customer.CustomerID);

            foreach(var i in cart)
            {
                total = total + (AlbumController.findAlbum(i.AlbumID).AlbumPrice * i.Qty);
            }


            RepeaterCart.DataSource = cart;
            RepeaterCart.DataBind();

        }

        public Album getAlbum(int AlbumID)
        {
            return AlbumController.findAlbum(AlbumID);
        }

        protected void checkOut_btn(object sender, EventArgs e)
        {

            foreach (var n in cart)
            {
                AlbumController.purchaseAlbum(n.AlbumID, n.Qty);
                TransactionController.createTransaction(n.CustomerID,n.AlbumID,n.Qty);
            }

            CartController.removeAllCart(customer.CustomerID);

            cart = CartController.getAllCart(customer.CustomerID);

            RepeaterCart.DataSource = cart;
            RepeaterCart.DataBind();
        }

        protected void delete_cart_btn(object sender, CommandEventArgs e)
        {
            if (e.CommandName == "deleteCart")
            {
                int AlbumID = Convert.ToInt32(e.CommandArgument);
                int CustomerID = Convert.ToInt32(customer.CustomerID);
                CartController.removeCart(AlbumID,CustomerID);
            }

            cart = CartController.getAllCart(customer.CustomerID);

            RepeaterCart.DataSource = cart;
            RepeaterCart.DataBind();

        }
    }
}