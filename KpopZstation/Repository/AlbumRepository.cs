using KpopZstation.Data;
using KpopZstation.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KpopZstation.Repository
{
    public class AlbumRepository
    {
        public static DatabaseEntities DB = DatabaseConnector.Connect();

        public static bool AddAlbum(Album album)
        {
            DB.Albums.Add(album);
            DB.SaveChanges();   
            return true;
        }

        public static Album findAlbum(int AlbumID)
        {
            Album album = DB.Albums.Find(AlbumID);
            return album;
        } 

        public static bool removeAlbum(int AlbumID)
        {
            Album album = findAlbum(AlbumID);
            if(album == null)
            {
                return false;
            }

            DB.Albums.Remove(album);
            DB.SaveChanges();
            return true;
        }

        public static bool updateAlbum(int AlbumID,string AlbumName, string AlbumDesc, string AlbumImage, int AlbumPrice, int AlbumStock)
        {
            Album album = findAlbum(AlbumID);
            if(album == null)
            {
                return false;
            }

            album.AlbumName = AlbumName;
            album.AlbumImage = AlbumImage;
            album.AlbumPrice = AlbumPrice;
            album.AlbumStock = AlbumStock;
            album.AlbumDescription = AlbumDesc;
            DB.SaveChanges();

            return true;
        }

    }
}