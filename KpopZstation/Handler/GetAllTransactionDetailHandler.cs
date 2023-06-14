using KpopZstation.Model;
using KpopZstation.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Web;

namespace KpopZstation.Handler
{
    public class GetAllTransactionDetailHandler
    {
        public static List<TransactioDetail> handle(int TransactionID)
        {
            try
            {
                return TransactionDetailRepository.getTransactioDetailList(TransactionID);
            }
            catch 
            { 
                return null;
            }
        }
    }
}