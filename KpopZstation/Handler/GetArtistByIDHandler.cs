using KpopZstation.Model;
using KpopZstation.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KpopZstation.Handler
{
    public class GetArtistByIDHandler
    {
        public static Artist handle(int ArtistID)
        {
            try
            {
                return ArtistRepository.getArtist(ArtistID);
            }
            catch
            {
                return null;
            }
        }

    }
}