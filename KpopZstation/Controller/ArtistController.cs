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

        public static Artist getArtist(int ArtistID)
        {
            return GetArtistByIDHandler.handle(ArtistID);
        }

        public static List<Album> getArtistAlbum(int ArtistID)
        {
            return GetAllArtistAlbumHandler.handle(ArtistID);  
        }

        public static bool removeArtist(int ArtistID)
        {
            return RemoveArtistHandler.handle(ArtistID); 
        }

        public static bool updateArtist(int ArtistID, string ArtistName, string ArtistImage)
        {
            return UpdateArtistHandler.handler(ArtistID, ArtistName, ArtistImage); 
        }
    }
}