using KpopZstation.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KpopZstation.Factory
{
    public class TransactionDetailFactory
    {
        public static TransactioDetail createTransactionDetail(int TranscationID , int AlbumID , int Qty)
        {
            TransactioDetail transDetail = new TransactioDetail();
            transDetail.TransactionID = TranscationID;
            transDetail.AlbumID = AlbumID;
            transDetail.Qty = Qty;
            return transDetail; 
        }
    }
}