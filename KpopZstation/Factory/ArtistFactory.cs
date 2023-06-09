using KpopZstation.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KpopZstation.Factory
{
    public class ArtistFactory
    {
        public static Artist Artist(string ArtistName, string artistImgPath)
        {
            Artist artist = new Artist();
            artist.ArtistName = ArtistName;
            artist.ArtistImage = artistImgPath;
            return artist;
        }
    }
}