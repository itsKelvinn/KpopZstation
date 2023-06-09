using KpopZstation.Handler;
using KpopZstation.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KpopZstation.Controller
{
    public class ArtistController
    {
        public static List<Artist> getAllArtist()
        {
            return GetAllArtistHandler.handle();
        }

        public static bool addArtist(string ArtistName , string ImagePath)
        {
            return AddArtistHandler.handle(ArtistName, ImagePath);
        }
    }
}