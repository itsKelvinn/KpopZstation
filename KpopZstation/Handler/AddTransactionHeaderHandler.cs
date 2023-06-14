using KpopZstation.Factory;
using KpopZstation.Model;
using KpopZstation.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KpopZstation.Handler
{
    public class AddTransactionHeaderHandler
    {
        public static TransactionHeader handle(int CustomerID)
        {
            TransactionHeader transHeader = TransactionHeaderFactory.createTransactionHeader(CustomerID);
            return TransactionHeaderRepository.addTransactionHeader(transHeader);
        }
    }
}