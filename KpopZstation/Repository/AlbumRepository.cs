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

    }
}