using KpopZstation.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KpopZstation.Handler
{
    public class RemoveArtistHandler
    {
        public static bool handle(int ArtistID)
        {
            return ArtistRepository.removeArtist(ArtistID);
        }
        
    }
}