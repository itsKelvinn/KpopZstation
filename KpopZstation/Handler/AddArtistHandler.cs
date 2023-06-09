using KpopZstation.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KpopZstation.Handler
{
    public class AddArtistHandler
    {
        public static bool handle(string ArtistName, string ImagePath)
        {
            return ArtistRepository.insertArtis(ArtistName, ImagePath);
        }
    }
}