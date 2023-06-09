using KpopZstation.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace KpopZstation.View
{
    public partial class Register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string CustomerName = nameTxtbox.Text.ToString();
            string CustomerEmail = emailTxtbox.Text.ToString();
            string CustomerPassword = passwordTxtbox.Text.ToString();
            string CustomerGender = genderRadioButtonList.Text.ToString();
            string CustomerAddress = addressTxtbox.Text.ToString();
            string CustomerRole = "Admin";

            CustomerController.register(CustomerName, CustomerEmail, CustomerPassword, CustomerGender, CustomerAddress, CustomerRole);

            Response.Redirect("Login.aspx");
        }
    }
}