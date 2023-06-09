using KpopZstation.Data;
using KpopZstation.Factory;
using KpopZstation.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KpopZstation.Repository
{
    public class ArtistRepository
    {
        public static DatabaseEntities DB = DatabaseConnector.Connect();

        public static bool insertArtis(string ArtisName, string ArtistImgPath)
        {
            Artist artist = ArtistFactory.Artist(ArtisName, ArtistImgPath);
            DB.Artists.Add(artist);
            DB.SaveChanges();
            return true;
        }

        public static List<Artist> getAll()
        {
            return DB.Artists.ToList();
        }
    }
}