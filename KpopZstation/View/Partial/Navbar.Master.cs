using KpopZstation.Controller;
using KpopZstation.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace KpopZstation.View.Partial
{
    public partial class Navbar : System.Web.UI.MasterPage
    {
        public Customer customer = AuthController.checkSession();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (customer == null) { 

                Avatar.Visible = false;
                HomeLink.Visible = true;
                LoginLink.Visible = true;
                RegisterLink.Visible = true;
            }
            else if (customer.CustomerRole.Equals("User"))
            {
                HomeLink.Visible = true;
                CartLink.Visible = true;
                TransactionLink.Visible = true;
                Avatar.Visible = true;
            }
            else if (customer.CustomerRole.Equals("Admin"))
            {
                HomeLink.Visible = true;
                TransactionLink.Visible = true;
                Avatar.Visible = true;
            }
        }


        protected void LogoutLink_Click(object sender, EventArgs e)
        {
            AuthController.logout();
        }
    }
}