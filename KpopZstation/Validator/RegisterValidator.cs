using KpopZstation.Controller;
using KpopZstation.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using static System.Net.Mime.MediaTypeNames;

namespace KpopZstation.Validator
{
    public class RegisterValidator
    {

        // Name Validator 
        public static bool nameValidate(string CustomerName)
        {
            if(CustomerName.Length < 5 || CustomerName.Length > 50)
            {
                return true;
            }

            return false;   
        }

        // Email Validator
        public static bool emailValidate(string CustomerEmails)
        {
            Customer customer = CustomerController.checkUnikEmail(CustomerEmails);

            if (string.IsNullOrEmpty(CustomerEmails) || !CustomerEmails.Contains("@") || customer != null)
            {
                return true;
            }

            return false;
        }

        // Gender Validate 
        public static bool genderValidate(string CustomerGender)
        {
            if (string.IsNullOrEmpty(CustomerGender))
            {
                return true;
            }

            return false;
        }

        // Street Validate
        public static bool addressValidate (string CustomerAddress)
        {
            if (string.IsNullOrEmpty(CustomerAddress))
            {
                return true;
            }

            string[] sentences = CustomerAddress.Split('.');
            string lastSentence = sentences[sentences.Length - 1].Trim();

            if (!lastSentence.EndsWith("Street"))
            {
                return true;
            }

            return false;
        }

        // Password Validate
        public static bool passwordValidate(string CustomerPassword)
        {
            if (string.IsNullOrEmpty(CustomerPassword))
            {
                return true;
            }

            foreach (char c in CustomerPassword)
            {
                if (!char.IsLetterOrDigit(c))
                {
                    return true;
                }
            }

            return false;
        }


    }
}