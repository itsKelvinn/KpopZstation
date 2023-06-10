using KpopZstation.Controller;
using KpopZstation.Validator;
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
            string CustomerRole = "User";

            int checkCount = 0;

            if (RegisterValidator.nameValidate(CustomerName))
            {
                errorNamelbl.Text = "Must be filled and between 5 and 50 characters";
                errorNamelbl.Visible = true;
                nameTxtbox.Style["border"] = "1px solid #DC4C64";
                nameTxtbox.Style["background"] = "#ffebee";
                checkCount++;
            }
            else
            {
                errorNamelbl.Visible = false;
                nameTxtbox.Style["border"] = "1px solid black";
                nameTxtbox.Style["background"] = "white";
            }

            if(RegisterValidator.emailValidate(CustomerEmail))
            {
                errorEmaillbl.Text = "Must be filled and unique among the customer’s email";
                errorEmaillbl.Visible = true;
                emailTxtbox.Style["border"] = "1px solid #DC4C64";
                emailTxtbox.Style["background"] = "#ffebee";
                checkCount++;
            }
            else
            {
                errorEmaillbl.Visible = false;
                emailTxtbox.Style["border"] = "1px solid black";
                emailTxtbox.Style["background"] = "white";
            }

            if(RegisterValidator.passwordValidate(CustomerPassword))
            {
                errorPaswordLbl.Text = "Must be filled and alphanumeric";
                errorPaswordLbl.Visible = true;
                passwordTxtbox.Style["border"] = "1px solid #DC4C64";
                passwordTxtbox.Style["background"] = "#ffebee";
                checkCount++;
            }
            else
            {
                errorPaswordLbl.Visible = false;
                passwordTxtbox.Style["border"] = "1px solid black";
                passwordTxtbox.Style["background"] = "white";
            }

            if(RegisterValidator.genderValidate(CustomerGender))
            {
                errorGenderlbl.Text = "Must be selected";
                errorGenderlbl.Visible = true;
                Genderbox.Style["border"] = "1px solid #DC4C64";
                Genderbox.Style["background"] = "#ffebee";
                checkCount++;
            }
            else
            {
                errorGenderlbl.Visible = false;
                Genderbox.Style["border"] = "1px solid black";
                Genderbox.Style["background"] = "white";
            }

            if(RegisterValidator.addressValidate(CustomerAddress))
            {
                errorAddresslbl.Text = "Must be filled and ends with ‘Street’";
                errorAddresslbl.Visible = true;
                addressTxtbox.Style["border"] = "1px solid #DC4C64";
                addressTxtbox.Style["background"] = "#ffebee";
                checkCount++;
            }
            else
            {
                errorAddresslbl.Visible = false;
                addressTxtbox.Style["border"] = "1px solid black";
                addressTxtbox.Style["background"] = "white";
            }

            if(checkCount == 0)
            {
                CustomerController.register(CustomerName, CustomerEmail, CustomerPassword, CustomerGender, CustomerAddress, CustomerRole);
                Response.Redirect("Login.aspx");
            }
        }
    }
}