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
    public partial class ArtistDetail : System.Web.UI.Page
    {
        public Artist artist;
        public List<Album> albums;

        protected void Page_Load(object sender, EventArgs e)
        {
            int ArtistID = int.Parse(Request.QueryString["id"]);
            artist = ArtistController.getArtist(ArtistID);
            albums = ArtistController.getArtistAlbum(ArtistID);

            Customer customer = AuthController.checkSession();
            
            if (customer == null)
            {
                albumDetail.Visible = true;
            }
            else if (customer.CustomerRole.Equals("User"))
            {
                albumDetail.Visible = true;
            }
            else if (customer.CustomerRole.Equals("Admin"))
            {
                updateBtn.Visible = true;
                deleteBtn.Visible = true;
                newAlbumBtn.Visible = true;
            }

            if (albums.Count == 0)
            {
                AlbumEmpty.Visible = true;
            }
            else
            {
                AlbumCollection.Visible = true;
            }

        }
    }
}