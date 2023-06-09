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
    public partial class Home : System.Web.UI.Page
    {
        public string username = "Guest";

        protected void Page_Load(object sender, EventArgs e)
        {
            Customer customer = AuthController.checkSession();

            if (customer != null && customer.CustomerRole.Equals("User")) {
                username = customer.CustomerName;
            }
            else if (customer != null && customer.CustomerRole.Equals("Admin"))
            {
                username = customer.CustomerName;
                AddNewArtistBtn.Visible = true;
            }
            

        }
    }
}