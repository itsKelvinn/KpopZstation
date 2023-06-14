using KpopZstation.Factory;
using KpopZstation.Model;
using KpopZstation.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KpopZstation.Handler
{
    public class AddTransactionDetailHandler
    {
        public static TransactioDetail handle(int TransactionID,int AlbumID,int Qty) 
        {
            TransactioDetail transactioDetail = TransactionDetailFactory.createTransactionDetail(TransactionID,AlbumID,Qty);
            return TransactionDetailRepository.addTransactionDetail(transactioDetail);
        }
    }
}