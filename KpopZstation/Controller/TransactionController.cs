using KpopZstation.Handler;
using KpopZstation.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Web;

namespace KpopZstation.Controller
{
    public class TransactionController
    {
        public static void createTransaction(int CustomerID , int AlbumID , int Quantity)
        {
            TransactionHeader transHeader = AddTransactionHeaderHandler.handle(CustomerID);
            AddTransactionDetailHandler.handle(transHeader.TransactionID, AlbumID, Quantity);
        }

        public static List<TransactioDetail> getAllTransactionDetail(int TransactionID)
        {
            return GetAllTransactionDetailHandler.handle(TransactionID);
        }

        public static List<TransactionHeader> getAllTransactionHeader(int CustomerID)
        {
            return GetAllTransactionHeaderHandler.handle(CustomerID);
        }

        public static TransactioDetail getTransactionDetail(int TransactionID) 
        {
            return GetTransactionDetailHandler.handle(TransactionID);
        }

    }
}