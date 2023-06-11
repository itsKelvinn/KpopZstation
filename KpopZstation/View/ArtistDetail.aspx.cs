using KpopZstation.Controller;
using KpopZstation.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace KpopZstation.View
{
    public partial class ArtistDetail : System.Web.UI.Page
    {
        public Artist artist;
        public List<Album> albums;

        protected void Page_Load(object sender, EventArgs e)
        {

            int ArtistID = Convert.ToInt32(Request.QueryString["id"]);
            Customer customer = AuthController.checkSession();

            artist = ArtistController.getArtist(ArtistID);
            albums = ArtistController.getArtistAlbum(ArtistID);

            if (ArtistID == 0)
            {
                Response.Redirect("/View/Home.aspx");
            }

            if (albums.Count == 0)
            {
                AlbumEmpty.Visible = true;
            }
            else
            {
                Repeater.DataSource = albums;
                Repeater.DataBind();
                AlbumCollection.Visible = true;
            }


            if (customer == null)
            {
                foreach (RepeaterItem item in Repeater.Items)
                {
                    Button albumDetail = item.FindControl("albumDetail") as Button;

                    if (albumDetail != null)
                    {
                        albumDetail.Visible = true;
                    }
                }
            }
            else if (customer.CustomerRole.Equals("User"))
            {
                foreach (RepeaterItem item in Repeater.Items)
                {
                    Button albumDetail = item.FindControl("albumDetail") as Button;

                    if (albumDetail != null)
                    {
                        albumDetail.Visible = true;
                    }
                }
            }
            else if (customer.CustomerRole.Equals("Admin"))
            {
                foreach (RepeaterItem item in Repeater.Items)
                {
                    Button deleteButton = item.FindControl("deleteBtn") as Button;
                    Button updateButton = item.FindControl("updateBtn") as Button;

                    if (deleteButton != null)
                    {
                        deleteButton.Visible = true;
                        updateButton.Visible = true;
                    }
                }
                newAlbumBtn.Visible = true;
            }
        }

        protected void Album_Update_btn(object sender, CommandEventArgs e)
        {
            if(e.CommandName == "updateAlbum")
            {
                string AlbumId = e.CommandArgument.ToString();
                Response.Redirect("/View/AlbumUpdate.aspx/?id=" + AlbumId);
            }
        }

        protected void Album_Delete_btn(object sender, CommandEventArgs e)
        {
            if (e.CommandName == "deleteAlbum")
            {
                int AlbumId = Convert.ToInt32(e.CommandArgument);
                Album album = AlbumController.findAlbum(AlbumId);
                string artistId = album.ArtistID.ToString();
                AlbumController.removeAlbum(AlbumId);
                Response.Redirect("/View/ArtistDetail.aspx/?id=" + artistId);
            }
        }

    }
}