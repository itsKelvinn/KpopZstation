using KpopZstation.Data;
using KpopZstation.Factory;
using KpopZstation.Handler;
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

        public static bool insertArtis(Artist artist)
        {
            DB.Artists.Add(artist);
            DB.SaveChanges();
            return true;
        }

        public static List<Artist> getAll()
        {
            return DB.Artists.ToList();
        }

        public static Artist getArtist(int ArtistID)
        {
            return DB.Artists.Find(ArtistID);
        }

        public static List<Album> getAllArtistAlbum(int ArtistID)
        {
            return DB.Artists.Find(ArtistID).Albums.ToList();
        }

    }
}