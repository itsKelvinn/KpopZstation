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
    public partial class Cart : System.Web.UI.Page
    {
        public static List<Model.Cart> cart;
        public Customer customer;

        protected void Page_Load(object sender, EventArgs e)
        {
            customer = AuthController.checkSession();
            
            if(customer == null || customer.CustomerRole.Equals("Admin"))
            {
                Response.Redirect("/View/Home.aspx");
            }

            cart = CartController.getAllCart(customer.CustomerID);

            RepeaterCart.DataSource = cart;
            RepeaterCart.DataBind();

        }

        protected Album getAlbum(int AlbumID)
        {
            return AlbumController.findAlbum(AlbumID);
        }

        protected void checkOut_btn(object sender, EventArgs e)
        {
            CartController.removeAllCart(customer.CustomerID);
        }

        protected void delete_cart_btn(object sender, CommandEventArgs e)
        {
            if(e.CommandName == "deleteCart")
            {
                int AlbumID = Convert.ToInt32(e.CommandArgument);
                AlbumController.removeAlbum(AlbumID);
            }
        }
    }
}