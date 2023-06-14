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
        public Customer customer;

        protected void Page_Load(object sender, EventArgs e)
        {
            customer = AuthController.checkSession();

            if (customer == null) 
            { 
                HomeLink.Visible = true;
                LoginLink.Visible = true;
                RegisterLink.Visible = true;
            }
            else if (customer.CustomerRole.Equals("User"))
            {
                HomeLink.Visible = true;
                CartLink.Visible = true;
                TransactionLink.Visible = true;
                UpdateProfileLink.Visible = true;
                Deletebtn.Visible = true;
                logoutbtn.Visible = true;
            }
            else if (customer.CustomerRole.Equals("Admin"))
            {
                HomeLink.Visible = true;
                TransactionLink.Visible = true;
                UpdateProfileLink.Visible = true;
                UpdateProfileLink.Visible = true;
                logoutbtn.Visible = true;
            }
        }


        protected void LogoutLink_Click(object sender, EventArgs e)
        {
            AuthController.logout();
        }

        protected void delete_account(object sender, EventArgs e)
        {
            CustomerController.deleteCustomer(customer.CustomerID);
            AuthController.logout();
        }
    }
}