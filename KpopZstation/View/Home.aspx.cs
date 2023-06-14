using KpopZstation.Controller;
using KpopZstation.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace KpopZstation.View
{
    public partial class Home : System.Web.UI.Page
    {
        public string username = "Guest";
        public static List<Artist> Artists;

        protected void Page_Load(object sender, EventArgs e)
        {
            Artists = ArtistController.getAllArtist();

            if (Artists.Count > 0)
            {
                ArtistCollect.Visible = true;
                ArtistsRepeater.DataSource = Artists;
                ArtistsRepeater.DataBind();
            }
            else
            {
                ArtistEmpty.Visible = true;
            }

            Customer customer = AuthController.checkSession();

            if (customer != null && customer.CustomerRole.Equals("User")) {
                username = customer.CustomerName;
            }
            else if (customer != null && customer.CustomerRole.Equals("Admin"))
            {

                foreach (RepeaterItem item in ArtistsRepeater.Items)
                {
                    Button deleteButton = item.FindControl("deletebtn") as Button;

                    if (deleteButton != null)
                    {
                        deleteButton.Visible = true;
                    }
                }

                foreach (RepeaterItem item in ArtistsRepeater.Items)
                {
                    HyperLink deleteButton = item.FindControl("updatebtn") as HyperLink;

                    if (deleteButton != null)
                    {
                        deleteButton.Visible = true;
                    }
                }

                AddNewArtistBtn.Visible = true;
            }

        }

        protected void DeleteArtistBtn_Click(object sender, CommandEventArgs e)
        {
            if (e.CommandName == "delete")
            {
                int artistID = Convert.ToInt32(e.CommandArgument); 
                ArtistController.removeArtist(artistID);

                // Refresh
                Artists = ArtistController.getAllArtist();
                ArtistsRepeater.DataSource = Artists;
                ArtistsRepeater.DataBind();
            }
        }
    }
}