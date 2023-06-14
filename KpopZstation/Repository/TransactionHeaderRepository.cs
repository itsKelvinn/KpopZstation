using KpopZstation.Data;
using KpopZstation.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace KpopZstation.Repository
{
    public class TransactionHeaderRepository
    {
        public static DatabaseEntities DB = DatabaseConnector.Connect();

        public static TransactionHeader addTransactionHeader(TransactionHeader transactionHeader)
        {
            DB.TransactionHeaders.Add(transactionHeader);
            return transactionHeader;
        }

        public static List<TransactionHeader> getTransactionHeaderList(int CustomerID)
        {
            return DB.TransactionHeaders.Where(th => th.CustomerID == CustomerID).ToList();
        }

    }
}