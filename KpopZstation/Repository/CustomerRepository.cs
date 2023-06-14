﻿using KpopZstation.Data;
using KpopZstation.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KpopZstation.Repository
{
    public class CustomerRepository
    {
        public static DatabaseEntities DB = DatabaseConnector.Connect();

        public static List<Customer> getAllCustomer()
        {
            return (from data in DB.Customers select data).ToList();
        }

        public static void addCustomer(Customer customer)
        {
            DB.Customers.Add(customer);
            DB.SaveChanges();
        }

        public static Customer find(string email, string password)
        {
            Customer customer = (from data in DB.Customers where data.CustomerEmail.Equals(email) && data.CustomerPassword.Equals(password) select data).FirstOrDefault();
            return customer;
        }

        public static void update(int CustomerID,string CustomerName , string CustomerEmail , string CustomerGender , string CustomerAddress , string CustomerPassword)
        {
            Customer cus = DB.Customers.Find(CustomerID);
            cus.CustomerName = CustomerName;
            cus.CustomerEmail = CustomerEmail;
            cus.CustomerGender = CustomerGender;    
            cus.CustomerAddress = CustomerAddress;
            cus.CustomerPassword = CustomerPassword;
            DB.SaveChanges();   
        }

        public static void delete(int CustomerID)
        {
            Customer cus = DB.Customers.Find(CustomerID);
            DB.Customers.Remove(cus);
            DB.SaveChanges();
        }

        public static Customer getCustomerByEmail(string CustomerEmail)
        {
            Customer customer = DB.Customers.FirstOrDefault(a => a.CustomerEmail == CustomerEmail);
            return customer;
        }

    }
}