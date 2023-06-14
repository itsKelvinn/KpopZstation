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
    public partial class AlbumDetail : System.Web.UI.Page
    {
        public Customer customer;
        public Album album;

        protected void Page_Load(object sender, EventArgs e)
        {
            int AlbumID;

            try
            {
                AlbumID =  int.Parse(Request.QueryString["id"]);
            }
            catch
            {
                AlbumID = 0;
            }

            customer = AuthController.checkSession();
            album = AlbumController.findAlbum(AlbumID);

            if(AlbumID == 0)
            {
                Response.Redirect("/View/Home.aspx");
            }

        }

        protected void DecreaseButton_Click(object sender, EventArgs e)
        {
            int quantity = Convert.ToInt32(quantityTextBox.Text) + -1;
            quantityTextBox.Text = quantity.ToString();
        }

        protected void IncreaseButton_Click(object sender, EventArgs e)
        {
            int quantity = Convert.ToInt32(quantityTextBox.Text) + 1;
            quantityTextBox.Text = quantity.ToString();
        }
        protected void addChart(object sender, EventArgs e)
        {
            if(customer == null)
            {
                Response.Redirect("/View/Login.aspx");
            }

            int quantity = int.Parse(quantityTextBox.Text);

            if (quantity == 0 || quantity > album.AlbumStock)
            {
                errorQuantitylbl.Visible = true;
                errorQuantitylbl.Text = "Must be filled and can’t be more than the stock album";
                ChartBox.Style["border"] = "1px solid #DC4C64";
                ChartBox.Style["background"] = "#ffebee";
            }
            else
            {
                // errorQuantitylbl.Visible = false;
                ChartBox.Style["border"] = "1px solid white";
                ChartBox.Style["background"] = "white";

                int CusID = Convert.ToInt32(customer.CustomerID);
                int AlbID = Convert.ToInt32(album.AlbumID);

                Cart cart = CartController.checkCart(CusID, AlbID);

                if (cart != null)
                {
                    CartController.updateCart(CusID, AlbID, quantity);
                }
                else
                {
                    CartController.addCart(CusID, AlbID, quantity);
                    Response.Redirect("/View/ArtistDetail.aspx/?id=" + album.ArtistID);
                }
            }

        }

    }
}