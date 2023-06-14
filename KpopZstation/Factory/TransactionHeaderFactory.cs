using KpopZstation.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KpopZstation.Factory
{
    public class TransactionHeaderFactory
    {
        public static TransactionHeader createTransactionHeader(int CustomerID)
        {
            TransactionHeader transactionHeader = new TransactionHeader(); 
            transactionHeader.CustomerID = CustomerID;
            transactionHeader.TransactionDate = DateTime.Now;
            return transactionHeader;
        }

    }
}