using KpopZstation.Controller;
using KpopZstation.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace KpopZstation.View
{
    public partial class TransactionHistory : System.Web.UI.Page
    {
        public Customer customer;
        public List<TransactionHeader> listTransHeader;

        protected void Page_Load(object sender, EventArgs e)
        {
            customer = AuthController.checkSession();

            if(customer == null)
            {
                Response.Redirect("/View/Home.aspx");
            }
            else if(customer.CustomerRole.Equals("Admin"))
            {
                Response.Redirect("/View/Home.aspx");
            }

            listTransHeader = TransactionController.getAllTransactionHeader(customer.CustomerID);
            
            if(listTransHeader.Count > 0 || listTransHeader == null)
            {
                transaction.Visible = true;
            }
            else
            {
                transEmpty.Visible = true;
            }

        }

        public static TransactioDetail getTransactionDetail(int TransactionID)
        {
            return TransactionController.getTransactionDetail(TransactionID);
        }

        public static Album GetAlbum(int AlbumID)
        {
            return AlbumController.findAlbum(AlbumID);  
        }

        public static Artist GetArtist(int ArtistID)
        {
            return ArtistController.getArtist(ArtistID);
        }

    }
}