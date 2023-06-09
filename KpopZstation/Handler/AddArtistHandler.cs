using KpopZstation.Factory;
using KpopZstation.Model;
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
            Artist artist = ArtistFactory.Artist(ArtistName, ImagePath);
            return ArtistRepository.insertArtis(artist);
        }
    }
}