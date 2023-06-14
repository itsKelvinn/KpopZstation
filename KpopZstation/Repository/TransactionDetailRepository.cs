using KpopZstation.Data;
using KpopZstation.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KpopZstation.Repository
{
    public class TransactionDetailRepository
    {
        public static DatabaseEntities DB = DatabaseConnector.Connect();

        public static TransactioDetail addTransactionDetail(TransactioDetail transactioDetail)
        {
            DB.TransactioDetails.Add(transactioDetail); 
            return transactioDetail;    
        }

        public static List<TransactioDetail> getTransactioDetailList(int TransactionID)
        {
            return DB.TransactioDetails.ToList();
        }

        public static TransactioDetail findTransactionDetail(int TransactionID)
        {
            return DB.TransactioDetails.Where(td => td.TransactionID == TransactionID).FirstOrDefault();
        }

    }
}