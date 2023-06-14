using KpopZstation.Model;
using KpopZstation.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KpopZstation.Handler
{
    public class GetTransactionDetailHandler
    {
        public static TransactioDetail handle(int TransactionID)
        {
            try
            {
                return TransactionDetailRepository.findTransactionDetail(TransactionID);
            }
            catch
            {
                return null;
            }
        }

    }
}