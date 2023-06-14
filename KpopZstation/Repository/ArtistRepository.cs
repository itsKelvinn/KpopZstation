using KpopZstation.Data;
using KpopZstation.Factory;
using KpopZstation.Handler;
using KpopZstation.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
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
            List<Artist> artists;

            try
            {
                artists = DB.Artists.ToList();
            }
            catch
            {
                artists = null;
            }

            return artists;
        }

        public static Artist getArtist(int ArtistID)
        {
            return DB.Artists.Find(ArtistID);
        }

        public static List<Album> getAllArtistAlbum(int ArtistID)
        {
            Artist artist = DB.Artists.Find(ArtistID);
            if(artist == null)
            {
                return null;
            }

            return DB.Artists.Find(ArtistID).Albums.ToList();
        }

        public static bool removeArtist(int ArtistID)
        {
            Artist artist = DB.Artists.Find(ArtistID);

            if (artist == null)
            {
                return false;
            }
            else
            {
                DB.Artists.Remove(artist);
                DB.SaveChanges ();
                return true;
            }
        }

        public static bool updateArtist(int ArtistID , string ArtistName , string ArtistImage)
        {
            Artist artist = DB.Artists.Find(ArtistID);

            if(artist != null)
            {
                artist.ArtistName = ArtistName;
                artist.ArtistImage = ArtistImage;
                DB.SaveChanges();
                return true;
            }

            return false;
        }

        public static bool checkArtist(string ArtistName)
        {
            Artist artist = DB.Artists.FirstOrDefault(a => a.ArtistName == ArtistName);
            if(artist == null)
            {
                return true;
            }

            return false;
        }

        public static Artist GetArtistByName(string artistName)
        {
            Artist artist = DB.Artists.FirstOrDefault(a => a.ArtistName == artistName);
            return artist;
        }
    }
}