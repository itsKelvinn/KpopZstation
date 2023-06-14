using KpopZstation.Handler;
using KpopZstation.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KpopZstation.Controller
{
    public class AuthController
    {
        public static Customer checkSession()
        {
            Customer session = null;
            try
            {
                session = (Customer)HttpContext.Current.Session["login"];
            }
            catch { }

            return session;
        }

        public static bool Authenticate(string CustomerEmail, string CustomerPassword, bool rmCookie)
        {

            Customer customer = GetCustomerHandler.handle(CustomerEmail, CustomerPassword);

            if (customer == null)
            {

                return false;
            }
            else
            {

                HttpContext.Current.Session["login"] = customer;

                if (rmCookie)
                {
                    HttpCookie Emailcookie = new HttpCookie("username");
                    Emailcookie.Value = CustomerEmail;
                    Emailcookie.Expires = DateTime.Now.AddMinutes(5);
                    HttpContext.Current.Response.Cookies.Add(Emailcookie);

                    HttpCookie Passwordcookie = new HttpCookie("password");
                    Passwordcookie.Value = CustomerPassword;
                    Passwordcookie.Expires = DateTime.Now.AddMinutes(5);
                    HttpContext.Current.Response.Cookies.Add(Passwordcookie);
                }

                return true;
            }
        }

        public static void logout()
        {
            HttpContext.Current.Session.Remove("login");
            HttpContext.Current.Response.Redirect("Home.aspx");
        }
    }
}