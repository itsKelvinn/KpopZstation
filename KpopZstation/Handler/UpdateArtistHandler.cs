using KpopZstation.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KpopZstation.Handler
{
    public class UpdateArtistHandler
    {
        public static bool handler(int ArtistID, string ArtistName , string ArtistImage)
        {
            return ArtistRepository.updateArtist(ArtistID , ArtistName, ArtistImage);
        }
    }
}