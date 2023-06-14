using KpopZstation.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace KpopZstation.View
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (AuthController.checkSession() != null)
            {
                Response.Redirect("Home.aspx");
            }

            HttpCookie usernameCookie = HttpContext.Current.Request.Cookies["username"];
            if (usernameCookie != null)
            {
                emailTxtbox.Text = usernameCookie.Value;
            }

            HttpCookie passwordCookie = HttpContext.Current.Request.Cookies["password"];
            if (passwordCookie != null)
            {
                passwordTxtbox.Text = passwordCookie.Value;
            }


        }

        protected void loginBtn(object sender, EventArgs e)
        {
            string CustomerEmail = emailTxtbox.Text.ToString();
            string CustomerPassword = passwordTxtbox.Text.ToString();
            bool auth;

            try
            {
                auth = AuthController.Authenticate(CustomerEmail, CustomerPassword, CheckBox.Checked);
            }
            catch
            {
                auth = false;
            }

            if (auth)
            {
                Response.Redirect("Home.aspx");
            }
            else
            {
                ErrorLabel.Visible = true;
            }

        }
    }
}