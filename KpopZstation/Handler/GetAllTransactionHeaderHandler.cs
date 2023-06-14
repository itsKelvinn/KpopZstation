using KpopZstation.Model;
using KpopZstation.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KpopZstation.Handler
{
    public class GetAllTransactionHeaderHandler
    {
        public static List<TransactionHeader> handle(int CustomerID)
        {
            try
            {
                return TransactionHeaderRepository.getTransactionHeaderList(CustomerID);
            }
            catch
            {
                return null;
            }

        }
    }
}