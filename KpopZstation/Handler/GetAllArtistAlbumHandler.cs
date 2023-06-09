using KpopZstation.Model;
using KpopZstation.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KpopZstation.Handler
{
    public class GetAllArtistAlbumHandler
    {
        public static List<Album> handle(int ArtistID)
        {
            try
            {
                return ArtistRepository.getAllArtistAlbum(ArtistID);
            }
            catch
            {
                return null;    
            }
        }
    }
}